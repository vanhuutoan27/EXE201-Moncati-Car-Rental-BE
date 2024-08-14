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
                Name = request.Name,
                Description = request.Description,
                CreatedAt = DateTime.Now
            };
            _repositoryManager.FeatureRepository.Add(feature);
            await _repositoryManager.SaveAsync();
            return _mapper.Map<FeatureResponses>(feature);
        }

        public async Task<IEnumerable<FeatureResponses>> GetAllFeatureAsync()
        {
            var features = await _repositoryManager.FeatureRepository.GetAllAsync();
            return _mapper.Map<IEnumerable<FeatureResponses>>(features);
        }
    }
}
