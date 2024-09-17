using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/rentals")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public RentalController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, RentalStatus? status = null, DateTime? startDate = null, DateTime? endDate = null)
        {
            var listrental = await _serviceManager.RentalService.GetAllRentalsAsync(page, limit, status, startDate, endDate);

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listrental,
                Message = "Rentals retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateRental(CreateRentalRequest createRentalRequest)
        {
            var query = await _serviceManager.RentalService.CreateRental(createRentalRequest);
            if (query == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Unable to add rental. Please try again."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "Rental added successfully."
            };
            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("{rentalId:guid}")]
        public async Task<ActionResult<ResultModel>> GetRentalById(Guid rentalId)
        {
            try
            {
                var rental = await _serviceManager.RentalService.GetRentalById(rentalId);
                if (rental == null)
                {
                    _resultModel = new ResultModel
                    {
                        Status = (int)HttpStatusCode.NotFound,
                        Success = false,
                        Message = "Rental not found."
                    };
                    return NotFound(_resultModel);
                }

                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.OK,
                    Success = true,
                    Message = "Rental retrieved successfully.",
                    Data = rental
                };
                return Ok(_resultModel);
            }
            catch (Exception ex)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Success = false,
                    Message = ex.Message,
                    Data = null
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
        }

        [HttpGet]
        [Route("car/{carId:guid}")]
        public async Task<ActionResult<ResultModel>> GetRentalByCarId(Guid carId, int page = 1, int limit = 10, RentalStatus? status = null, DateTime? startDay = null, DateTime? endDay = null)
        {
            var rentals = await _serviceManager.RentalService.GetRentalByCarId(carId, page, limit, status, startDay, endDay);

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Rentals retrieved successfully.",
                Data = rentals
            };

            return Ok(_resultModel);
        }
        [HttpGet]
        [Route("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetRentalByUserId(Guid userId, int page = 1, int limit = 10, RentalStatus? status = null, DateTime? startDay = null, DateTime? endDay = null)
        {
            var rentals = await _serviceManager.RentalService.GetRentalByUserId(userId, page, limit, status, startDay, endDay);


            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Rentals retrieved successfully.",
                Data = rentals
            };

            return Ok(_resultModel);
        }
        [HttpDelete]
        [Route("{rentalId:guid}")]
        public async Task<ActionResult<ResultModel>> DeleteRental(Guid rentalId)
        {
            var query = await _serviceManager.RentalService.DeleteRental(rentalId);
            if (query == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Rental not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Rental deleted successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{rentalId:guid}")]
        public async Task<ActionResult<ResultModel>> UpdateRental(Guid rentalId, UpdateRentalRequest updateRental)
        {
            var update = await _serviceManager.RentalService.UpdateRentalAsync(rentalId, updateRental);
            if (update == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Rental not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Rental updated successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{rentalId:guid}/start")]
        public async Task<ActionResult<ResultModel>> UpdateRentalStartTime(Guid rentalId)
        {
            var update = await _serviceManager.RentalService.UpdateStartTimeRentalAsync(rentalId);
            if (update == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Rental not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Rental updated successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{rentalId:guid}/end")]
        public async Task<ActionResult<ResultModel>> UpdateRentalEndTime(Guid rentalId)
        {
            var update = await _serviceManager.RentalService.UpdateEndTimeRentalAsync(rentalId);
            if (update == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Rental not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Rental updated successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPatch]
        [Route("{rentalId:guid}/status")]
        public async Task<ActionResult<ResultModel>> UpdateRentalStatus(Guid rentalId)
        {
            var update = await _serviceManager.RentalService.ChangeRentalStatusAsync(rentalId);
            if (update == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Rental not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Changed rental status successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPatch]
        [Route("{rentalId:guid}/cancel")]
        public async Task<ActionResult<ResultModel>> UpdateRentalStatustoCancel(Guid rentalId)
        {
            var update = await _serviceManager.RentalService.ChangeRentalStatusToCancelAsync(rentalId);
            if (update == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Rental not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Rental cancelled successfully."
            };
            return Ok(_resultModel);
        }
    }
}
