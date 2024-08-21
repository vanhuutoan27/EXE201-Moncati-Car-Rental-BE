using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IFeatureRepository : IRepositoryBase<Feature, Guid>
    {
        Task<Feature> GetFeatureByFeatureNameAsync(string featureName);
        Task<Feature> GetFeatureById(Guid id);
    }
}
