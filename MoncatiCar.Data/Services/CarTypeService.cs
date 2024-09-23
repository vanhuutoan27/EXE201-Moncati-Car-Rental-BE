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

                Description = carRequest.Description,
                TypeName = carRequest.TypeName,

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
            var paginatedCarType = await _repositoryManager.CarTypeRepository.GetAllCarTypeAsync(page, limit);

            var listResults = paginatedCarType.Items.Select(cartype => new CarTypeResponse
            {

                CarTypeId = cartype.CarTypeId,
                CreatedAt = cartype.CreatedAt,
                UpdatedAt = cartype.UpdatedAt,
                Description = cartype.Description,
                TypeName = cartype.TypeName,
                CreatedBy = cartype.CreatedBy,
                UpdatedBy = cartype.UpdatedBy,

            });

            return new PageResult<CarTypeResponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(paginatedCarType.TotalCount / (double)limit),
                TotalItems = paginatedCarType.TotalCount,
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
            return new CarTypeResponse
            {
                CarTypeId = cartype.CarTypeId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Description = cartype.Description,
                TypeName = cartype.TypeName,
                CreatedBy = cartype.CreatedBy,
                UpdatedBy = cartype.UpdatedBy
            };
        }

        public async Task<bool> UpdateCarType(Guid id, CreateUpdateCarTypeRequest cartype)
        {
            var existingCarType = await _repositoryManager.CarTypeRepository.GetCarTypeByIdAsync(id);

            if (existingCarType == null)
            {
                return false;
            }

            // Update the fields

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
