using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/features")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public FeatureController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        //[HttpGet]

        //public async Task<ActionResult<ResultModel>> GetAll()
        //{

        //}
        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateFeatures([FromBody] CreateFeatureRequest request)
        {
            var feature = await _serviceManager.FeatureService.CreateFeaturesAsync(request);
            if (feature == null)
            {
                _resultModel.Success = false;
                _resultModel.Message = "Failed to add feature.";
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Message = "Feature added successfully.";
            _resultModel.Status = (int)HttpStatusCode.OK;
            return _resultModel;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllFeature()
        {
            var features = await _serviceManager.FeatureService.GetAllFeatureAsync();
            if (features == null)
            {
                _resultModel.Success = false;
                _resultModel.Message = "No features found.";
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Message = "Features retrieved successfully.";
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = features;
            return _resultModel;
        }

        [HttpGet("{carId:guid}")]
        public async Task<ActionResult<ResultModel>> GetFeatureByCarId(Guid carId)
        {
            var listFeature = await _serviceManager.FeatureService.GetFeatureByCarId(carId);
            if (listFeature == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No features found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listFeature,
                Message = "Features retrieved successfully."
            });
        }

        [HttpGet]
        [Route("{featureId}")]
        public async Task<ActionResult<ResultModel>> GetFeaturebyId(Guid featureId)
        {
            var id = await _serviceManager.FeatureService.GetFeatureById(featureId);
            if (id == null)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Feature not found."
                };
            }
            _resultModel = new ResultModel
            {

                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Feature retrieved successfully.",
                Data = id

            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{featureId}")]
        public async Task<ActionResult<ResultModel>> UpdateFeature(Guid featureId, CreateFeatureRequest request)
        {
            var query = await _serviceManager.FeatureService.UpdateFeature(featureId, request);
            if (query == false)
            {
                _resultModel = new ResultModel { Status = (int)HttpStatusCode.BadRequest, Success = false, Message = "Failed to update feature." };

            }
            _resultModel = new ResultModel { Status = (int)HttpStatusCode.OK, Success = true, Message = "Feature updated successfully." };
            return Ok(_resultModel);
        }
        [HttpDelete]
        [Route("{featureId}")]
        public async Task<ActionResult<ResultModel>> DeleteFeature(Guid featureId)
        {
            var query = await _serviceManager.FeatureService.DeleteFeature(featureId);
            if (query == false)
            {
                _resultModel = new ResultModel { Status = (int)HttpStatusCode.BadRequest, Success = false, Message = "Failed to delete feature." };

            }
            _resultModel = new ResultModel { Status = (int)HttpStatusCode.OK, Success = true, Message = "Feature deleted successfully." };
            return Ok(_resultModel);
        }
    }
}
