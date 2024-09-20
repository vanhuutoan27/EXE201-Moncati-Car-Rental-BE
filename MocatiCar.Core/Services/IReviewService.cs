using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IReviewService
    {
        Task<PageResult<ReviewRespone>> GetAllReviewAsync(int page, int limit, int star, bool? flag);
        Task<CreateUpdateReviewRequest> AddReview(CreateUpdateReviewRequest carRequest);

        Task<ReviewRespone> GetReviewById(Guid id);
        Task<bool> UpdateReview(Guid id, CreateUpdateReviewRequest update);
        Task<bool> DeleteReview(Guid id);
        Task<PageResult<ReviewRespone>> GetReviewByCarId(Guid carId, int page, int limit, Boolean? flag);
        Task<PageResult<ReviewRespone>> GetReviewByUserId(Guid userId, int page, int limit, Boolean? flag);
        Task<bool> ChangeFlagAsync(Guid id);
        Task<PageResult<GetReviewandUserbyOwnerRespone>> GetUserAndReviewByOwner(string ownerName, int page, int limit);
    }
}
