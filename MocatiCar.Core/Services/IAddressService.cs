using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Services
{
    public interface IAddressService
    {
        Task<CreateAddressRequest> AddAddress(Guid userId, CreateAddressRequest addressRequest);
        Task<IEnumerable<AddressRespone>> GetAddressesByUserId(Guid userId);
        Task<AddressRespone> GetAddressByUserIdAndAddressId(Guid userId, Guid addressId);
        Task<bool> UpdateAddress(Guid userid, Guid addressId, UpdateAddressRequest updateAddress);
        Task<bool> DeleteAddress(Guid userId, Guid addressId);
        Task<bool> SetDefaultAddress(Guid userId, Guid addressId);
        Task<IEnumerable<GetAddressByUsernameRespone>> GetAddressesByUsername(string username);
    }
}
