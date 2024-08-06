using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/brands")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public BrandController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page, int limit)
        {
            var listBrand = await _serviceManager.BrandService.GetAllBrands(page, limit);
            if (listBrand == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Not record is matched!!!",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listBrand,
                Message = "Get All Brand Successfully"
            };

            return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateBrandRequest addBrandRequest)
        {
            if (!ModelState.IsValid)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest
                };
            }
            var result = await _serviceManager.BrandService.AddBrand(addBrandRequest);
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
                Message = "Create Brand Successfully"
            };
            return Ok(_resultModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ResultModel>> Update(Guid id, CreateUpdateBrandRequest updateBrandRequest)
        {
            var update = await _serviceManager.BrandService.UpdateBrand(id, updateBrandRequest);
            if (!update)
            {
                //update fail
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Update Fail."
                });             
            }
            // update success
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Update Successfully"
            });
        }
    }
}
