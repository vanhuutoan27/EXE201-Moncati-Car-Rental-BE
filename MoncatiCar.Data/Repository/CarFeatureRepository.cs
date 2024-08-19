using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class CarFeatureRepository : RepositoryBase<CarFeature, Guid>, ICarFeatureRepository
    {
        public CarFeatureRepository(MocatiContext context) : base(context)
        {

        }

        public async Task<IEnumerable<CarFeature>> GetALLCarFeatureByCarId(Guid CarId)
        {
            return await _context.CarFeatures.Where(cf => cf.CarId == CarId).ToListAsync();
        }
    }
}
