﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
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
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string? search = null)
        {
            var brands = await _serviceManager.BrandService.GetAllBrands(page, limit, search);
            if (brands == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No brands found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = brands,
                Message = "Brands retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("{brandId}")]
        public async Task<ActionResult<ResultModel>> GetById(Guid brandId)
        {
            var brand = await _serviceManager.BrandService.GetBrandById(brandId);
            if (brand == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Brand not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = brand,
                Message = "Brand retrieved successfully."
            });
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateBrandRequest addBrandRequest)
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
            var result = await _serviceManager.BrandService.AddBrand(addBrandRequest);
            if (result == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to add brand."
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Brand added successfully."
            };
            return Ok(_resultModel);
        }

        [HttpPut("{brandId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid brandId, [FromBody] CreateUpdateBrandRequest updateBrandRequest)
        {
            var update = await _serviceManager.BrandService.UpdateBrand(brandId, updateBrandRequest);
            if (!update)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to update brand."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Brand updated successfully."
            };
            return Ok(_resultModel);
        }

        [HttpDelete("{brandId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid brandId)
        {
            var brand = await _serviceManager.BrandService.GetBrandById(brandId);
            if (brand == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Brand not found."
                });
            }
            await _serviceManager.BrandService.DeleteBrand(brandId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Brand deleted successfully."
            });
        }
    }
}
