using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System;
using System.Net;
using System.Security.Claims;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/payments")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<AppUser> _userManager;

        private ResultModel _resultModel;


        public PaymentController(IServiceManager service, UserManager<AppUser> userManager)
        {
            _serviceManager = service;
            _userManager = userManager;

            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string Status = null)
        {
            var getAll = await _serviceManager.paymentService.GetAllBaseStatus(page, limit, Status);
            if (getAll == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No payments found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = getAll,
                Message = "Payment retrieved successfully."
            };

            return Ok(_resultModel);
        }

        /*     [HttpGet("{id:guid}")]*/
        [HttpGet]
        [Route("{paymentId:guid}")]

        public async Task<ActionResult<ResultModel>> getPaymentbyId(Guid paymentId)
        {
            var getPayment = await _serviceManager.paymentService.GetPaymentById(paymentId);
            if (getPayment == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No payment found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = getPayment,
                Message = "Payment retrieved successfully."
            };

            return Ok(_resultModel);
        }
        [HttpGet("user/{userId:guid}")]

        public async Task<ActionResult<ResultModel>> getPaymentbyUserId(Guid userId)
        {
            var getPayment = await _serviceManager.paymentService.GetPaymentByUserId(userId);
            if (getPayment == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No payment found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = getPayment,
                Message = "Payment retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet("rental/{rentalId:guid}")]

        public async Task<ActionResult<ResultModel>> GetPaymentRentalId(Guid rentalId)
        {
            var getPayment = await _serviceManager.paymentService.GetPaymentRentalId(rentalId);
            if (getPayment == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No payment found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = getPayment,
                Message = "Payment retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddPayment([FromBody] CreatePaymentRequest payment)
        {
            var Payment = await _serviceManager.paymentService.AddPayment(payment);
            if (Payment == false)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No payment found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = Payment,
                Message = "Payment create successfully."
            };

            return Ok(_resultModel);
        }
        [HttpPut]
        public async Task<ActionResult<ResultModel>> UpdatePaymentById([FromBody] CreateUpdateAllFieldPaymentRequest payment)
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;

            var user = await _userManager.FindByEmailAsync(userEmail);
            var Payment = await _serviceManager.paymentService.UpdatePayment(payment, user.Id);

            if (Payment == false)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Update payment fail."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = Payment,
                Message = "Update payment successfully."
            };

            return Ok(_resultModel);
        }

        [HttpDelete("{paymentId:guid}")]
        public async Task<ActionResult<ResultModel>> DeletePaymentById(Guid paymentId)
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;

            var user = await _userManager.FindByEmailAsync(userEmail);
            var Payment = await _serviceManager.paymentService.DeletePayment(paymentId, user.Id);

            if (Payment == false)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Delete payment fail."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = Payment,
                Message = "Delete payment successfully."
            };

            return Ok(_resultModel);
        }

        [HttpPatch]
        public async Task<ActionResult<ResultModel>> UpdatePaymentStatus(CreateUpdatePaymentRequest payment)
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;

            var user = await _userManager.FindByEmailAsync(userEmail);
            var Payment = await _serviceManager.paymentService.UpdateStatus(payment, user.Id);

            if (Payment == false)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Status payment Change fail."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = Payment,
                Message = "Status payment change successfully."
            };

            return Ok(_resultModel);
        }
    }
}
