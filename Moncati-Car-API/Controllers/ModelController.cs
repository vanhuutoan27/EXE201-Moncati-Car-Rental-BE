using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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
        public async Task<ActionResult<ResultModel>> GetAll(int page, int limit)
        {
            var listModel = await _serviceManager.ModelService.GetAllModels(page, limit);
            if (listModel == null || !listModel.Any())
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null,
                    Message = "No models found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listModel,
                Message = "Models retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet("{brandId:guid}")]
        public async Task<ActionResult<ResultModel>> GetModelByBrandId(Guid brandId)
        {
            var models = await _serviceManager.ModelService.GetModelByBrandId(brandId);
            if (models == null || !models.Any())
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

        [HttpGet("by-name/{brandName}")]
        public async Task<ActionResult<ResultModel>> GetModelByBrandName(string brandName)
        {
            var model = await _serviceManager.ModelService.GetModelByBrandName(brandName);
            if (model == null || !model.Any())
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

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultModel>> Update(Guid id, CreateUpdateModelRequest updateModelRequest)
        {
            var update = await _serviceManager.ModelService.UpdateModel(id, updateModelRequest);
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
    }
}
