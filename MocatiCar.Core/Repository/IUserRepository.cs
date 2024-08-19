using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.SeedWorks;


namespace MocatiCar.Core.Repository
{
    public interface IUserRepository : IRepositoryBase<AppUser, Guid>
    {
        Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit, string search);
        Task<AppUser> GetUserById(Guid id);
        public Task RemoveUserFromRoleAsync(Guid userId, string[] roles);



    }
}
