using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class FeatureRepository : RepositoryBase<Feature, Guid>, IFeatureRepository
    {
        public FeatureRepository(MocatiContext context) : base(context)
        {
        }
    }
}
