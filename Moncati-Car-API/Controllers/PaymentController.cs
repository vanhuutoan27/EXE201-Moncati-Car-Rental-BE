using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/Payment")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;

        public PaymentController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string Status = null)
        {
            var models = await _serviceManager.paymentService.GetAllBaseStatus(page, limit, Status);
            if (models == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No Payment found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = models,
                Message = "Payment retrieved successfully."
            };

            return Ok(_resultModel);
        }

    }
}