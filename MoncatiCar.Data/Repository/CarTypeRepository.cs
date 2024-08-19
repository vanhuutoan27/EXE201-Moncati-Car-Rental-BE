using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class CarTypeRepository : RepositoryBase<CarType, Guid>, ICarTypeRepository
    {
        public CarTypeRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<IEnumerable<CarType>> GetAllCarTypeAsync(int page, int limit)
        {
           IQueryable<CarType> query = _context.CarTypes.AsQueryable(); 
           if(page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            query=_context.CarTypes;
            return await query.ToListAsync();
        }

        public async Task<CarType> GetCarTypeByIdAsync(Guid id)
        {
            return await _context.CarTypes.FirstOrDefaultAsync(ct => ct.CarTypeId == id);
        }

       
    }
}
