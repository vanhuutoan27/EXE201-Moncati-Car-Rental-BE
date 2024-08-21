using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            _serviceManager=serviceManager;
            _resultModel= new ResultModel();
        }
        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, int? star = null)
        {
            // Check if star rating is provided and if so, validate it
            if (star.HasValue && (star < 1 || star > 5))
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Rating must be between 1 and 5.",
                    Status = (int)HttpStatusCode.BadRequest
                };
                return BadRequest(_resultModel);
            }

           
            var listreview = await _serviceManager.ReviewService.GetAllReviewAsync(page, limit, star??0);

            // Check if the Items collection is null or empty
            if (listreview == null || !listreview.Items.Any())
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "No reviews found.",
                    Status = (int)HttpStatusCode.NotFound
                };
                return NotFound(_resultModel);
            }

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
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewById(Guid reviewId)
        {
            try
            {
                var reviews = await _serviceManager.ReviewService.GetReviewById(reviewId);

                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = reviews,
                    Message = "Review retrieved successfully."
                };

                return Ok(_resultModel);
            }
            catch (KeyNotFoundException)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Review not found."
                };

                return NotFound(_resultModel);
            }
            catch (Exception ex)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = $"An error occurred: {ex.Message}"
                };

                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
        }
        [HttpGet]
        [Route("car/{carId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewByCarId(Guid carId)
        {
            try
            {
                var reviews = await _serviceManager.ReviewService.GetReviewByCarId(carId);

                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = reviews,
                    Message = "Car reviews retrieved successfully."
                };

                return Ok(_resultModel);
            }
            catch (KeyNotFoundException)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No reviews found for the specified car."
                };

                return NotFound(_resultModel);
            }
            catch (Exception ex)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = $"An error occurred: {ex.Message}"
                };

                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
        }

        [HttpGet]
        [Route("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewByUserId(Guid userId)
        {
            try
            {
                var reviews = await _serviceManager.ReviewService.GetReviewByUserId(userId);

                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = reviews,
                    Message = "User reviews retrieved successfully."
                };

                return Ok(_resultModel);
            }
            catch (KeyNotFoundException)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No reviews found for the specified user."
                };

                return NotFound(_resultModel);
            }
            catch (Exception ex)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = $"An error occurred: {ex.Message}"
                };

                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }
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
                Data = addReview,
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
                Data = updateReview,
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
                Data = updateReview,
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
                    Message = "Change Flag Failed!"
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Change Flag Successfully!"
            };

            return Ok(_resultModel);
        }

    }
}
