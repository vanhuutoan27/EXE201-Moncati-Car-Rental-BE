using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarTypeController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public CarTypeController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10)
        {

            var cartypes = await _serviceManager.CarTypeService.GetAllCarTypeAsync(page, limit);
            if (cartypes == null)
            {
                _resultModel.Success = false;
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                _resultModel.Message = "Not Found List CarType";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = cartypes;
            _resultModel.Message = "Get all CarType Successfully!";
            return _resultModel;
        }
        [HttpGet]
        [Route("{carTypeId}")]
        public async Task<ActionResult<ResultModel>> GetCartypebyId(Guid carTypeId)
        {

            var cartype = await _serviceManager.CarTypeService.GetCarTypeById(carTypeId);
            if (cartype == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "cartypeId does not exist!",
                    Status = (int)HttpStatusCode.NotFound,
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Message = "Get CarType by Id Successfully!",
                Data = cartype
            };
            return Ok(_resultModel);
        }
        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddCarType(CreateUpdateCarTypeRequest carequest)
        {

            if (!ModelState.IsValid)
            {

                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Invalid data!",

                };
                return BadRequest(_resultModel);
            }
            var cartype = await _serviceManager.CarTypeService.AddCarTypeAsync(carequest);
            if (cartype == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Add CarType failed!",
                    Data=cartype
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Add CarType successfully",
                Data=cartype
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{carTypeId}")]
        public async Task<ActionResult<ResultModel>> UpdateCarTypeById(Guid carTypeId, CreateUpdateCarTypeRequest cartypeRequest)
        {
            var updateSuccess = await _serviceManager.CarTypeService.UpdateCarType(carTypeId, cartypeRequest);

            if (!updateSuccess)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Update CarType Failed!"
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Update CarType Successfully!",
                Data = updateSuccess
            };

            return Ok(_resultModel);
        }
        [HttpDelete]
        [Route("{carTypeId}")]
        public async Task<ActionResult<ResultModel>> DeleteCartypebyId(Guid carTypeId)
        {
            var carType = await _serviceManager.CarTypeService.DeleteCarTypeAsync(carTypeId);
            if (carType == null)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message= "Remove Cartype failed!"

                };
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.OK,
                    Success = true,
                    Message = "Remove CarType Sucessfully",
                    Data = carType
                };
               
            }
            return Ok(_resultModel);
        }
    }
}
