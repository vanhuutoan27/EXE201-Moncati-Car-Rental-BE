using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers;

[Route("api/v1/favorite-cars")]
[ApiController]
public class FavoriteCarController : ControllerBase
{
    private readonly IServiceManager _serviceManager;
    private ResultModel _resultModel;
    public FavoriteCarController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
        _resultModel = new ResultModel();
    }
    [HttpGet]
    [Route("user/{userId:guid}")]
    public async Task<ActionResult<ResultModel>> GetfavoritebyUser(Guid userId, int page = 1, int limit = 10)
    {
        var favoritecar = await _serviceManager.FavoriteCarService.GetAllCarByUser(page, limit, userId);
        return Ok(new ResultModel
        {
            Success = true,
            Status = (int)HttpStatusCode.OK,
            Message = "Favorite cars retrieved successfully.",
            Data = favoritecar
        });
    }
    [HttpPost]
    public async Task<ActionResult<ResultModel>> CreateFavoriteCarAsync([FromBody] CreateFavoriteCarRequest request)
    {
        var isAlreadyFavorited = await _serviceManager.FavoriteCarService.IsCarAlreadyFavorited(request.userId, request.carId);

        if (isAlreadyFavorited)
        {
            // Nếu xe đã được thích trước đó, trả về thông báo lỗi
            _resultModel = new ResultModel
            {
                Success = false,
                Status = (int)HttpStatusCode.BadRequest,
                Message = "This car is already favorited by the user."
            };
            return BadRequest(_resultModel);
        }
        var IsOwnerOfCar = await _serviceManager.FavoriteCarService.IsOwnerOfCar(request.userId, request.carId);
        if (IsOwnerOfCar)
        {
            return BadRequest(new ResultModel { Success = false, Status = (int)HttpStatusCode.BadRequest, Message = "You can't add this car to favorite." });
        }
        var query = await _serviceManager.FavoriteCarService.AddFavoriteCarAsync(request);
        if (query is null)
        {
            _resultModel = new ResultModel
            {
                Success = false,
                Status = (int)HttpStatusCode.InternalServerError,
                Message = "Failed to add favorite car"
            };
        }
        _resultModel = new ResultModel
        {
            Success = true,
            Status = (int)HttpStatusCode.OK,
            Message = "Favorite car added successfully."
        };
        return Ok(_resultModel);
    }

    [HttpDelete]
    [Route("{favoriteId:guid}")]
    public async Task<ActionResult<ResultModel>> Delete(Guid favoriteId)
    {
        var query = await _serviceManager.FavoriteCarService.RemoveFavoriteCarAsync(favoriteId);
        if (query is false)
        {
            _resultModel = new ResultModel
            {
                Success = false,
                Status = (int)HttpStatusCode.NotFound,
                Message = "Favorite car not found."
            };
        }
        _resultModel = new ResultModel
        {
            Success = true,
            Status = (int)HttpStatusCode.NoContent,
            Message = "Favorite car deleted successfully.",
        };
        return Ok(_resultModel);
    }

}