using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class UserService : IUserService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        public UserService(UserManager<AppUser> userManager, IRepositoryManager repositoryManager, IMapper mapper)
        {
            this._userManager = userManager;

            _repositoryManager = repositoryManager;
            _mapper = mapper;
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
                Dob = User.Dob,
                Gender = User.Gender,
                Status = false,
                Email = User.Email,
                UserName = User.UserName,
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

        public Task<bool> ChangePasswordbyId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ChangeStatusbyId(Guid id, bool isActive)
        {
            var getUser = await _repositoryManager.UserRepository.GetUserById(id);
            if (getUser == null) { 
                throw new Exception("not found any");
            }

            getUser.Status = isActive;
           var result = await _userManager.UpdateAsync(getUser);
            return result.Succeeded;


        }

        public async Task<UserReponse> GetUserById(Guid id)
        {
            var getUser = await _repositoryManager.UserRepository.GetUserById(id);
            if (getUser == null)
            {
                throw new Exception("Not Found By Customer Id");

            }
            var userResponse = _mapper.Map<UserReponse>(getUser);
            var roles = await _userManager.GetRolesAsync(getUser);
            userResponse.Role = roles.FirstOrDefault();
            return userResponse;
        }

        public async Task<IEnumerable<UserReponse>> GetUserByName(string name)
        {
            var getUsers = await _repositoryManager.UserRepository.GetUserByName(name);
            if (getUsers == null) { 
                throw new Exception("Not Found Any");
            }
            var userResponses = new List<UserReponse>();

            foreach (var user in getUsers)
            {
                var userResponse = _mapper.Map<UserReponse>(user);

                // Lấy danh sách các vai trò của người dùng
                var roles = await _userManager.GetRolesAsync(user);

                // Lấy vai trò đầu tiên (nếu có) và gán vào UserResponse
                userResponse.Role = roles.FirstOrDefault();

                userResponses.Add(userResponse);
            }

            return userResponses;
        }

        public async Task<PageResult<UserReponse>> GetUsersAsync(int page, int limit, string search)
        {
            var listUser = await _repositoryManager.UserRepository.GetUsersAsync(page, limit, search);
            var totalItems = listUser.Count();

            var listUserReponse = _mapper.Map<IEnumerable<UserReponse>>(listUser).ToList();
            var listUsers = listUser.ToList();
            //add Role
            for (int i = 0; i < listUser.Count(); i++)
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

        public async Task<bool> RemoveUser(Guid id)
        {
            if (id == null) throw new Exception("Not Found Id");
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null) throw new Exception("Not Found User");

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
            if (UserToEdit.UserName != User.UserName)
            {
                UserToEdit.UserName = User.UserName;
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
