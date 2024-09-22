using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
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

        public Task<Feature> GetFeatureById(Guid id)
        {
            return _context.Features.FirstOrDefaultAsync(f => f.FeatureId == id);
        }

        public async Task<IEnumerable<Feature>> GetFeaturesByCarId(Guid carId)
        {
            return await _context.CarFeatures
                .Where(x => x.CarId == carId)
                .Select(x => x.Feature)
                .ToListAsync();
        }
    }
}
