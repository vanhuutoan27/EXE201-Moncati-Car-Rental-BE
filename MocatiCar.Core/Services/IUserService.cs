using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IUserService
    {
        Task<PageResult<UserReponse>> GetUsersAsync(int page, int limit, string search);
        Task<UserReponse> UpdateUser(Guid id, UpdateUserRequest user);
        Task<bool> RemoveUser(Guid id);
        Task<UserReponse> AddUser(CreateUpdateUserRequest User);

        Task<UserReponse> GetUserById(Guid id);

        Task<IEnumerable< UserReponse>> GetUserByName(string name);

        Task<bool> ChangeStatusbyId(Guid id,bool isActive);

        Task<bool> ChangePasswordbyId(Guid id); 



    }
}
