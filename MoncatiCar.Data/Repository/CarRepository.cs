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

        public async Task<IEnumerable<Car>> GetAllCarAsync(int page, int limit)
        {
            IQueryable<Car> query = _context.Cars.Include(m => m.Model).ThenInclude(b => b.Brand)
                            .Include(i => i.Images);
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();
        }

        public async Task<Car> GetCarByCarId(Guid id)
        {
            var query = await _context.Cars.Where(m => m.CarId == id).
                                            Include(m => m.Images).FirstOrDefaultAsync();
            return query;
        }

        public async Task<Car> GetCarBySlug(string slug)
        {
            var query = await _context.Cars.Where(c => c.Slug == slug)
                                           .Include(c => c.Images).FirstOrDefaultAsync();
            return query;
        }

        public void UpdateCar(Guid id, Car car)
        {
            _context.Cars.Update(car);
        }
    }
}
