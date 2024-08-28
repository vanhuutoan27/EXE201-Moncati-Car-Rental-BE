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

        public async Task<IEnumerable<Car>> GetAllCarAsync(int page, int limit, string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                IQueryable<Car> query = _context.Cars.AsQueryable();
                if (page > 0 && limit > 0)
                {
                    query = query.Skip((page - 1) * limit).Take(limit);
                }
                else
                {
                    query = _context.Cars;
                }

                return await query.Include(m => m.Model)
                                             .ThenInclude(b => b.Brand)
                                             .Include(i => i.Images)
                                             .Include(c => c.CarFeatures).ThenInclude(cf => cf.Feature)
                                             .Include(review => review.Reviews).ToListAsync();
            }
            else
            {
                return await _context.Cars.Where(c => c.Slug.ToLower().Contains(search.ToLower()))
                    .Include(m => m.Model).ThenInclude(b => b.Brand)
                    .Include(i => i.Images)
                    .Include(r => r.Reviews)
                    .Include(c => c.CarFeatures).ThenInclude(cf => cf.Feature)
                    .Skip((page - 1) * limit).Take(limit).ToListAsync();
            }

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
                                            .Include(m =>m.Model)
                                            .ThenInclude(b => b.Brand)
                                            .Include(c =>c.CarFeatures).ThenInclude(cf => cf.Feature)
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
