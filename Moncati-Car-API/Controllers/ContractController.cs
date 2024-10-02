using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/contracts")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ContractController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllContracts(int page = 1, int limit = 10, Guid? rentalId = null)
        {
            var result = await _serviceManager.ContactService.GetAllContracts(page, limit, rentalId);
            return new ResultModel()
            {
                Status = 200,
                Data = result,
                Message = "Contracts retrieved successfully.",
                Success = true
            };
        }

        [HttpGet("rental/{rentalId}")]
        public async Task<ActionResult<ResultModel>> GetContractByRentalId(Guid rentalId)
        {
            var result = await _serviceManager.ContactService.GetContractByRentalId(rentalId);
            return new ResultModel()
            {
                Status = 200,
                Data = result,
                Message = "Contract retrieved successfully.",
                Success = true
            };
        }
        [HttpPut]
        [Route("{contractId:guid}")]
        public async Task<ActionResult<ResultModel>> UpdateContract(UpdateContractRequest request, Guid contractId)
        {
            var contract = await _serviceManager.ContactService.UpdateContract(request, contractId);
            if (contract == null)
            {
                return BadRequest("Contract Not Found.");
            }


            return new ResultModel()
            {
                Status = 200,
                Message = "Contract update successfully.",
                Success = true
            };
        }

    }
}
