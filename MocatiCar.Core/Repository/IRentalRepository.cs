using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Repository
{
    public interface IRentalRepository : IRepositoryBase<Rental, Guid>
    {
        Task<IEnumerable<Rental>> GetAllRentalAsync(int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate);
        Task<Rental> GetRentalByIdAsync(Guid id);
        Task<IEnumerable<Rental>> GetRentalByCarId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate);
        Task<IEnumerable<Rental>> GetRentalByUserId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate);
        Task<int> CountRecord();
    }
}
