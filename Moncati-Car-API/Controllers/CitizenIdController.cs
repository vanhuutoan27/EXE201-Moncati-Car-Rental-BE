using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizenIdController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CitizenIdController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateCitizenId([FromBody] CreateCitizenIdRequest request)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            var result = await _serviceManager.CitizenIdService.CreateCitizenIdAsync(request);
            if (request == null)
            {
                return new ResultModel
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Success = false,
                    Message = "Create Fail."
                };
            }
            return new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Data = result
            };
        }
    }
}
