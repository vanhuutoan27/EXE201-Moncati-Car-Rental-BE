using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/models")]
    [ApiController]
    public class ModelController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;

        public ModelController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string search = null)
        {
            var models = await _serviceManager.ModelService.GetAllModels(page, limit, search);
            if (models == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No models found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = models,
                Message = "Models retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("{modelId:guid}")]
        public async Task<ActionResult<ResultModel>> GetById(Guid modelId)
        {
            var checkModelExist = await _serviceManager.ModelService.GetModelById(modelId);
            if (checkModelExist == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Model not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = checkModelExist,
                Message = "Model retrieved successfully."
            });
        }

        [HttpGet]
        [Route("brand/{brandId:guid}")]
        public async Task<ActionResult<ResultModel>> GetModelByBrandId(Guid brandId)
        {
            var checkBrandId = await _serviceManager.BrandService.GetBrandById(brandId);
            if(checkBrandId == null)
            {
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "BrandId doesn't exist."
                });
            }
            var models = await _serviceManager.ModelService.GetModelByBrandId(brandId);
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = models,
                Message = "Models retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet("brand/{brandName}")]
        public async Task<ActionResult<ResultModel>> GetModelByBrandName(string brandName)
        {
            var model = await _serviceManager.ModelService.GetModelByBrandName(brandName);           
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = model,
                Message = "Models retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateModelRequest addModelRequest)
        {
            if (!ModelState.IsValid)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Invalid data."
                };
                return BadRequest(_resultModel);
            }
            var result = await _serviceManager.ModelService.AddModel(addModelRequest);
            if (result == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Failed to add model."
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Model added successfully."
            };
            return Ok(_resultModel);
        }

        [HttpPut("{modelId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid modelId, [FromBody]CreateUpdateModelRequest updateModelRequest)
        {
            var update = await _serviceManager.ModelService.UpdateModel(modelId, updateModelRequest);
            if (!update)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Failed to update model."
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Model updated successfully."
            };
            return Ok(_resultModel);
        }

        [HttpDelete("{modelId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid modelId)
        {
            var checkExistModel = await _serviceManager.ModelService.GetModelById(modelId);
            if (checkExistModel == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Model not found."
                });
            }
            await _serviceManager.ModelService.DeleteBrand(modelId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Model deleted successfully."
            });
        }
    }
}
