using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface IModelService
    {
        Task<CreateUpdateModelRequest> AddModel(CreateUpdateModelRequest addModelRequest);
        Task<bool> UpdateModel(Guid id, CreateUpdateModelRequest updateModelRequest);
        Task<IEnumerable<ModelRespone>> GetAllModels(int page, int limit);
        Task<IEnumerable<ModelRespone>> GetModelByBrandId(Guid id);
        Task<IEnumerable<ModelRespone>> GetModelByBrandName(string brandName);
    }
}
