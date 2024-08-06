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

        public async Task<IEnumerable<BrandRespone>> GetAllBrands(int page, int limit)
        {
            var listBrand = await _repositoryManager.BrandRepository.GetAllBrandAsync(page, limit);

            var listBrandRespone = _mapper.Map<IEnumerable<BrandRespone>>(listBrand);

            return listBrandRespone;
        }

        public async Task<bool> UpdateBrand(Guid id, CreateUpdateBrandRequest brandRequest)
        {
            var updateBrand = await _repositoryManager.BrandRepository.GetBrandById(id);
            if (updateBrand == null)
            {
                return false;
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
