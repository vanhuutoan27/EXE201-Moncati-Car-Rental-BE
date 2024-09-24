using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Repository
{
    public class AddressRepository : RepositoryBase<Address, Guid>, IAddressRepository
    {
        public AddressRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Address>> GetAddressesByUserId(Guid userId)
        {
            return await _context.Addresses.Where(x => x.UserId == userId).ToListAsync();
        }

        public async Task<Address> GetAddressByUserIdAndAddressId(Guid userId, Guid addressId)
        {
            return await _context.Addresses.FirstOrDefaultAsync(x => x.UserId == userId && x.addressId == addressId);
        }

        public void UpdateAddress(Address address)
        {
            _context.Addresses.Update(address);
        }

        public async Task SetDefaultAddress(Guid userId, Guid addressId)
        {
            var existingDefault = await _context.Addresses
                .Where(x => x.UserId == userId)
                .ToListAsync();
            foreach (var address in existingDefault)
            {
                address.isDefault = false;
            }

            // dat dia chi muon lam mac dinh
            var newDefault = await GetAddressByUserIdAndAddressId(userId, addressId);
            if (newDefault != null)
            {
                newDefault.isDefault = true;
            }
        }

        public async Task<IEnumerable<Address>> GetAddressesByUsername(string username)
        {
            return await _context.Addresses.Include(i => i.User).Where(x => x.User.UserName == username).ToListAsync();
        }
    }
}
