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
            var brandId = await _repositoryManager.BrandRepository.GetByIdAsync(addModelRequest.BrandId);
            if (brandId == null)
            {
                throw new Exception("BrandId isn't exist");
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
                return false;
            }
            _repositoryManager.ModelRepository.Remove(model);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<ModelRespone>> GetAllModels(int page, int limit)
        {
            var listModel = await _repositoryManager.ModelRepository.GetAllModelAsync(page, limit);
            var listModelRespone = _mapper.Map<IEnumerable<ModelRespone>>(listModel);
            return listModelRespone;
        }

        public async Task<IEnumerable<ModelRespone>> GetModelByBrandId(Guid id)
        {
            var model = await _repositoryManager.ModelRepository.GetModelByBrandId(id);
            return _mapper.Map<IEnumerable<ModelRespone>>(model);
        }

        public async Task<IEnumerable<ModelRespone>> GetModelByBrandName(string brandName)
        {
            var model = await _repositoryManager.ModelRepository.GetModelByBrandName(brandName);
            return _mapper.Map<IEnumerable<ModelRespone>>(model);
        }

        public async Task<ModelRespone> GetModelById(Guid id)
        {
            var model = await _repositoryManager.ModelRepository.GetByIdAsync(id);
            return _mapper.Map<ModelRespone>(model);
        }

        public async Task<bool> UpdateModel(Guid id, CreateUpdateModelRequest updateModelRequest)
        {
            var updateModel = await _repositoryManager.ModelRepository.GetByIdAsync(id);
            if(updateModel == null)
            {
                throw new Exception("Model isn't exist");
            }

            //check brandId
            var checkBrandId = await _repositoryManager.BrandRepository.GetByIdAsync(updateModelRequest.BrandId);
            if (checkBrandId == null || !updateModelRequest.BrandId.Equals(checkBrandId.BrandId))
            {
                throw new Exception("Brand isn't exist");
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
