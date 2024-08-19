using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Services
{
   public interface  IUserService
    {
        Task<IEnumerable<UserReponse>> GetUsersAsync(int page, int limit);
        Task<UserReponse> UpdateUser(Guid id, CreateUpdateUserRequest user);
        Task <bool>  RemoveUser (Guid id);
        Task<UserReponse> AddUser(CreateUpdateUserRequest User);

        Task <UserReponse> GetUserById(Guid id);    



    }
}
