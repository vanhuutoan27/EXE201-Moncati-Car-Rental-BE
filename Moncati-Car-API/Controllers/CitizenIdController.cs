using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/citizen")]
    [ApiController]
    public class CitizenIdController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public CitizenIdController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>>GetAll(int page = 1, int limit =10 , long? citizendId = null, bool? verify = null, string? search = null )
        {
            var listCitizend = await _serviceManager.CitizenIdService.GetAllCitizenAsync(page , limit , citizendId , verify , search);
            if(listCitizend == null){
                _resultModel = new ResultModel{
                    Success = false,
                    Message = "Get CitizendId fail.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel{
                    Success = true,
                    Message = "CitizenId retrieved successfully.",
                    Data = listCitizend,
                    Status = (int)HttpStatusCode.OK
                };
                return Ok(_resultModel);
        }
        [HttpGet]
        [Route("citizenId")]
        public async Task<ActionResult<ResultModel>>GetCitizenIdByID(Guid citizenId )
        {
            var query = await _serviceManager.CitizenIdService.GetcitizenIdAsync(citizenId);
            if(query == null){
                _resultModel = new ResultModel{
                    Success = false,
                    Message = "Get CitizendId by Id fail.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel{
                    Success = true,
                    Message = "CitizenId retrieved successfully.",
                    Data = query,
                    Status = (int)HttpStatusCode.OK
                };
                return Ok(_resultModel);
        }
        [HttpGet]
        [Route("userId")]
        public async Task<ActionResult<ResultModel>>GetCitizenIdByUserID(Guid userId )
        {
            var query = await _serviceManager.CitizenIdService.GetcitizenIdbyUserAsync(userId);
            if(query == null){
                _resultModel = new ResultModel{
                    Success = false,
                    Message = "Get CitizendId by UserId fail.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel{
                    Success = true,
                    Message = "CitizenId retrieved successfully.",
                    Data = query,
                    Status = (int)HttpStatusCode.OK
                };
                return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateCitizenId([FromBody] CreateCitizenIdRequest request)
        {
          
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
                Message = "CitizenID added successfully."
            };
        }
        [HttpPut]
        [Route("citizenId")]
        public async Task<ActionResult<ResultModel>>UpdateCitizenId( UpdateCitizenIdRequest request ,Guid citizenId ){
            var result = await _serviceManager.CitizenIdService.UpdateCitizenIdAsync(request , citizenId);
             if (request == null)
            {
                return new ResultModel
                {
                    Status = (int)HttpStatusCode.InternalServerError,
                    Success = false,
                    Message = "Update Fail."
                };
            }
            return new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "CitizenID updated successfully."
            };
        }
        [HttpPatch]
        [Route("{citizenId}/verify")]
        public async Task<ActionResult<ResultModel>> ChangeVerify(Guid citizenId)
        {
            var flagChanged = await _serviceManager.CitizenIdService.UpdateVerifyAsync(citizenId);

            if (!flagChanged)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to update verify."
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Update Verify successfully."
            };

            return Ok(_resultModel);
        }
         [HttpDelete]
        [Route("{citizenId:guid}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid citizenId)
        {
            var query = await _serviceManager.CitizenIdService.DeleteCitizenId(citizenId);
            if (query == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "CitizenId not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "CitizenId deleted successfully."
            };
            return Ok(_resultModel);
        }
    }
}
