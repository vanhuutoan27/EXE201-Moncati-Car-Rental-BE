using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface ICarRepository : IRepositoryBase<Car, Guid>
    {
        Task<(IEnumerable<Car> Cars, int TotalItems)> GetAllCarAsync(int page, int limit,
        string search, bool? status,
        string modelname, string brandname,
        string transmission, string fuel, int? seats,
        bool? electric, bool? discount, bool? instantBooking,
        string location, string sortedBy, string? order ,int? minYear, int? maxYear , 
        int? minPrice ,int? maxPrice);
        Task<Car> GetCarByCarId(Guid id);
        Task<Car> GetCarBySlug(string slug);
        void UpdateCar(Guid id, Car car);
        Task<int> GetTotalCarAsync();
        Task<Car> GetByLicensePlateAsync(string licensePlate);
        Task<(IEnumerable<Car> Cars, int TotalItems)> GetCarByUserAsync(int page, int limit, bool? status, Guid id);
        Task<Car> GetLocationDetailByCarId(Guid carId);
        Task<IEnumerable<Car>> GetAllCarByUsername(string userName);
    }
}
