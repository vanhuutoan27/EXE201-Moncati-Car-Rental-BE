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
                _resultModel.Message = "Create Feature Fail!";
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Message = "Create Successfull";
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = feature;
            return _resultModel;
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllFeature()
        {
            var features = await _serviceManager.FeatureService.GetAllFeatureAsync();
            if (features == null)
            {
                _resultModel.Success = false;
                _resultModel.Message = "Not Found Features";
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Message = "Successfull";
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = features;
            return _resultModel;
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
                    Message = "Get Feature by Id failed!"
                };
            }
            _resultModel = new ResultModel
            {

                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Get Feature by Id Sucessfully!",
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
                _resultModel = new ResultModel { Status = (int)HttpStatusCode.BadRequest, Success = false, Message = "Update Feature failed!" };

            }
            _resultModel = new ResultModel { Status= (int)HttpStatusCode.OK, Success = true, Message = "Update Feature Sucessfully!" };
            return Ok(_resultModel);
        }
        [HttpDelete]
        [Route("{featureId}")]
        public async Task<ActionResult<ResultModel>> DeleteFeature(Guid featureId)
        {
            var query = await _serviceManager.FeatureService.DeleteFeature(featureId);
            if (query == false)
            {
                _resultModel = new ResultModel { Status = (int)HttpStatusCode.BadRequest, Success = false, Message = "Delete Feature failed!" };

            }
            _resultModel = new ResultModel { Status= (int)HttpStatusCode.OK, Success = true, Message = "Deete Feature Sucessfully!" };
            return Ok(_resultModel);
        }
    }
}
