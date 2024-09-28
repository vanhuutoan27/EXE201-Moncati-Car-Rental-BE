using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using static Google.Apis.Requests.BatchRequest;

namespace Moncati_Car_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VnPayController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;

        public VnPayController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }


        [HttpPost("create-payment-url")]

        public async Task<IActionResult> CreatePaymentUrl([FromBody] PaymentRequest model)
        {
            var paymentUrl = _serviceManager.VnPayService.CreatePaymentUrl(model, HttpContext);
            return Ok(Task.FromResult(paymentUrl));
        }

        [HttpGet("payment-callback")]

        public async Task<IActionResult> PaymentCallback()
        {
            var response = _serviceManager.VnPayService.PaymentExecute(Request.Query);
            var paymentResponseModel = response;

            var parts = paymentResponseModel.OrderDescription?.Split(' ') ?? new string[0];
            Guid rentalId = Guid.Empty; 

            if (parts.Length > 1)
            {
                Guid.TryParse(parts[1], out rentalId);
            }

            if (response.Success)
            {
                var claims = HttpContext.User;
                var paymentRequest = new CreatePaymentRequest
                {
                    PaymentMethod = "VNPAY",
                    PaymentStatus = "FullyPaid",
                    Amount =paymentResponseModel.AmountOfRental,
                    RentalId = rentalId,


                };
                await _serviceManager.paymentService.AddPayment(paymentRequest);

                return Ok(_resultModel = new ResultModel 
                {
                    Success = true,
                    Status = 200,
                    Data = paymentResponseModel,
                    Message = "Payment successful"
                });
            }
            else
            {
                var paymentRequest = new CreatePaymentRequest
                {
                    PaymentMethod = "VNPAY",
                    PaymentStatus = "Pending",
                    Amount = paymentResponseModel.AmountOfRental,
                    RentalId = rentalId,
                };

                await _serviceManager.paymentService.AddPayment(paymentRequest);

                // Trả về lỗi nếu thanh toán thất bại
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = 400,
                    Data = null,
                    Message = "Payment failed"
                });
            }
        }
    }
}
/* _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Invalid Token",
                    Status = (int)HttpStatusCode.BadRequest
                };
                return _resultModel;*/