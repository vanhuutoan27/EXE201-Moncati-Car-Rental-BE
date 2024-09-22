using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface ICitizendIdRepository : IRepositoryBase<CitizenId, Guid>
    {
        Task<IEnumerable<CitizenId>> GetAllCitizendIdAsync(int page, int limit, long? citizendId, bool? verify, string? search);
        Task<bool> HasIdNumberAsync(string idNumber);
        Task<CitizenId> GetbyId(Guid citizenId);
        Task<CitizenId> GetbyUserIdAsyn(Guid id);
    }
}
