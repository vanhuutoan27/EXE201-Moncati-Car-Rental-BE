using AutoMapper;
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
    }
}
