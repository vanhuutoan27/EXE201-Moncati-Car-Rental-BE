using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.SeedWorks;


namespace MocatiCar.Core.Repository
{
    public interface IUserRepository : IRepositoryBase<AppUser, Guid>
    {
        Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit, string search, bool? status);
        Task<AppUser> GetUserById(Guid id);
        public Task RemoveUserFromRoleAsync(Guid userId, string[] roles);

        Task<AppUser> GetUserName(string username);
        Task<int> GetTotalUserCountAsync(string search);
        Task<AppUser> GetUserByPhoneAsync(string phoneNumber);

    }
}
