﻿using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class AddressService : IAddressService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public AddressService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CreateAddressRequest> AddAddress(Guid userId, CreateAddressRequest addressRequest)
        {
            // check so dia chi cua nguoi dung
            var existingAddresses = await _repositoryManager.AddressRepository.GetAddressesByUserId(userId);
            // neu nguoi dung da tao 5 dia chi thi khong cho tao nua
            if (existingAddresses.Count() >= 5)
            {
                throw new Exception("You have reached the maximum number of addresses (5).");
            }

            // kiem tra neu nguoi dung tao dia chi lan dau tien thi dat lam dia chi mac dinh
            if (!existingAddresses.Any())
            {
                addressRequest.isDefault = true;
            }
            else if (addressRequest.isDefault) // Neu dia chi moi la default
            {
                foreach (var address in existingAddresses)
                {
                    if (address.isDefault)
                    {
                        address.isDefault = false;
                        _repositoryManager.AddressRepository.Update(address);
                    }
                }
            }

            // check addressName
            var addressNameExist = existingAddresses.Any(a => a.addressName.Equals(addressRequest.addressName, StringComparison.OrdinalIgnoreCase));
            if(addressNameExist)
            {
                throw new Exception("You already have an address with this name.");
            }
            // Tao moi dia chi
            var createAddress = _mapper.Map<Address>(addressRequest);
            var model = new Address
            {
                UserId = userId,
                addressId = Guid.NewGuid(),
                addressName = createAddress.addressName,
                address = createAddress.address,
                locationType = createAddress.locationType,
                province = createAddress.province,
                district = createAddress.district,
                commune = createAddress.commune,
                isDefault = createAddress.isDefault,
                createdAt = DateTime.Now,
                updateAt = DateTime.Now,
            };

            _repositoryManager.AddressRepository.Add(model);
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateAddressRequest>(model);
            return result;
        }

        public async Task<bool> DeleteAddress(Guid userId, Guid addressId)
        {
            var address = await _repositoryManager.AddressRepository.GetAddressByUserIdAndAddressId(userId, addressId);
            if (address == null)
            {
                throw new Exception("Address not found.");
            }
            // kiem tra dia chi dang xoa la dia chi mac dinh
            if (address.isDefault)
            {
                // lay tat ca dia chi cua nguoi dung
                var existingAddress = await _repositoryManager.AddressRepository.GetAddressesByUserId(userId);
                if (existingAddress.Count() <= 1)
                {
                    throw new Exception("You cannot delete the default address without setting another address as default.");
                }
                // chon 1 dia chi khac lam default
                var anotherDefault = existingAddress.Any(a => a.addressId != addressId && a.isDefault);
                if (!anotherDefault)
                {
                    throw new Exception("Please set another address as default before deleting this one.");
                }
            }
            _repositoryManager.AddressRepository.Remove(address);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<AddressRespone> GetAddressByUserIdAndAddressId(Guid userId, Guid addressId)
        {
            var address = await _repositoryManager.AddressRepository.GetAddressByUserIdAndAddressId(userId, addressId);
            var result = _mapper.Map<AddressRespone>(address);
            return result;
        }

        public async Task<IEnumerable<AddressRespone>> GetAddressesByUserId(Guid userId)
        {
            var listAddress = await _repositoryManager.AddressRepository.GetAddressesByUserId(userId);
            var listResult = _mapper.Map<IEnumerable<AddressRespone>>(listAddress);

            return listResult;
        }

        public async Task<IEnumerable<GetAddressByUsernameRespone>> GetAddressesByUsername(string username)
        {
            var listAddress = await _repositoryManager.AddressRepository.GetAddressesByUsername(username);
            var listResult = _mapper.Map<IEnumerable<GetAddressByUsernameRespone>>(listAddress);
            return listResult;
        }

        public async Task<bool> SetDefaultAddress(Guid userId, Guid addressId)
        {
            // kiem tra xem nguoi dung da co dia chi default nao hay chua
            var existingDefault = await _repositoryManager.AddressRepository.GetAddressByUserIdAndAddressId(userId, addressId);
            if (existingDefault == null || existingDefault.UserId != userId)
            {
                throw new Exception("Address not found.");
            }
            await _repositoryManager.AddressRepository.SetDefaultAddress(userId, addressId);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> UpdateAddress(Guid userid, Guid addressId, UpdateAddressRequest updateAddress)
        {
            var existingAddress = await _repositoryManager.AddressRepository.GetAddressByUserIdAndAddressId(userid, addressId);
            if (existingAddress == null)
            {
                throw new Exception("Address not found.");
            }
            var existingAddresses = await _repositoryManager.AddressRepository.GetAddressesByUserId(userid);
            // Neu dia chi moi la default
            if (updateAddress.isDefault)
            {
                foreach (var address in existingAddresses)
                {
                    if (address.isDefault)
                    {
                        address.isDefault = false;
                        _repositoryManager.AddressRepository.Update(address);
                    }
                }
            }
            
            if(!string.IsNullOrEmpty(updateAddress.addressName) && existingAddress.addressName != updateAddress.addressName)
            {
                // check AddressName exist
                var addressNameExist = existingAddresses.Any(n => n.addressName.Equals(updateAddress.addressName, StringComparison.OrdinalIgnoreCase));
                if(addressNameExist)
                {
                    throw new Exception("Address name already exists.");
                }
                existingAddress.addressName = updateAddress.addressName;
            }

            // kiem tra neu nguoi dung update dia chi mac dinh thanh false thi khong cho phep cap nhat
            if (existingAddress.isDefault)
            {
                throw new Exception("Cannot update the default address.");
            }
            
            existingAddress.locationType = updateAddress.locationType;
            existingAddress.address = updateAddress.address;
            existingAddress.province = updateAddress.province;
            existingAddress.district = updateAddress.district;
            existingAddress.commune = updateAddress.commune;
            existingAddress.isDefault = updateAddress.isDefault;
            existingAddress.updateAt = DateTime.Now;

            _repositoryManager.AddressRepository.Update(existingAddress);
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
