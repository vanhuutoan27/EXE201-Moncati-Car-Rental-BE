using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/addresses")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;

        public AddressController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet("{userId:guid}")]
        public async Task<IActionResult> GetAll(Guid userId)
        {
            var listAddress = await _serviceManager.AddressService.GetAddressesByUserId(userId);
            if(listAddress == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No addresses found"
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listAddress,
                Message = "Addresses retrieved successfully."
            });
        }
        [HttpGet("{userId}/{addressId}")]
        public async Task<IActionResult> GetByUserIdAndAddressId(Guid userId, Guid addressId)
        {
            var address = await _serviceManager.AddressService.GetAddressByUserIdAndAddressId(userId, addressId);
            if(address == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No addresses found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = address,
                Message = "Address retrieved successfully."
            });
        }
        [HttpGet("{username}")]
        public async Task<IActionResult> GetAddressByUsername(string username)
        {
            var address = await _serviceManager.AddressService.GetAddressesByUsername(username);
            if(address == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No addresses found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = address,
                Message = "Address retrieved successfully."
            });
        }
        [HttpPost("{userId}")]
        public async Task<IActionResult> Create(Guid userId, [FromBody] CreateAddressRequest addAddress)
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
            var result = await _serviceManager.AddressService.AddAddress(userId, addAddress);
            if (result == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to add address."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Address added successfully."
            });
        }
        [HttpPut("{userId}/{addressId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid userId, Guid addressId, [FromBody]UpdateAddressRequest updateAddress)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Invalid data."
                });
            }
            var result = await _serviceManager.AddressService.UpdateAddress(userId, addressId, updateAddress);
            if(!result)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to update address."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Address updated successfully."
            });
        }
        [HttpDelete("{userId}/{addressId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid userId, Guid addressId)
        {
            var address = await _serviceManager.AddressService.GetAddressByUserIdAndAddressId(userId, addressId);
            if(address == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Address not found."
                });
            }
            await _serviceManager.AddressService.DeleteAddress(userId, addressId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Address deleted successfully."
            });
        }
        [HttpPatch("{userId}/{addressId}/set-default")]
        public async Task<ActionResult<ResultModel>> SetAsDefault(Guid userId, Guid addressId)
        {
            var result = await _serviceManager.AddressService.SetDefaultAddress(userId, addressId);
            if(!result)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Address not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Set default address successfully."
            });
        }
    }
}
