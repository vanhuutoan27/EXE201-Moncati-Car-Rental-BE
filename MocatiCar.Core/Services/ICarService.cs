using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Services
{
    public interface ICarService
    {
        Task<CreateUpdateCarRequest> AddCar(CreateUpdateCarRequest carRequest);
        Task<PageResult<CarResponse>> GetAllCars(int page, int limit, string search);
        Task<CarResponse> GetCarByCarId(Guid id);
        Task<CarResponeIdandSlug> GetCarBySlug(string slug);
        Task<bool> UpdateCar(Guid id, CreateUpdateCarRequest update);
        Task<bool> DeleteCar(Guid id);
        Task<bool> ChangeStatusAsync(Guid id);
        Task<bool> ChangeRentalStatusAsync(Guid id, CarRentalStatus status);
        
    }
}
