using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IReviewRepository : IRepositoryBase<Review, Guid>
    {
        Task<IEnumerable<Review>> GetAllReviewAsync(int page, int limit, int star, Boolean? flag);
        Task<Review> GetReviewId(Guid id);
        void UpdateReview(Guid id, Review review);
        Task<IEnumerable<Review>> GetReviewByCarId(Guid carId, int page, int limit, Boolean? flag);
        Task<IEnumerable<Review>> GetReviewByUserId(Guid userId, int page, int limit, Boolean? flag);
        Task<IEnumerable<Review>> GetReviewsByCarTypeIdAsync(Guid carTypeId);
        Task<IEnumerable<Review>> GetAllReviewByUsername(string username, int page, int limit, bool? flag);
        Task<Review> HasReview(Guid author, Guid CarId);

    }
}
