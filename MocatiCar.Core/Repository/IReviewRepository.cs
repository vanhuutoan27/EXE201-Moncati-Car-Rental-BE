using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IReviewRepository : IRepositoryBase<Review, Guid>
    {
        Task<IEnumerable<Review>> GetAllReviewAsync(int page, int limit, int star);
        Task<Review> GetReviewId(Guid id);
        void UpdateReview(Guid id, Review review);
        Task<IEnumerable<Review>> GetReviewByCarId(Guid carId);
        Task<IEnumerable<Review>> GetReviewByUserId(Guid userId);
    }
}
