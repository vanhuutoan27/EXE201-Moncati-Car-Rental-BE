using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Services
{
    public interface ICarService
    {
        Task<CreateUpdateCarRequest> AddCar(CreateUpdateCarRequest carRequest);
        Task<PageResult<CarResponse>> GetAllCars(int page, int limit, string search, bool? status);
        Task<CarResponse> GetCarByCarId(Guid id);
        Task<CarResponeIdandSlug> GetCarBySlug(string slug);
        Task<PageResult<CarResponse>> GetAllCarByUser(int page, int limit, bool? status, Guid userId);
        Task<bool> UpdateCar(Guid id, UpdateCarRequest update);
        Task<bool> DeleteCar(Guid id);
        Task<bool> ChangeStatusAsync(Guid id);
        Task<bool> ChangeRentalStatusAsync(Guid id, CarRentalStatus status);
        Task<bool> UpdateCarByCustomer(Guid id, UpdateCarByCustomer update);


    }
}
