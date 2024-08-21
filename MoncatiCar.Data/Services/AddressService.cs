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

            var createAddress = _mapper.Map<Address>(addressRequest);
            var model = new Address
            {
                addressId = Guid.NewGuid(),
                addressName = createAddress.addressName,
                address = createAddress.address,
                locationType = createAddress.locationType,
                province = createAddress.province,
                district = createAddress.district,
                commune = createAddress.commune,
                isDefault = false,
                UserId = userId,
                createdAt = DateTime.Now,
                updateAt = DateTime.Now,
            };

            _repositoryManager.AddressRepository.Add(model);
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateAddressRequest>(model);
            return result;
        }

        public async Task<bool> DeleteAddress(Guid userId, Guid addressid)
        {
            var address = await _repositoryManager.AddressRepository.GetAddressByUserIdAndAddressId(userId, addressid);
            if(address == null)
            {
                throw new Exception("Address not found.");
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

        public async Task<bool> SetDefaultAddress(Guid userId, Guid addressId)
        {
            // kiem tra xem nguoi dung da ca dia chi default nao hay chua
            var existingDefault = await _repositoryManager.AddressRepository.GetAddressByUserIdAndAddressId(userId, addressId);
            var address = await _repositoryManager.AddressRepository.GetAddressByUserIdAndAddressId(userId, addressId);
            if(address == null || address.UserId != userId)
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

            _repositoryManager.AddressRepository.Update(existingAddress);
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
