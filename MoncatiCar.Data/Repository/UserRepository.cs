﻿using Microsoft.EntityFrameworkCore;
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
            return await _context.Users.Include(dr => dr.DrivingLicenses)
                 .Include(ct => ct.CitizenId).Where(p => p.Id == id).FirstOrDefaultAsync();
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
            return await _context.Users.Include(dr => dr.DrivingLicenses)
                 .Include(ct => ct.CitizenId)
                      .Where(p => p.UserName == username).FirstOrDefaultAsync();
        }


// //            searchName = searchName?.Trim();
//             if (string.IsNullOrEmpty(searchName))
//             {
//                 if (page > 0 && limit > 0)
//                 {
//                     return await _context.Brands.Skip((page - 1) * limit).Take(limit).ToListAsync();
//                 }
//                 return await _context.Brands.ToListAsync();
//             }
//             else
//             {
//                 return await _context.Brands
//                     .Where(s => s.BrandName.ToLower().Contains(searchName.ToLower()))
//                     .Skip((page - 1) * limit).Take(limit).ToListAsync();
//             }
     public async Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit, string search, bool? status)
    {
    IQueryable<AppUser> query = _context.Users;

    // Thêm các bảng liên quan
    query = query.Include(dr => dr.DrivingLicenses)
                 .Include(ct => ct.CitizenId);

    // Tìm kiếm theo từ khóa
    if (!string.IsNullOrEmpty(search))
    {
        search = search.ToLower();
        query = query.Where(s => (s.UserName.ToLower().Contains(search) ||
                                  s.Email.ToLower().Contains(search) ||
                                  s.FullName.ToLower().Contains(search)) &&
                                  (!status.HasValue || s.Status == status.Value));
    }

    // Lọc theo status nếu có giá trị
    if (status.HasValue)
    {
        query = query.Where(s => s.Status == status.Value);
    }

    // Phân trang
    if (page > 0 && limit > 0)
    {
        query = query.Skip((page - 1) * limit).Take(limit);
    }

    // Trả về danh sách người dùng
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

        public async Task<AppUser> GetUserByEmail(string email)
        {
           return await _context.Users.Include(dr => dr.DrivingLicenses).Include(ci => ci.CitizenId).FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
