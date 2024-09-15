using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

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
        public async Task<int> GetTotalUserCountAsync(string search)
        {
            if (!string.IsNullOrEmpty(search))
            {
                return await _context.Users.Where(s => s.UserName.ToLower().Contains(search.ToLower()) ||
                    s.Email.ToLower().Contains(search.ToLower())
                    || s.FullName.ToLower().Contains(search.ToLower())
                ).CountAsync();
            }
            return await _context.Users.CountAsync();
        }

        public async Task<AppUser> GetUserName(string username)
        {
            return await _context.Users
                      .Where(p => p.UserName == username).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit, string search, bool? status)
        {
            IQueryable<AppUser> query = _context.Users;
            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                query = query.Where((s => s.UserName.ToLower().Contains(search.ToLower()) ||
                    s.Email.ToLower().Contains(search.ToLower())
                    || s.FullName.ToLower().Contains(search.ToLower()) && s.Status == status));
            }
            // check status
            if(status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();
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

        public async Task<AppUser> GetUserByPhoneAsync(string phoneNumber)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber);
        }
    }
}
