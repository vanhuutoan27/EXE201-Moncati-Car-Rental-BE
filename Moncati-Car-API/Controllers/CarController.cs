using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;
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
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string search = null, bool? status = null , string brand = null,
            string model = null , string transmission = null, string fuel = null , string location = null , string sortedBy = null, string order = null)
        {
            var cars = await _serviceManager.CarService.GetAllCars(page, limit, search, status, fuel, brand , model , transmission , location , sortedBy,order  );
            if (cars == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "No cars found.",
                    Status = (int)HttpStatusCode.NotFound
                };

            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = cars,
                Message = "Cars retrieved successfully."
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
                    Message = "Failed to add car."
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Car added successfully.",
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
                    Message = "Car not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Car retrieved successfully.",
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
                    Message = "Car not found."
                });
            }
            return Ok(new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Car with slug retrieved successfully.",
                Data = car
            });
        }

        [HttpGet]
        [Route("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetCarbyUser(Guid userId, int page = 1, int limit = 10, bool? status = null)
        {
            // Giải mã slug (nếu cần)


            var car = await _serviceManager.CarService.GetAllCarByUser(page, limit, status, userId);
            //if (car == null)
            //{
            //    return NotFound(new ResultModel
            //    {
            //        Success = false,
            //        Status = (int)HttpStatusCode.NotFound,
            //        Message = "Car not found."
            //    });
            //}
            return Ok(new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Car with user retrieved successfully.",
                Data = car
            });
        }
        [HttpPut("{carId}/admin")]
        public async Task<ActionResult<ResultModel>> Update(Guid carId, UpdateCarRequest createCarRequest)
        {
            try
            {
                var updateResult = await _serviceManager.CarService.UpdateCar(carId, createCarRequest);
                if (!updateResult)
                {
                    _resultModel = new ResultModel
                    {
                        Success = false,
                        Status = (int)HttpStatusCode.NotFound,
                        Message = "Failed to update car. The car with the provided ID was not found."
                    };
                    return NotFound(_resultModel);
                }

                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Message = "Car updated successfully."
                };
                return Ok(_resultModel);
            }
            catch (Exception ex)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = $"An error occurred while updating the car: {ex.Message}"
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
        }
        [HttpPut("{carId}/customer")]
        public async Task<ActionResult<ResultModel>> UpdateBycustomer(Guid carId, UpdateCarByCustomer update)
        {
            try
            {
                var updateResult = await _serviceManager.CarService.UpdateCarByCustomer(carId, update);
                if (!updateResult)
                {
                    _resultModel = new ResultModel
                    {
                        Success = false,
                        Status = (int)HttpStatusCode.NotFound,
                        Message = "Failed to update car. The car with the provided ID was not found."
                    };
                    return NotFound(_resultModel);
                }

                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Message = "Car updated successfully."
                };
                return Ok(_resultModel);
            }
            catch (Exception ex)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = $"An error occurred while updating the car: {ex.Message}"
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
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
                    Message = "Car not found."
                };
                return _resultModel;
            }
            var delete = await _serviceManager.CarService.DeleteCar(carId);
            return _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Car deleted successfully.",
            };
        }

        [HttpPatch("{carId}/status")]
        public async Task<ActionResult<ResultModel>> ChangeStatusCar(Guid carId)
        {
            if (carId == Guid.Empty)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Car not found."
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
                    Message = "Failed to change status car."
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Change status car successfully.",
                Data = result
            };

            return Ok(_resultModel);
        }
        [HttpPut("{carId}/rental-status")]
        public async Task<ActionResult<ResultModel>> ChangeRentalStatusCar(Guid carId, [FromBody] CarRentalStatus status)
        {
            if (carId == Guid.Empty)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Car not found."
                };
                return NotFound(_resultModel);
            }

            var result = await _serviceManager.CarService.ChangeRentalStatusAsync(carId, status);

            if (!result)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Failed to change status car."
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Change rental status car successfully.",
            };

            return Ok(_resultModel);
        }
    }
}
