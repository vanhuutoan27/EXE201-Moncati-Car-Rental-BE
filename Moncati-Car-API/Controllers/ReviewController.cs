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
        public async Task<ActionResult<ResultModel>> GetAll(int page, int limit)
        {
            var listreview = await _serviceManager.ReviewService.GetAllReviewAsync(page, limit);
            if (listreview == null)
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
                Data = listreview,
                Message = "Get All Review Successfully"
            };
            return Ok(_resultModel);
        }
        [HttpGet]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewById(Guid reviewId)
        {
            var revieId = await _serviceManager.ReviewService.GetReviewById(reviewId);
            if (revieId == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "Review does not exist!!!",
                    Status = (int)HttpStatusCode.NotFound
                };

            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = revieId,
                Message = "Get Review by Id Successfully"
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
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Review does not exsit!"

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = addReview,
                Message = "Add Review Successfully!"
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> UdpdateReview(Guid reviewId ,CreateUpdateReviewRequest createUpdateReviewRequest)
        {
            var updateReview = await _serviceManager.ReviewService.UpdateReview(reviewId, createUpdateReviewRequest);
            if (updateReview == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Review does not exsit!"

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = updateReview,
                Message = "Update Review Successfully!"
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
                    Message = "Review does not exsit!"

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Data = updateReview,
                Message = "Delete Review Successfully!"
            };
            return Ok(_resultModel);
        }
    }
}
