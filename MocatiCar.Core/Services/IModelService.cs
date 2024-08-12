using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IModelService
    {
        Task<CreateUpdateModelRequest> AddModel(CreateUpdateModelRequest addModelRequest);
        Task<bool> UpdateModel(Guid id, CreateUpdateModelRequest updateModelRequest);
        Task<PageResult<ModelRespone>> GetAllModels(int page, int limit, string searchName);
        Task<IEnumerable<ModelRespone>> GetModelByBrandId(Guid id);
        Task<IEnumerable<ModelRespone>> GetModelByBrandName(string brandName);
        Task<ModelRespone> GetModelById(Guid id);
        Task<bool> DeleteBrand(Guid id);
    }
}
