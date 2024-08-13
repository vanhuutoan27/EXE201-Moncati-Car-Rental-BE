using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;
using System.Web;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/cars")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public CarController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string search = null)
        {
            var listcar = await _serviceManager.CarService.GetAllCars(page, limit, search);
            if (listcar == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Not record is matched!!!",
                    Status = (int)HttpStatusCode.NotFound
                };

            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listcar,
                Message = "Get All Car Successfully"
            };
            return Ok(_resultModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateCarRequest createCarRequest)
        {
            if (!ModelState.IsValid)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest

                };
                return BadRequest(_resultModel);
            }

            var result = await _serviceManager.CarService.AddCar(createCarRequest);
            if (result == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Create Car failed."
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Create car successfully.",
                Data = result
            };
            return Ok(_resultModel);
        }
        [HttpGet]
        [Route("{carId:guid}")]
        public async Task<ActionResult<ResultModel>> GetCarbyId(Guid carId)
        {
            var query = await _serviceManager.CarService.GetCarByCarId(carId);
            if (query == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Car does not exist!"
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Get Car by Id Successfully!",
                Data = query
            });
        }
        [HttpGet]
        [Route("{slug}")]
        public async Task<ActionResult<ResultModel>> GetCarbyslug(string slug)
        {
            // Giải mã slug (nếu cần)
            slug = HttpUtility.UrlDecode(slug);

            var car = await _serviceManager.CarService.GetCarBySlug(slug);
            if (car == null)
            {
                return NotFound(new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Car does not exist!"
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Get Car by slug Successfully!",
                Data = car
            });
        }


        [HttpPut("{carId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid carId, CreateUpdateCarRequest createCarRequest)
        {

            var update = await _serviceManager.CarService.UpdateCar(carId, createCarRequest);
            if (!update)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Update fail."
                };
                return _resultModel;
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = update,
                Message = "Update Car Successfully",
            };
            return _resultModel;
        }
        [HttpDelete("{carId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid carId)
        {

            if (carId == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Car does not exist!"
                };
                return _resultModel;
            }
            var delete = await _serviceManager.CarService.DeleteCar(carId);
            return _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Delete Car Successfully!",
                Data = delete
            };
        }

        [HttpPatch("{carId}")]
        public async Task<ActionResult<ResultModel>> ChangeStatusCar(Guid carId)
        {
            if (carId == Guid.Empty)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Car does not exist!"
                };
                return NotFound(_resultModel);
            }

            var result = await _serviceManager.CarService.ChangeStatusAsync(carId);

            if (!result)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Failed to change car status!"
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Change Status Successfully!",
                Data = result
            };

            return Ok(_resultModel);
        }

    }
}
