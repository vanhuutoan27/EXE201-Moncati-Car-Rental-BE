using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IFeatureService
    {
        Task<FeatureResponses> CreateFeaturesAsync(CreateFeatureRequest request);
    }
}
