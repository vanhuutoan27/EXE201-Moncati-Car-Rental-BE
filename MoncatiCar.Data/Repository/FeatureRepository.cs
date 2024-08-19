using Microsoft.EntityFrameworkCore;
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

        public async Task<Feature> GetFeatureByFeatureNameAsync(string featureName)
        {
            return await _context.Features.FirstOrDefaultAsync(f => f.FeatureName.ToLower() == featureName.ToLower());
        }
    }
}
