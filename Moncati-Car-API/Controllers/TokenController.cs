using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.auth;
using Moncati_Car_API.Services;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/tokens")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ITokenService _tokenService;
        private ResultModel _resultModel;

        public TokenController(UserManager<AppUser> userManager, ITokenService tokenService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }
        [HttpPost]
        [Route("refresh")]
        public async Task<ActionResult<ResultModel>> Refresh(TokenRequest tokenRequest)
        {
            if (tokenRequest == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Invalid client request",
                    Status = (int)HttpStatusCode.BadRequest
                };
                return _resultModel;
            }
            string accessToken = tokenRequest.AccessToken;
            string refreshToken = tokenRequest.RefreshToken;
            var principal = _tokenService.GetPrincipalFromExpiredToken(accessToken);
            if (principal == null || principal.Identity == null || principal.Identity.Name == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Invalid Token",
                    Status = (int)HttpStatusCode.BadRequest
                };
                return _resultModel;
            }
            var userName = principal.Identity.Name;
            var user = await _userManager.FindByNameAsync(userName);
            if (user is null || user.RefreshToken != refreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Invalid client request",
                    Status = (int)HttpStatusCode.BadRequest
                };
                return _resultModel;
            }

            var newAccessToken = _tokenService.GenerateAccessToken(principal.Claims);
            var newRefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshToken = newRefreshToken;
            await _userManager.UpdateAsync(user);

            return _resultModel = new ResultModel
            {
                Success = true,
                Message = "Refresh Successfull.",
                Status = (int)HttpStatusCode.OK,
                Data = new RefreshTokenResult() { AccessToken = newAccessToken, RefreshToken = newRefreshToken }
            };
        }



        [HttpPost, Authorize]
        [Route("revoke")]
        public async Task<IActionResult> Revoke()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null) return BadRequest();
            user.RefreshToken = null;
            user.RefreshTokenExpiryTime = null;
            await _userManager.UpdateAsync(user);
            return NoContent();
        }


    }
}
