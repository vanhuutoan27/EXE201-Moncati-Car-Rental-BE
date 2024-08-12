using MocatiCar.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;


namespace MocatiCar.Core.Repository
{
    public interface IUserRepository : IRepositoryBase<AppUser, Guid >
    {
        Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit);
        Task<AppUser> GetUserById(Guid id);
        public Task RemoveUserFromRoleAsync(Guid userId, string[] roles);



    }
}
