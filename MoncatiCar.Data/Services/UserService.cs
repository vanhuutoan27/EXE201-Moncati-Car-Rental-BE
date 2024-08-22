using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace MoncatiCar.Data.Services
{
    public class UserService : IUserService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public UserService(UserManager<AppUser> userManager, IRepositoryManager repositoryManager, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<UserReponse> AddUser(CreateUpdateUserRequest User)
        {
            // var userModel = _mapper.Map<AppUser>(User);


            var newUserRequest = new AppUser()
            {
                Id = Guid.NewGuid(),
                FullName = User.FullName,
                Address = User.Address,
                Avatar = User.Avatar,
                Gender = User.Gender,
                Status = false,
                Email = User.Email,
                UserName = User.Username,
                PhoneNumber = User.PhoneNumber,
                LockoutEnabled = false,
                EmailConfirmed = true,

                CreatedAt = DateTime.Now,
            };

            var result = await _userManager.CreateAsync(newUserRequest, User.Password);
            newUserRequest = await _userManager.FindByEmailAsync(User.Email);
            if (!result.Succeeded)
            {
                var errorMessages = string.Join("; ", result.Errors.Select(e => e.Description));
                throw new Exception($"User Fail: {errorMessages}");
            }
            await _userManager.AddToRoleAsync(newUserRequest, User.Role);
            var UserResponse = _mapper.Map<UserReponse>(newUserRequest);
            return UserResponse;
        }



        public async Task<bool> ChangePasswordbyId(Guid id, string currentPassword, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                throw new Exception("Somthing wrong with this account");
            }
            var isPasswordValid = await _userManager.CheckPasswordAsync(user, currentPassword);
            if (!isPasswordValid)
            {
                throw new Exception("current password is incorrect");
            }
            var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            if (!result.Succeeded)
            {
                throw new Exception("Fail to change password");
            }
            return true;

        }

        public async Task<bool> ChangeStatusbyId(Guid id)
        {
            var getUser = await _repositoryManager.UserRepository.GetUserById(id);
            if (getUser == null)
            {
                throw new Exception("not found any");
            }

            if (getUser.Status)
            {
                getUser.Status = false;
            }
            else
            {
                getUser.Status = true;
            }
            var result = await _userManager.UpdateAsync(getUser);
            return result.Succeeded;


        }

        public async Task<UserReponse> GetUserById(Guid id)
        {
            var getUser = await _repositoryManager.UserRepository.GetUserById(id);
            if (getUser == null)
            {
                throw new Exception("User not found.");

            }
            var userResponse = _mapper.Map<UserReponse>(getUser);
            var roles = await _userManager.GetRolesAsync(getUser);
            userResponse.Role = roles.FirstOrDefault();
            return userResponse;
        }

        public async Task<UserReponse> GetUserName(string name)
        {
            var getUsers = await _repositoryManager.UserRepository.GetUserName(name);
            if (getUsers == null)
            {
                throw new Exception("Not Found Any");
            }
            var user = _mapper.Map<UserReponse>(getUsers);
            var roles = await _userManager.GetRolesAsync(getUsers);
            user.Role = roles.FirstOrDefault();
            return user;
        }
     

        public async Task<PageResult<UserReponse>> GetUsersAsync(int page, int limit, string search, string currentUserId)
        {
            /*var httpContext = _httpContextAccessor.HttpContext;
            var currentUserId = httpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (string.IsNullOrEmpty(currentUserId))
            {
                throw new UnauthorizedAccessException("User is not authenticated.");
            }*/
            var currentUser = await _userManager.FindByIdAsync(currentUserId);
            var currentUserRoles = (await _userManager.GetRolesAsync(currentUser)).FirstOrDefault();//chi co 1 role


            var listUser = await _repositoryManager.UserRepository.GetUsersAsync(page, limit, search);

            var filteredUsers = new List<AppUser>();
            foreach (var user in listUser)
            {
                // Bỏ qua tài khoản của chính người dùng hiện tại
                if (currentUser.Id == user.Id)
                    continue;

                var userRoles = (await _userManager.GetRolesAsync(user)).FirstOrDefault();

                // Kiểm tra nếu người dùng hiện tại có quyền xem người dùng mục tiêu
                if (CanViewUser(currentUserRoles, userRoles))
                {
                    filteredUsers.Add(user);
                }
            }


            var totalItems = filteredUsers.Count();

            var listUserReponse = _mapper.Map<IEnumerable<UserReponse>>(filteredUsers).ToList();
            var listUsers = filteredUsers.ToList();
            //add Role
            for (int i = 0; i < filteredUsers.Count(); i++)
            {
                var roles = await _userManager.GetRolesAsync(listUsers[i]);
                listUserReponse[i].Role = roles.FirstOrDefault();
            }
            return new PageResult<UserReponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = listUserReponse
            };
        }

        private bool CanViewUser(string currentUserRole, string targetUserRole)
        {
            // Nếu người dùng hiện tại có vai trò ngang bằng hoặc thấp hơn so với người dùng mục tiêu, từ chối truy cập
            if (string.Compare(currentUserRole, targetUserRole, StringComparison.Ordinal) >= 0)
            {
                return false;
            }

            // Nếu vai trò của người dùng mục tiêu thấp hơn vai trò của người dùng hiện tại, cho phép xem
            return true;
        }
        public async Task<bool> RemoveUser(Guid id)
        {
            if (id == null) throw new Exception("Not Found Id");
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null) throw new Exception("User not found.");

            user.LockoutEnabled = true;

            user.Status = false;

            var result = await _userManager.UpdateAsync(user);

            return result.Succeeded;


        }

        public async Task<UserReponse> UpdateUser(Guid id, UpdateUserRequest User)
        {
            var UserToEdit = await _userManager.FindByIdAsync(id.ToString());
            if (UserToEdit == null) throw new Exception("Not Found User");
            var roles = await _userManager.GetRolesAsync(UserToEdit);

            // Neu Roles thay doi
            if (roles.FirstOrDefault() != User.Role)
            {
                await _repositoryManager.UserRepository.RemoveUserFromRoleAsync(UserToEdit.Id, roles.ToArray());
                var addedResult = await _userManager.AddToRoleAsync(UserToEdit, User.Role);
                if (addedResult.Succeeded)
                {
                    Console.WriteLine("Alice đã được thêm vào role 'Manager' thành công.");
                }
                else
                {
                    // Nếu có lỗi, hiển thị các lỗi
                    foreach (var error in addedResult.Errors)
                    {
                        Console.WriteLine($"Lỗi: {error.Description}");
                    }
                }
            }

            if (UserToEdit.Email != User.Email)
                UserToEdit.Email = User.Email;

            if (UserToEdit.FullName != User.FullName)
            {
                UserToEdit.FullName = User.FullName;
            }
            if (UserToEdit.UserName != User.Username)
            {
                UserToEdit.UserName = User.Username;
            }

            if (UserToEdit.PhoneNumber != User.PhoneNumber)
                UserToEdit.PhoneNumber = User.PhoneNumber;

            if (UserToEdit.Address != User.Address)
                UserToEdit.Address = User.Address;
            if (UserToEdit.Avatar != User.Avatar)
            {
                UserToEdit.Avatar = User.Avatar;
            }
            var result = await _userManager.UpdateAsync(UserToEdit);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    throw new Exception($"{error.Description}");
            }

            var UserReponse = _mapper.Map<UserReponse>(UserToEdit);

            return UserReponse;

        }

    }
}
