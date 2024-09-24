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

        public async Task<PaginatedResult<CitizenId>> GetAllCitizenIdAsync(int page, int limit, string? citizendId, bool? verify, string? search)
        {
            IQueryable<CitizenId> query = _context.CitizenIds.AsQueryable();

            
            search = search?.Trim();

            // Kiểm tra xem có từ khóa tìm kiếm hay không
            if (!string.IsNullOrEmpty(search))
            {
                // Tìm kiếm tương đối cả IdNumber và FullName
                query = query.Where(c =>
                    c.IdNumber.ToLower().Contains(search.ToLower()) ||  // Kiểm tra IdNumber
                    c.FullName.ToLower().Contains(search.ToLower()));   // Kiểm tra FullName
            }

            // Đếm tổng số kết quả trước khi phân trang
            int totalItems = await query.CountAsync();

            // Thực hiện phân trang
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            // Trả về kết quả phân trang
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
            var query = await _context.CitizenIds.FirstOrDefaultAsync(u => u.UserId == id);
            return query;
        }

        public async Task<bool> HasIdNumberAsync(string idNumber, Guid? currentUserId)
        {
            if(currentUserId == null)
            {
                var citizenId = await _context.CitizenIds.FirstOrDefaultAsync(c => c.IdNumber == idNumber);
                return citizenId != null;
            } else
            {
                var citizenId = await _context.CitizenIds.Where(c => c.IdNumber == idNumber && c.UserId != currentUserId).FirstOrDefaultAsync();
                return citizenId != null;
            }
            
        }
    }
}
