using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;

namespace MocatiCar.Core.Repository
{
    public interface IContractRepository : IRepositoryBase<Contract, Guid>
    {
        public Task<Contract> GetContractByRentalId(Guid rentalId);
        public Task<PaginatedResult<Contract>> GetAllContractAsync(int page, int limit, Guid? RentalId);
    }
}
