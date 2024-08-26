using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using Moncati_Car_API.Services;
using System.Net;
using System.Security.Claims;

using Microsoft.AspNetCore.Identity;


namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<AppUser> _userManager;

        private ResultModel _resultModel;

        public UserController(IServiceManager service, UserManager<AppUser> userManager)
        {
            _serviceManager = service;
            _userManager = userManager;

            _resultModel = new ResultModel();
        }

     
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string search = null)
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;
            var user = await _userManager.FindByEmailAsync(userEmail);  
            var  listusers = await _serviceManager.UserService.GetUsersAsync(page, limit, search, user.Id.ToString());
            if (listusers == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "No users found.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listusers,
                Message = "Users retrieved successfully."
            };

            return Ok(_resultModel);
        }
        [HttpGet("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserById(Guid userId)
        {
            var user = await _serviceManager.UserService.GetUserById(userId);
            if (user == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "User not found.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            else
            {
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = user,
                    Message = "User retrieved successfully."
                };
            }
            return Ok(_resultModel);
        }

        [HttpGet("{username}")]
        public async Task<ActionResult<ResultModel>> GetUserByUsername(string username)
        {
            var user = await _serviceManager.UserService.GetUserName(username);
            if (user == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "User not found.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            else
            {
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = user,
                    Message = "User found successfully."
                };
            }
            return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest
                };
            }
            var result = await _serviceManager.UserService.AddUser(request);
            if (result == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to add user."
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "User added successfully."
            };
            return Ok(_resultModel);
        }

        [HttpPut("{userId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid userId, UpdateUserRequest request)
        {
            var update = await _serviceManager.UserService.UpdateUser(userId, request);
            if (update == null)
            {
                //update fail
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to update user."
                });
            }
            // update success
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "User updated successfully."
            });
        }
        [HttpPatch("{userId}/status")]
        public async Task<ActionResult<ResultModel>> ChangeUserStatus(Guid userId)
        {
            // Gọi dịch vụ để tìm người dùng theo ID
            var update = await _serviceManager.UserService.ChangeStatusbyId(userId);

            if (!update)
            {
                //update fail
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to update user."
                });
            }
            // update success
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "User updated successfully."
            });

        }

        [HttpPut("{userId}/password")]
        public async Task<ActionResult<ResultModel>> ChangePassword(Guid userId, string currentPassword, string newPassword)
        {

            var result = await _serviceManager.UserService.ChangePasswordbyId(userId, currentPassword, newPassword);
            if (result)
            {

                return Ok(_resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Message = "Change password user successfully."
                });
            }
            else
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to change password user."
                });
            }


        }
        [HttpPut("{userId}/avatar")]
        public async Task<ActionResult<ResultModel>> ChangeAvatar([FromBody] ChangeAvatarRequest request, Guid userId)
        {
            var result = await _serviceManager.UserService.ChangeAvatar(userId, request);
            if (!result)
            {
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Failed to change avatar user."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Change avatar user successfully."
            });
        }
    }
}
