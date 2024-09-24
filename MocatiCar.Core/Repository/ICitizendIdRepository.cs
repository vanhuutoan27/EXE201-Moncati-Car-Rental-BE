using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface ICitizendIdRepository : IRepositoryBase<CitizenId, Guid>
    {
       Task<PaginatedResult<CitizenId>> GetAllCitizenIdAsync(int page, int limit, string? citizendId, bool? verify, string? search);
        Task<bool> HasIdNumberAsync(string idNumber);
        Task<CitizenId> GetbyId(Guid citizenId);
        Task<CitizenId> GetbyUserIdAsyn(Guid id);
    }
}
