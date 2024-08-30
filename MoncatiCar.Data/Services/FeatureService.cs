using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class FeatureService : IFeatureService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public FeatureService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<FeatureResponses> CreateFeaturesAsync(CreateFeatureRequest request)
        {
            if (request == null) throw new Exception("Invalid Feature");
            var feature = new Feature()
            {
                FeatureName = request.FeatureName,
                DisplayName = request.DisplayName,
                Description = request.Description,
                CreatedAt = DateTime.Now,
                Icon = request.Icon
                
            };
            _repositoryManager.FeatureRepository.Add(feature);
            await _repositoryManager.SaveAsync();
            return _mapper.Map<FeatureResponses>(feature);
        }

        public async Task<bool> DeleteFeature(Guid id)
        {
            var query = await _repositoryManager.FeatureRepository.GetFeatureById(id);
            if (query == null) return false;
            _repositoryManager.FeatureRepository.Remove(query);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<FeatureResponses>> GetAllFeatureAsync()
        {
            var features = await _repositoryManager.FeatureRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<FeatureResponses>>(features);
        }

        public async Task<IEnumerable<FeatureResponses>> GetFeatureByCarId(Guid carId)
        {
            var listFeature = await _repositoryManager.FeatureRepository.GetFeaturesByCarId(carId);
            return _mapper.Map<IEnumerable<FeatureResponses>>(listFeature);
        }

        public async Task<FeatureResponses> GetFeatureById(Guid id)
        {
            var featureId = await _repositoryManager.FeatureRepository.GetFeatureById(id);
            if (featureId == null) throw new Exception("Fearture does not exist!");
            return _mapper.Map<FeatureResponses>(featureId);
        }

        public async Task<bool> UpdateFeature(Guid id, CreateFeatureRequest update)
        {
            var query = await _repositoryManager.FeatureRepository.GetFeatureById(id);
            if (query == null) return false;
            query.Description = update.Description;
            query.FeatureName = update.FeatureName;
            query.DisplayName = update.DisplayName;
            _repositoryManager.FeatureRepository.Update(query);
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
