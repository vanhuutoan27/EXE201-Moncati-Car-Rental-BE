using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.auth;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Constants;
using Moncati_Car_API.Services;
using MoncatiCar.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text.RegularExpressions;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly ITokenService _tokenService;
        private readonly ResultModel _resp;
        private readonly MocatiContext _context;
        private readonly IServiceManager _serviceManager;
        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, ITokenService tokenService, MocatiContext context, IServiceManager serviceManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _resp = new ResultModel();
            _tokenService = tokenService;
            _context = context;
            _serviceManager = serviceManager;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<ResultModel>> Login([FromBody] MocatiCar.Core.Models.auth.LoginRequest request)
        {
            AppUser user = null;


            if (IsEmail(request.Email))
            {
                user = await _userManager.FindByEmailAsync(request.Email);

            }
            else
            {
                user = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == request.Email);
                if (user == null)
                {
                    throw new Exception("Incorrect phone number.");
                }
            }

            if (user == null || !user.Status || user.LockoutEnabled)
            {
                _resp.Status = (int)HttpStatusCode.InternalServerError;
                _resp.Message = "Invalid Email.";
                _resp.Success = false;
                return _resp;
            }

            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, true);
            if (!result.Succeeded)
            {
                _resp.Status = (int)HttpStatusCode.Unauthorized;
                _resp.Message = "Incorrect Password. Please try again.";
                _resp.Success = false;
                return _resp;
            }

            // Authorization
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(ClaimTypes.NameIdentifier, user.UserName),
                 new Claim(ClaimTypes.Name, user.UserName),
                 new Claim(UserClaims.UserId, user.Id.ToString()),
                 new Claim(UserClaims.FullName, user.FullName),
                 new Claim(UserClaims.Role, string.Join(";", roles)),
                 new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var accessToken = _tokenService.GenerateAccessToken(claims);
            var refreshToken = _tokenService.GenerateRefreshToken();

            user.RefreshToken = refreshToken;
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(30);
            await _userManager.UpdateAsync(user);

            _resp.Success = true;
            _resp.Data = new AutheticatedResult()
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                ExpiredAt = user.RefreshTokenExpiryTime
            };
            _resp.Status = (int)HttpStatusCode.OK;
            _resp.Message = "Login successful.";
            return _resp;
        }
        [HttpPost]
        [Route("register")]
        [AllowAnonymous]
        public async Task<ActionResult<ResultModel>> Register([FromBody] RegisterRequests request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            //check phone
            var phoneNumberExist = await _serviceManager.UserService.CheckPhoneNumerAsync(request.PhoneNumber);
            if (phoneNumberExist)
            {
                return new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Phone number already in use.",
                    Success = false
                };
            }
            var users = new AppUser
            {
                FullName = request.FullName,
                UserName = request.Username,
                Email = request.Email,
                Status = true,
                PhoneNumber = request.PhoneNumber,
                SecurityStamp = Guid.NewGuid().ToString(),
                LockoutEnabled = false,
                CreatedAt = DateTime.Now
            };
            var result = await _userManager.CreateAsync(users, request.Password);

            if (result.Succeeded)
            {
                //users = await _userManager.FindByEmailAsync(request.Email);
                //var token = await _userManager.GenerateEmailConfirmationTokenAsync(users);
                //Console.WriteLine("yourToke: " + token);
                //var confirmationLink = $"http://localhost:1412/confirm-email/?token={Uri.EscapeDataString(token)}&email={Uri.EscapeDataString(users.Email)}&success=true";
                //var message = new Message(new string[] { users.Email! }, "Confirmation email link", $"Please confirm your account by <a href='{confirmationLink}'>clicking here</a>;.");
                //await emailSender.SendEmailAsync(message);

                await _userManager.AddToRoleAsync(users, Roles.Customer);
                _resp.Status = (int)HttpStatusCode.OK;
                _resp.Message = "Register successful.";
                _resp.Success = true;

                return _resp;
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return BadRequest(ModelState);
        }
        [HttpGet]
        [Route("me")]
        [Authorize]
        public async Task<ActionResult<ResultModel>> GetInformationOfUser()
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;

            var user = await _userManager.FindByEmailAsync(userEmail);
            if (user == null)
            {
                _resp.Status = (int)HttpStatusCode.InternalServerError;
                _resp.Message = "User not found.";
                _resp.Success = false;
            }
            var roles = await _userManager.GetRolesAsync(user);
            _resp.Status = (int)HttpStatusCode.OK;
            _resp.Message = "MONCATI";
            _resp.Success = true;
            _resp.Data = new MeResponse()
            {
                UserId = user.Id,
                Email = user.Email,
                Username = user.UserName,
                Avatar = user.Avatar,
                FullName = user.FullName,
                Role = roles.FirstOrDefault()
            };
            return _resp;
        }
        private bool IsEmail(string input)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(input, emailPattern);
        }

    }
}
