using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class ContractRepository : RepositoryBase<Contract, Guid>, IContractRepository
    {
        public ContractRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<PaginatedResult<Contract>> GetAllContractAsync(int page, int limit, Guid? RentalId)
        {
            IQueryable<Contract> query = _context.Contracts.AsQueryable();
            if (RentalId.HasValue)
            {
                query.Where(c => c.RentalId == RentalId);
            }
            int totalItems = await query.CountAsync();

            return new PaginatedResult<Contract>
            {
                TotalCount = totalItems,
                Items = query.ToList()
            };
        }

        public async Task<Contract> GetContractByRentalId(Guid rentalId)
        {
            return await _context.Contracts.FirstOrDefaultAsync(c => c.RentalId == rentalId);
        }
    }

}

