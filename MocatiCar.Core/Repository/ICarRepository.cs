using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface ICarRepository : IRepositoryBase<Car, Guid>
    {
        Task<IEnumerable<Car>> GetAllCarAsync(int page, int limit, string search);
        Task<Car> GetCarByCarId(Guid id);
        Task<Car> GetCarBySlug(string slug);
        void UpdateCar(Guid id, Car car);
        Task<int> GetTotalCarAsync();
    }
}
