using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;

namespace MocatiCar.Core.Services
{
    public interface ICarService
    {
        Task<CreateUpdateCarRequest> AddCar(CreateUpdateCarRequest carRequest);
        Task<IEnumerable<CarResponse>> GetAllCars(int page, int limit);
        Task<Car> GetCarByCarId(Guid id);
        Task<Car> GetCarBySlug(string slug);
        Task<bool> UpdateCar(Guid id, CreateUpdateCarRequest update);
        Task<bool> DeleteCar(Guid id);
        Task<bool> ChangeStatusAsync(Guid id);
    }
}
