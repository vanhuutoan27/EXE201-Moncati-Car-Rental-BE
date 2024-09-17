using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;

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
    public async Task<ActionResult<ResultModel>> GetfavoritebyUser(Guid userId , int page = 1 , int limit =10){
        var favoritecar = await _serviceManager.FavoriteCarService.GetAllCarByUser(page , limit ,userId);
        return Ok(new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Favorite Car with user retrieved successfully.",
                Data = favoritecar
            });
    }
    [HttpPost]
    public async Task<ActionResult<ResultModel>> CreateFavoriteCarAsync([FromBody] CreateFavoriteCarRequest request)
    {
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
            Message = "Favorite Car added successfully."
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
                Message = "Favorite Car not found."
            };
        }
        _resultModel = new ResultModel{
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Favorite Car deleted successfully.",
        };
        return NoContent();
    }
   
}