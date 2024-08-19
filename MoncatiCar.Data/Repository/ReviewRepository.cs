using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MoncatiCar.Data.Repository
{
    public class ReviewRepository : RepositoryBase<Review, Guid>, IReviewRepository
    {
        public ReviewRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Review>> GetAllReviewAsync(int page, int limit, int star)
        {
            IQueryable<Review> query = _context.Reviews.Include(a => a.User)
                                                       .Include(c => c.Car);
            if (star > 0)
            {
                query = query.Where(r => r.Rating == star);
            }
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetReviewByCarId(Guid carId)
        {
            var query = await _context.Reviews.Where(c => c.CarId == carId).ToListAsync();
            return query;
        }

        public async Task<IEnumerable<Review>> GetReviewByUserId(Guid userId)
        {
            var query = await _context.Reviews.Where(u => u.Author == userId).ToListAsync();
            return query;
        }

        public async Task<Review> GetReviewId(Guid id)
        {
            var query = await _context.Reviews.FirstOrDefaultAsync(r => r.ReviewId == id);
            return query;
        }

        public async Task<IEnumerable<Review>> GetReviewsByCarTypeIdAsync(Guid carTypeId)
        {
            return await _context.Reviews
         .Where(r => r.Car.CarTypeId == carTypeId)
         .ToListAsync();
        }

        public void UpdateReview(Guid id, Review review)
        {
            _context.Reviews.Update(review);
        }
    }
}
