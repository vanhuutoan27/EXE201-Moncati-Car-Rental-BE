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
    }
}
