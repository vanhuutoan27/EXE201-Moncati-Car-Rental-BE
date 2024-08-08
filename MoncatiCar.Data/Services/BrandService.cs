using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class BrandService : IBrandService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public BrandService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
        public async Task<CreateUpdateBrandRequest> AddBrand(CreateUpdateBrandRequest brandRequest)
        {
            var createBrand = _mapper.Map<Brand>(brandRequest);

            // check brandName exist
            if(await _repositoryManager.BrandRepository.CheckBrandName(brandRequest.BrandName))
            {
                throw new Exception("BrandName already existed.");
            }
            var model = new Brand()
            {
                BrandId = Guid.NewGuid(),
                BrandName = createBrand.BrandName,
                Description = createBrand.Description,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _repositoryManager.BrandRepository.Add(model);

            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateUpdateBrandRequest>(model);
            return result;
        }

        public async Task<bool> DeleteBrand(Guid id)
        {
            var brand = await _repositoryManager.BrandRepository.GetByIdAsync(id);
            if (brand == null)
            {
                return false;
            }
            _repositoryManager.BrandRepository.Remove(brand);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<Brand>> GetAllBrands(int page, int limit)
        {
            var listBrand = await _repositoryManager.BrandRepository.GetAllBrandAsync(page, limit);
            var totalItems = await _repositoryManager.BrandRepository.GetTotalBrandCountAsync();

            return new PageResult<Brand>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = listBrand
            };
        }

        public async Task<BrandRespone> GetBrandById(Guid id)
        {
            var brand = await _repositoryManager.BrandRepository.GetByIdAsync(id);
            return _mapper.Map<BrandRespone>(brand);
        }

        public async Task<bool> UpdateBrand(Guid id, CreateUpdateBrandRequest brandRequest)
        {
            var updateBrand = await _repositoryManager.BrandRepository.GetBrandById(id);
            if (updateBrand == null)
            {
                return false;
            }

            // check brandName exist
            if (await _repositoryManager.BrandRepository.CheckBrandName(brandRequest.BrandName))
            {
                throw new Exception("BrandName already existed.");
            }

            updateBrand.BrandName = brandRequest.BrandName;
            updateBrand.Description = brandRequest.Description;
            updateBrand.UpdatedAt = DateTime.Now;

            _repositoryManager.BrandRepository.UpdateBrand(id, updateBrand);
            await _repositoryManager.SaveAsync();
            return true;
        }
    }
}
