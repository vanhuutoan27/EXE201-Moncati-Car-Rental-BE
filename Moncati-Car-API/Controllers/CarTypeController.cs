using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/car-types")]
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
                _resultModel.Message = "No car types found.";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = cartypes;
            _resultModel.Message = "Car types retrieved successfully.";
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
                    Message = "Car type not found.",
                    Status = (int)HttpStatusCode.NotFound,
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Message = "Car type retrieved successfully.",
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
                    Message = "Failed to add car type.",
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Car type added successfully.",
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
                    Message = "Failed to update car type."
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Car type updated successfully.",
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
                    Message = "Failed to delete car type."

                };
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.OK,
                    Success = true,
                    Message = "Car type deleted successfully.",
                };

            }
            return Ok(_resultModel);
        }
    }
}
