using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class CitizenIdRepository : RepositoryBase<CitizenId, Guid>, ICitizendIdRepository
    {
        public CitizenIdRepository(MocatiContext context) : base(context)
        {
        }

        public Task<IEnumerable<CitizenId>> GetAllCitizendIdAsync(int page, int limit, long citizendId, bool verify, string search)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HasIdNumberAsync(string idNumber)
        {
            var citizenId = await _context.CitizenIds.FirstOrDefaultAsync(c => c.IdNumber == idNumber);
            return citizenId != null;
        }
    }
}
