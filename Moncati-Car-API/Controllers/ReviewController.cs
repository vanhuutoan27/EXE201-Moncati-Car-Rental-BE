﻿using Microsoft.AspNetCore.Mvc;
using MocatiCar.Core.Models;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.SeedWorks;
using System.Net;

namespace Moncati_Car_API.Controllers
{
    [Route("api/v1/reviews")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public ReviewController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, bool? flag = null, int? rating = null)
        {
            // Check if rating is provided and if so, validate it
            if (rating.HasValue && (rating < 1 || rating > 5))
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Rating must be between 1 and 5.",
                    Status = (int)HttpStatusCode.BadRequest
                };
                return BadRequest(_resultModel);
            }

            // Call the service to get reviews, handle nullable flag correctly
            var listreview = await _serviceManager.ReviewService.GetAllReviewAsync(page, limit, rating ?? 0, flag);

            // Return the result if reviews are found
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listreview,
                Message = "Reviews retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("user/{username}")]
        public async Task<ActionResult<ResultModel>> GetAllReviewByUsername(string username, int page = 1, int limit = 10, bool? flag = null)
        {
            var result = await _serviceManager.ReviewService.GetAllReviewByUsername(username, page, limit, flag);
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = result,
                Message = "Reviews retrieved successfully."
            };
            return Ok(_resultModel);

        }

        [HttpGet]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewById(Guid reviewId)
        {


            var reviews = await _serviceManager.ReviewService.GetReviewById(reviewId);

            if (reviews == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null,
                    Message = "Id does not exist!."

                };
            }
            else
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = reviews,
                    Message = "Review retrieved successfully."
                };

            return Ok(_resultModel);



        }
        [HttpGet]
        [Route("rental/{rentalId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewByRentalId(Guid rentalId)
        {


            var reviews = await _serviceManager.ReviewService.GetReviewbyrentalId(rentalId);

            if (reviews == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null,
                    Message = "Id does not exist!."

                };
            }
            else
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = reviews,
                    Message = "Review retrieved successfully."
                };

            return Ok(_resultModel);



        }
        [HttpGet]
        [Route("car/{carId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewByCarId(Guid carId, int page = 1, int limit = 10, bool? flag = null)
        {

            var reviews = await _serviceManager.ReviewService.GetReviewByCarId(carId, page, limit, flag);
            if (reviews == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Reviews not found."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = reviews,
                Message = "Review retrieved successfully."
            };

            return Ok(_resultModel);

        }
        [HttpGet]
        [Route("owner/{username}")]
        public async Task<ActionResult<ResultModel>> GetUserandReviewByOwner(string username, int page = 1, int limit = 10)
        {

            var reviews = await _serviceManager.ReviewService.GetUserAndReviewByOwner(username, page, limit);
            if (reviews == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Reviews not found."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = reviews,
                Message = "Review and User retrieved successfully."
            };

            return Ok(_resultModel);

        }


        [HttpGet]
        [Route("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewByUserId(Guid userId, int page = 1, int limit = 10, bool? flag = null)
        {
            var reviews = await _serviceManager.ReviewService.GetReviewByUserId(userId, page, limit, flag);

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = reviews,
                Message = "Review retrieved successfully."
            };


            return Ok(_resultModel);
        }




        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddReview(CreateUpdateReviewRequest createUpdateReviewRequest)
        {
            var addReview = await _serviceManager.ReviewService.AddReview(createUpdateReviewRequest);
            if (addReview == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Unable to add review. Please try again."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "Review added successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> UdpdateReview(Guid reviewId, CreateUpdateReviewRequest createUpdateReviewRequest)
        {
            var updateReview = await _serviceManager.ReviewService.UpdateReview(reviewId, createUpdateReviewRequest);
            if (updateReview == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Review not found."
                };
                return BadRequest(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "Review updated successfully."
            };
            return Ok(_resultModel);
        }
        [HttpDelete]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid reviewId)
        {
            var updateReview = await _serviceManager.ReviewService.DeleteReview(reviewId);
            if (updateReview == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Review not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Review deleted successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPatch]
        [Route("{reviewId}/flag")]
        public async Task<ActionResult<ResultModel>> ChangeFlag(Guid reviewId)
        {
            var flagChanged = await _serviceManager.ReviewService.ChangeFlagAsync(reviewId);

            if (!flagChanged)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to flag review."
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Review flagged successfully."
            };

            return Ok(_resultModel);
        }

    }
}
