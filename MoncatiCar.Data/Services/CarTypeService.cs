using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
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

        public async Task<CreateUpdateCarTypeRequest> AddCarTypeAsync(CreateUpdateCarTypeRequest carRequest)
        {
            var model = new CarType()
            {
                CreatedAt = DateTime.Now,
                CreatedBy = carRequest.CreatedBy,
                Description = carRequest.Description,
                TypeName = carRequest.TypeName,
                UpdatedAt = DateTime.Now,
                UpdatedBy = carRequest.UpdatedBy,
            };
            _repositoryManager.CarTypeRepository.Add(model);
            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateUpdateCarTypeRequest>(model);
            return result;
        }

        public async Task<bool> DeleteCarTypeAsync(Guid id)
        {
            var cartype = await _repositoryManager.CarTypeRepository.GetCarTypeByIdAsync(id);

            if (cartype == null)
            {
                return false;
            }

            // Kiểm tra xem có các bản ghi liên quan trong bảng Reviews không
            var relatedReviews = await _repositoryManager.ReviewRepository.GetReviewsByCarTypeIdAsync(id);
            if (relatedReviews.Any())
            {
               
                _repositoryManager.ReviewRepository.RemoveRange(relatedReviews);
            }

            _repositoryManager.CarTypeRepository.Remove(cartype);
            await _repositoryManager.SaveAsync();

            return true;
        }


        public async Task<PageResult<CarTypeResponse>> GetAllCarTypeAsync(int page, int limit)
        {
            var carTypes = await _repositoryManager.CarTypeRepository.GetAllCarTypeAsync(page, limit);
            var listResults = _mapper.Map<IEnumerable<CarTypeResponse>>(carTypes);
            var totalItems = carTypes.Count();
            if (carTypes == null)
            {
                throw new Exception("Car type list not found.");
            }
            return new PageResult<CarTypeResponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = listResults
            };
        }

        public async Task<CarTypeResponse> GetCarTypeById(Guid id)
        {
            var cartype = await _repositoryManager.CarTypeRepository.GetCarTypeByIdAsync(id);
            if (cartype == null)
            {
                throw new Exception("CarType does not found!");
            }
            return _mapper.Map<CarTypeResponse>(cartype);
        }

        public async Task<bool> UpdateCarType(Guid id, CreateUpdateCarTypeRequest cartype)
        {
            var existingCarType = await _repositoryManager.CarTypeRepository.GetCarTypeByIdAsync(id);

            if (existingCarType == null)
            {
                return false;
            }

            // Update the fields
            existingCarType.UpdatedBy = cartype.UpdatedBy;
            existingCarType.UpdatedAt = DateTime.UtcNow;
            existingCarType.CreatedBy = cartype.CreatedBy;
            existingCarType.CreatedAt = DateTime.UtcNow;
            existingCarType.Description = cartype.Description;
            existingCarType.TypeName = cartype.TypeName;

            // Call the update method in the repository
            _repositoryManager.CarTypeRepository.Update(existingCarType);

            // Save changes asynchronously
            await _repositoryManager.SaveAsync();

            return true;
        }


    }
}
