using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IReviewService
    {
        Task<PageResult<ReviewRespone>> GetAllReviewAsync(int page, int limit, int star);
        Task<CreateUpdateReviewRequest> AddReview(CreateUpdateReviewRequest carRequest);

        Task<ReviewRespone> GetReviewById(Guid id);
        Task<bool> UpdateReview(Guid id, CreateUpdateReviewRequest update);
        Task<bool> DeleteReview(Guid id);
        Task<PageResult<ReviewRespone>> GetReviewByCarId(Guid carId, int page, int limit);
        Task<PageResult<ReviewRespone>> GetReviewByUserId(Guid userId, int page, int limit);
        Task<bool> ChangeFlagAsync(Guid id);
    }
}
