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
            // If the response is successful, proceed with adding the payment
            /*     if (response.Success)
                 {*/
            // Extract necessary data from the response
            if (response.Success)
            {
                // Lấy thông tin thanh toán từ response
                var paymentResponseModel = response;

                // Lấy claims từ người dùng hiện tại (sử dụng User.Claims hoặc HttpContext.User.Claims)
                var claims = HttpContext.User;

                // Gọi phương thức AddtoPayment với thông tin từ claims (đợi xử lý nếu cần thiết)
                // await _serviceManager.PaymentService.AddPayment(paymentResponseModel, claims);

                // Trả về kết quả thành công cùng với dữ liệu payment
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