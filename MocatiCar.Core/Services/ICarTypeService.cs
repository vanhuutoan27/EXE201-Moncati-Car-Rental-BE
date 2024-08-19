using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface ICarTypeService
    {
        Task<PageResult<CarTypeResponse>> GetAllCarTypeAsync(int page , int limit);
        Task<CarTypeResponse> GetCarTypeById(Guid id);
        Task<CreateUpdateCarTypeRequest> AddCarTypeAsync(CreateUpdateCarTypeRequest carRequest);
        Task<bool> UpdateCarType(Guid id, CreateUpdateCarTypeRequest cartype);
        Task<bool> DeleteCarTypeAsync(Guid id);
    }
}
