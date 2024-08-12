using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewRespone>> GetAllReviewAsync(int page, int limit);
        Task<CreateUpdateReviewRequest> AddReview(CreateUpdateReviewRequest carRequest);

        Task<ReviewRespone> GetReviewById(Guid id);
        Task<bool> UpdateReview(Guid id, CreateUpdateReviewRequest update);
        Task<bool> DeleteReview(Guid id);
    }
}
