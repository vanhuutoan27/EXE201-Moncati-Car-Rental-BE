using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface ICarTypeRepository : IRepositoryBase<CarType, Guid>
    {
        Task<PaginatedResult<CarType>> GetAllCarTypeAsync(int page, int limit);
        Task<CarType> GetCarTypeByIdAsync(Guid id);

    }
}
