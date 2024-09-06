using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class CarRepository : RepositoryBase<Car, Guid>, ICarRepository
    {
        public CarRepository(MocatiContext context) : base(context)
        {

        }

        public async Task<(IEnumerable<Car> Cars, int TotalItems)> GetAllCarAsync(int page, int limit, string search, bool? status)
        {
            search = search?.Trim();
            IQueryable<Car> query = _context.Cars
                                            .Include(m => m.Model)
                                                .ThenInclude(b => b.Brand)
                                            .Include(i => i.Images)
                                            .Include(r => r.Reviews)
                                            .Include(c => c.CarFeatures)
                                                .ThenInclude(cf => cf.Feature);

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(c => c.Slug.ToLower().Contains(search.ToLower()));
            }
            if (status.HasValue)
            {
                query = query.Where(c => c.Status == status.Value);
            }
            // Get the total count of items before applying pagination
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var cars = await query.ToListAsync();
            return (cars, totalItems);
        }

        public async Task<IEnumerable<Car>> GetCarByUserAsync(Guid id)
        {
            var cars = await _context.Cars
                .Where(c => c.OwnerId == id)
                .Include(c => c.Model)
                    .ThenInclude(m => m.Brand)
                .Include(c => c.Images)
                .Include(c => c.CarFeatures)
                    .ThenInclude(cf => cf.Feature)
                .Include(c => c.Reviews)
                .ToListAsync();

            return cars;
        }


        public async Task<Car> GetByLicensePlateAsync(string licensePlate)
        {
            var check = await _context.Cars.FirstOrDefaultAsync(c => c.licensePlate == licensePlate);
            return check;
        }

        public async Task<Car> GetCarByCarId(Guid id)
        {
            var query = await _context.Cars.Where(m => m.CarId == id)
                                           .Include(m => m.Model)
                                             .ThenInclude(b => b.Brand)
                                             .Include(i => i.Images)
                                             .Include(c => c.CarFeatures).ThenInclude(cf => cf.Feature)
                                             .Include(review => review.Reviews).FirstOrDefaultAsync();
            return query;
        }

        public async Task<Car> GetCarBySlug(string slug)
        {
            var query = await _context.Cars.Where(c => c.Slug == slug)
                                            .Include(m => m.Model)
                                            .ThenInclude(b => b.Brand)
                                            .Include(c => c.CarFeatures).ThenInclude(cf => cf.Feature)
                                           .Include(c => c.Images).FirstOrDefaultAsync();
            return query;
        }

        public async Task<int> GetTotalCarAsync()
        {
            return await _context.Cars.CountAsync();
        }

        public void UpdateCar(Guid id, Car car)
        {
            _context.Cars.Update(car);
        }
    }
}
