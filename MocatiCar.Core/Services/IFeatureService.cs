using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IFeatureService
    {
        Task<FeatureResponses> CreateFeaturesAsync(CreateFeatureRequest request);
        Task<IEnumerable<FeatureResponses>> GetAllFeatureAsync();
        Task<bool> UpdateFeature(Guid id, CreateFeatureRequest update);
        Task<FeatureResponses> GetFeatureById(Guid id);
        Task<bool> DeleteFeature(Guid id);
    }
}
