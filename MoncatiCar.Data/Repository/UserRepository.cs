using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Repository
{
    public class UserRepository : RepositoryBase<AppUser, Guid>, IUserRepository
    {
        public UserRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<AppUser> GetUserById(Guid id)
        {
            return await _context.Users.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit)
        {
            if (page > 0 && limit > 0)
            {
                return await _context.Users.Skip((page - 1) * limit).Take(limit).ToListAsync();
            }
            return await _context.Users.ToListAsync();
        }

        public async Task RemoveUserFromRoleAsync(Guid userId, string[] roles)
        {
            if (roles.Length == 0 || roles == null)
            {
                return;
            }
            foreach (var role in roles)
            {
                var roledb = await _context.Roles.FirstOrDefaultAsync(r => r.Name == role);
                if (roledb == null)
                {
                    return;
                }
                var userRole = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == roledb.Id);
                if (userRole == null)
                {
                    return;
                }
                _context.UserRoles.Remove(userRole);
            }

        }
    }
}
