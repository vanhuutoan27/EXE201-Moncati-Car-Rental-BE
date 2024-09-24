using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IUserService
    {
        Task<PageResult<UserReponse>> GetUsersAsync(int page, int limit, string search, string userid, bool? status);
        Task<UserReponse> UpdateUser(Guid id, UpdateUserRequest user);
        Task<bool> RemoveUser(Guid id);
        Task<UserReponse> AddUser(CreateUpdateUserRequest User);

        Task<UserReponse> GetUserById(Guid id);

        Task<UserReponse> GetUserName(string name);

        Task<bool> ChangeStatusbyId(Guid id);

        Task<bool> ChangePasswordbyId(Guid id, string currentPassword, string newPassword);

        Task<bool> ChangeAvatar(Guid userId, ChangeAvatarRequest request);
        Task<bool> CheckPhoneNumerAsync(string phoneNumber);
        Task<bool> UpdateUserRoleCustomer(Guid userId, UpdateUserRoleCustomerRequest updateCustomer);
        Task<AppUser>GetUserByEmail(string email);

    }
}
