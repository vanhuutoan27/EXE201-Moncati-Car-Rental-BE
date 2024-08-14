using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;

namespace MoncatiCar.Data.Services
{
    public class ModelService : IModelService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ModelService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CreateUpdateModelRequest> AddModel(CreateUpdateModelRequest addModelRequest)
        {
            var brand = await _repositoryManager.BrandRepository.GetByIdAsync(addModelRequest.BrandId);
            if (brand == null)
            {
                throw new Exception($"Brand with ID '{addModelRequest.BrandId}' does not exist.");
            }

            // check ModelName exist
            if (await _repositoryManager.ModelRepository.CheckModelNameExist(addModelRequest.ModelName))
            {
                throw new Exception($"Model name '{addModelRequest.ModelName}' already exists.");
            }

            var createModel = _mapper.Map<Model>(addModelRequest);
            var model = new Model()
            {
                ModelId = Guid.NewGuid(),
                ModelName = createModel.ModelName,
                Year = createModel.Year,
                Description = createModel.Description,
                BrandId = createModel.BrandId,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            _repositoryManager.ModelRepository.Add(model);

            await _repositoryManager.SaveAsync();
            var result = _mapper.Map<CreateUpdateModelRequest>(model);
            return result;
        }

        public async Task<bool> DeleteBrand(Guid id)
        {
            var model = await _repositoryManager.ModelRepository.GetByIdAsync(id);
            if (model == null)
            {
                throw new Exception($"Model with ID '{id}' does not exist.");
            }
            _repositoryManager.ModelRepository.Remove(model);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<ModelRespone>> GetAllModels(int page, int limit, string searchName)
        {
            var listModel = await _repositoryManager.ModelRepository.GetAllModelAsync(page, limit, searchName);
            var listResult = _mapper.Map<IEnumerable<ModelRespone>>(listModel);
            var totalItems = await _repositoryManager.ModelRepository.GetTotalModelCountAsync(searchName);

            var resultJson = new List<ModelRespone>();
            foreach (var item in listResult)
            {
                resultJson.Add(new ModelRespone
                {
                    ModelId = item.ModelId,
                    ModelName = item.ModelName,
                    Description = item.Description,
                    Year = item.Year,
                    Brand = new BrandResponeGetAll
                    {
                        BrandId = item.Brand.BrandId,
                        BrandName = item.Brand.BrandName
                    },
                    CreatedAt = item.CreatedAt,
                    UpdatedAt = item.UpdatedAt,
                    CreatedBy = item.CreatedBy,
                    UpdatedBy = item.UpdatedBy
                });
            }

            return new PageResult<ModelRespone>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = resultJson
            };
        }                

    public async Task<IEnumerable<ModelRespone>> GetModelByBrandId(Guid id)
    {
        var models = await _repositoryManager.ModelRepository.GetModelByBrandId(id);
        if (models == null || !models.Any())
        {
            throw new Exception($"No models found for brand with ID '{id}'.");
        }
        return _mapper.Map<IEnumerable<ModelRespone>>(models);
    }

    public async Task<IEnumerable<ModelRespone>> GetModelByBrandName(string brandName)
    {
        var models = await _repositoryManager.ModelRepository.GetModelByBrandName(brandName);
        if (models == null || !models.Any())
        {
            throw new Exception($"No models found for brand with name '{brandName}'.");
        }
        return _mapper.Map<IEnumerable<ModelRespone>>(models);
    }

    public async Task<ModelRespone> GetModelById(Guid id)
    {
        var model = await _repositoryManager.ModelRepository.GetByIdAsync(id);
        if (model == null)
        {
            throw new Exception($"Model with ID '{id}' does not exist.");
        }
        return _mapper.Map<ModelRespone>(model);
    }

    public async Task<bool> UpdateModel(Guid id, CreateUpdateModelRequest updateModelRequest)
    {
        var updateModel = await _repositoryManager.ModelRepository.GetByIdAsync(id);
        if (updateModel == null)
        {
            throw new Exception($"Model with ID '{id}' does not exist.");
        }

        // check ModelName exist
        if (await _repositoryManager.ModelRepository.CheckModelNameExist(updateModelRequest.ModelName))
        {
            throw new Exception($"Model name '{updateModelRequest.ModelName}' already exists.");
        }

        // check brandId
        var brand = await _repositoryManager.BrandRepository.GetByIdAsync(updateModelRequest.BrandId);
        if (brand == null || !updateModelRequest.BrandId.Equals(brand.BrandId))
        {
            throw new Exception($"Brand with ID '{updateModelRequest.BrandId}' does not exist.");
        }

        updateModel.ModelName = updateModelRequest.ModelName;
        updateModel.Year = updateModelRequest.Year;
        updateModel.Description = updateModelRequest.Description;
        updateModel.UpdatedAt = DateTime.Now;
        updateModel.BrandId = updateModelRequest.BrandId;

        _repositoryManager.ModelRepository.UpdateModel(id, updateModel);
        await _repositoryManager.SaveAsync();
        return true;
    }
}
}
