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

        public async Task<IEnumerable<Review>> GetAllReviewAsync(int page, int limit)
        {
            IQueryable<Review> query = _context.Reviews.Include(a => a.User)
                                                       .Include(c => c.Car);
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();
        }

        public async Task<Review> GetReviewId(Guid id)
        {
            var query = await _context.Reviews.FirstOrDefaultAsync(r => r.ReviewId == id);
            return query;
        }

        public void UpdateReview(Guid id, Review review)
        {
           _context.Reviews.Update(review);    
        }
    }
}
