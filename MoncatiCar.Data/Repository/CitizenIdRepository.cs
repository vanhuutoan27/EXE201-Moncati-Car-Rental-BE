using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class CitizenIdRepository : RepositoryBase<CitizenId, Guid>, ICitizendIdRepository
    {
        public CitizenIdRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<PaginatedResult<CitizenId>> GetAllCitizendIdAsync(int page, int limit, string? citizendId, bool? verify, string? search)
        {
            IQueryable<CitizenId> query = _context.CitizenIds.AsQueryable();
            int totalItems = query.Count();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return new PaginatedResult<CitizenId>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<CitizenId> GetbyId(Guid citizenId)
        {
            var citizen = await _context.CitizenIds.FirstOrDefaultAsync(c => c.Citizen_Id == citizenId);
            return citizen;
        }

        public async Task<CitizenId> GetbyUserIdAsyn(Guid id)
        {
            var query = await _context.CitizenIds.Where(c => c.UserId == id).FirstOrDefaultAsync();
            return query;
        }

        public async Task<bool> HasIdNumberAsync(string idNumber)
        {
            var citizenId = await _context.CitizenIds.FirstOrDefaultAsync(c => c.IdNumber == idNumber);
            return citizenId != null;
        }
    }
}
