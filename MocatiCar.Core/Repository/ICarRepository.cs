using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface ICarRepository : IRepositoryBase<Car, Guid>
    {
        Task<(IEnumerable<Car> Cars, int TotalItems)> GetAllCarAsync(int page, int limit, string search , bool? status);
        Task<Car> GetCarByCarId(Guid id);
        Task<Car> GetCarBySlug(string slug);
        void UpdateCar(Guid id, Car car);
        Task<int> GetTotalCarAsync();
        Task<Car> GetByLicensePlateAsync(string licensePlate);
        Task<IEnumerable<Car>> GetCarByUserAsync(Guid id);
    }
}
