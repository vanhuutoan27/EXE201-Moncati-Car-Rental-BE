using AutoMapper;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class CarTypeService : ICarTypeService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CarTypeService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CarTypeResponse>> GetAllCarTypeAsync()
        {
            var carTypes = await _repositoryManager.CarTypeRepository.GetAllAsync();
            if (carTypes == null)
            {
                throw new Exception("Car type list not found.");
            }
            return _mapper.Map<IEnumerable<CarTypeResponse>>(carTypes);
        }
    }
}
