using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class ReviewRepository : RepositoryBase<Review, Guid>, IReviewRepository
    {
        public ReviewRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<int> CountAsync(Guid carId)
        {
            return await _context.Reviews.CountAsync(c => c.CarId == carId);
        }

        public async Task<IEnumerable<Review>> GetAllReviewAsync(int page, int limit, int star, Boolean? flag)
        {
            IQueryable<Review> query = _context.Reviews.Include(a => a.User)
                                                       .Include(c => c.Car)
                                                       .Include(r => r.Rental);

            // Apply flag filter only if flag has a value
            if (flag.HasValue)
            {
                query = query.Where(p => p.Flag == flag.Value);
            }

            // Apply star filter if star > 0
            if (star > 0)
            {
                query = query.Where(r => r.Rating == star);
            }

            // Pagination
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<Review>> GetAllReviewByUsername(string username, int page, int limit, bool? flag)
        {
            IQueryable<Review> query = _context.Reviews.AsQueryable();
            query = query.Where(r => r.User.UserName == username);
            if (flag.HasValue)
            {
                query = query.Where(r => r.Flag == flag);
            }
            if (page > 0 && limit > 0) { query = query.Skip((page - 1) * limit).Take(limit); }
            return await query.ToListAsync();
        }
        public async Task<double> GetAverageRatingByCarId(Guid carId)
        {
            var reviews = await _context.Reviews.Where(c => c.CarId == carId).ToListAsync();

            // Nếu không có review nào, trả về 0
            if (!reviews.Any())
            {
                return 0.0;
            }

            // Tính trung bình rating
            return reviews.Average(r => r.Rating);
        }

        public async Task<IEnumerable<Review>> GetReviewByCarId(Guid carId, int page, int limit, bool? flag)
        {
            IQueryable<Review> query = _context.Reviews.AsQueryable()
            ; if (flag.HasValue)
            {
                query = query.Where(f => f.Flag == flag.Value);
            }

            if (page > 0 && limit > 0)
            {
                query = query.Where(c => c.CarId == carId).Skip((page - 1) * limit).Take(limit);
            }



            return await query.ToListAsync();
        }

        public async Task<Review> GetReviewByRentalId(Guid rentalId)
        {
           var rental = await _context.Reviews.Where(r => r.RentalId == rentalId).FirstOrDefaultAsync();
           return rental;
        }

        public async Task<IEnumerable<Review>> GetReviewByUserId(Guid userId, int page, int limit, Boolean? flag)
        {
            IQueryable<Review> query = _context.Reviews.AsQueryable();

            if (flag.HasValue)
            {
                query = query.Where(f => f.Flag == flag.Value);
            }
            if (page > 0 && limit > 0)
            {
                query = query.Where(u => u.Author == userId).Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();
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

        public async Task<IEnumerable<Review>> GetUserByOwnerName(string ownerName, int page, int limit)
        {
            IQueryable<Review> query = _context.Reviews.Include(u => u.User).AsQueryable();
            if (page > 0 && limit > 0)
            {
                query = query.Where(rv => rv.Car.User.UserName == ownerName).Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();
        }

        public async Task<Review> HasReview(Guid author, Guid carId)
        {
            return await _context.Reviews.FirstOrDefaultAsync(r => r.RentalId == carId && r.Author == author);
        }

        public void UpdateReview(Guid id, Review review)
        {
            _context.Reviews.Update(review);
        }
    }
}
