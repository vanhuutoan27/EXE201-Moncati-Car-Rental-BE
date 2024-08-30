using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if(existingAddresses.Count() >= 5)
            {
                throw new Exception("Maximum number of addresses that can be added is 5");
            }

            // Neu dia chi moi la default
            if(addressRequest.isDefault)
            {
                foreach(var address in existingAddresses)
                {
                    if(address.isDefault)
                    {
                        address.isDefault = false;
                        _repositoryManager.AddressRepository.Update(address);
                    }
                }
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
            if(address == null)
            {
                throw new Exception("Address not found.");
            }
            // kiem tra dia chi dang xoa la dia chi mac dinh
            if(address.isDefault)
            {
                // lay tat ca dia chi cua nguoi dung
                var existingAddress = await _repositoryManager.AddressRepository.GetAddressesByUserId(userId);
                if(existingAddress.Count() <= 1)
                {
                    throw new Exception("You cannot delete the default address without setting another address as default.");
                }
                // chon 1 dia chi khac lam default
                var anotherDefault = existingAddress.Any(a => a.addressId != addressId && a.isDefault);
                if(!anotherDefault)
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
            if(existingDefault == null || existingDefault.UserId != userId)
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
            existingAddress.addressName = updateAddress.addressName;
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
