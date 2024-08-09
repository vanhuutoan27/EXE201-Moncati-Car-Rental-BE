using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.auth;
using MocatiCar.Core.SeedWorks.Constants;
using Moncati_Car_API.Services;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly ITokenService _tokenService;
        private readonly ResultModel _resp;

        public AuthController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _resp = new ResultModel();
            _tokenService = tokenService;
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<ResultModel>> Login([FromBody] LoginRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request");
            }
            var user = await _userManager.FindByEmailAsync(request.Email);

            if (user == null || user.IsActive == false || user.LockoutEnabled)
            {
                return Unauthorized();
            }
            var result = await _signInManager.PasswordSignInAsync(user, request.Password, false, true);
            if (!result.Succeeded)
            {
                return Unauthorized("Invalid Password");
            }

            //authorize
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                 new Claim(JwtRegisteredClaimNames.Email, user.Email),
                 new Claim(UserClaims.Id, user.Id.ToString()),
                // new Claim(ClaimTypes.NameIdentifier, user.UserName),
                new Claim(UserClaims.FullName, user.FullName),
                 //new Claim(ClaimTypes.Name, user.FullName),
                    new Claim(UserClaims.Roles, string.Join(";", roles)),
                   // new Claim(UserClaims.Permissions, JsonSerializer.Serialize(permissions)),
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
                Token = accessToken,
                RefreshToken = refreshToken,
                ExpiryTime = user.RefreshTokenExpiryTime
            };
            _resp.Status = (int)HttpStatusCode.OK;
            _resp.Message = "Login Successfull";
            return _resp;
        }
    }
}
