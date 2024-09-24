using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/driving-licenses/")]
    [ApiController]
    public class DrivingLicenseController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;

        public DrivingLicenseController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }
         [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10 , string search = null , bool? verified = null)
        {
            var listdrivinglicense = await _serviceManager.DrivingLicenseService.GetAllCitizenAsync(page, limit , search , verified);
            if (listdrivinglicense == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Driving License list not found.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Message = "Driving License list retrieved successfully.",
                Data = listdrivinglicense,
                Status = (int)HttpStatusCode.OK
            };
            return Ok(_resultModel);
        }
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetByUserId(Guid userId)
        {
            var license = await _serviceManager.DrivingLicenseService.GetDrivingLicenseUserId(userId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = license,
                Message = "Driving license retrieved successfully."
            });
        }

        [HttpGet("{licenseId}")]
        public async Task<IActionResult> GetById(Guid licenseId)
        {
            var license = await _serviceManager.DrivingLicenseService.GetDrivingLicenseById(licenseId);
            if (license == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Driving license not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = license,
                Message = "Driving license retrieved successfully."
            });
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateDrivingLicenseRequest createLicense)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Invalid data."
                });
            }
            var result = await _serviceManager.DrivingLicenseService.AddDrivingLicense(createLicense);

            if (result == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to create driving license."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Driving license created successfully.",
            });
        }
        [HttpPut("{lisenceId}")]
        public async Task<IActionResult> UpdateDrivingLisence(Guid lisenceId, UpdateDrivingLicenseRequest updateDrivingLicenseRequest)
        {
            var update = await _serviceManager.DrivingLicenseService.UpdateDrivingLicense(lisenceId, updateDrivingLicenseRequest);
            if (!update)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Failed to update driving license."
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Driving license updated successfully."
            };
            return Ok(_resultModel);
        }
        [HttpDelete("{lisencedId}")]
        public async Task<IActionResult> DeleteDrivingLisence(Guid lisencedId)
        {
            var checkExistDrivingLisence = await _serviceManager.DrivingLicenseService.GetDrivingLicenseById(lisencedId);
            if (checkExistDrivingLisence == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Driving license not found."
                });
            }
            await _serviceManager.DrivingLicenseService.DeleteDrivingLisence(lisencedId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Driving license deleted successfully."
            });
        }
        [HttpPatch("{drivingLicenseId}/verify")]
        public async Task<IActionResult> VerifyDrivingLisence(Guid drivingLicenseId)
        {
            var drivingLisence = await _serviceManager.DrivingLicenseService.VeryfyDrivingLisence(drivingLicenseId);
            if (!drivingLisence)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Driving license not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Driving license verified successfully."
            });

        }
    }
}
