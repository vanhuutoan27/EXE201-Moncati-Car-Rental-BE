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
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 1)
        {
            var listModel = await _serviceManager.ModelService.GetAllModels(page, limit);
            if (listModel == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Not Found",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listModel,
                Message = "Get All Model Successfully"
            };

            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<ActionResult<ResultModel>> GetById(Guid id)
        {
            var checkModelExist = await _serviceManager.ModelService.GetModelById(id);
            if (checkModelExist == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Model isn't exist!!!"
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = checkModelExist,
                Message = "GetModelById Successfully."
            });
        }

        [HttpGet]
        [Route("brand/{brandId:guid}")]
        public async Task<ActionResult<ResultModel>> GetModelByBrandId(Guid brandId)
        {
            var model = await _serviceManager.ModelService.GetModelByBrandId(brandId);
            if (model == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Model isn't exist"
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = model,
                Message = "Get Model By BrandId Successfully"
            });
        }

        [HttpGet]
        [Route("{brandName}")]
        public async Task<ActionResult<ResultModel>> GetModelByBrandName(string brandName)
        {
            var model = await _serviceManager.ModelService.GetModelByBrandName(brandName);
            if (model.IsNullOrEmpty())
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Model isn't exist"
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = model,
                Message = "Get ModelByBrandName Successfully"
            });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateModelRequest addModelRequest)
        {
            if (!ModelState.IsValid)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest
                };
            }
            var result = await _serviceManager.ModelService.AddModel(addModelRequest);
            if (result == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Create Brand fail"
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Create Model Successfully"
            };
            return Ok(_resultModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultModel>> Update(Guid id, CreateUpdateModelRequest updateModelRequest)
        {
            var update = await _serviceManager.ModelService.UpdateModel(id, updateModelRequest);
            if (!update)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Update Fail."
                });
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Update Successfully"
            };
            return Ok(_resultModel);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid id)
        {
            var checkExistModel = await _serviceManager.ModelService.GetModelById(id);
            if(checkExistModel == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Model isn't exist!!!"
                });
            }
            await _serviceManager.ModelService.DeleteBrand(id);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Delete Successfully"
            });
        }

    }
}
