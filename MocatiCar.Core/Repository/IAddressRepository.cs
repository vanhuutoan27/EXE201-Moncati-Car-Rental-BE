using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Repository
{
    public interface IAddressRepository : IRepositoryBase<Address, Guid>
    {
        Task<IEnumerable<Address>> GetAddressesByUserId(Guid userId);
        Task<Address> GetAddressByUserIdAndAddressId(Guid userId, Guid addressId);
        void UpdateAddress(Address address);
        Task SetDefaultAddress(Guid userId, Guid addressId);
    }
}
