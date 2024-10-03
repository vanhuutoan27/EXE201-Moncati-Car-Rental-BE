using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.Repository;
using MocatiCar.Core.SeedWorks.Enums;
using MoncatiCar.Data.SeedWork;

namespace MoncatiCar.Data.Repository
{
    public class RentalRepository : RepositoryBase<Rental, Guid>, IRentalRepository
    {
        public RentalRepository(MocatiContext context) : base(context)
        {
        }

        public Task<int> CountAsync(Guid carId)
        {
            return _context.Rentals.CountAsync(r => r.CarId == carId);
        }

        public Task<int> CountRecord()
        {
            return _context.Rentals.CountAsync();
        }

        public async Task<IEnumerable<Rental>> GetAllRentalAsync(int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            IQueryable<Rental> query = _context.Rentals
                                                .Include(r => r.Car).ThenInclude(r => r.Model).ThenInclude(m => m.Brand)
                                        .Include(r => r.Car).ThenInclude(c => c.Images)
                                        .Include(r => r.Owner)
                                        .Include(r => r.Customer)
                                        .Include(r => r.Contracts)
                                        .Include(r => r.Payments).AsQueryable();

            // Thêm log để kiểm tra filter và createAt
            //Console.WriteLine($"Filter: {filter}, CreateAt: {createAt}");

            // Chỉ lọc theo RentalStatus nếu filter có giá trị
            if (filter.HasValue)
            {
                query = query.Where(r => r.RentalStatus == filter.Value);
            }

            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);
            }

            if (page > 0 && limit > 0)
            {
                // Phân trang
                query = query.Skip((page - 1) * limit)
                         .Take(limit);
            }



            var rentals = await query.OrderByDescending(o => o.CreatedAt).ToListAsync();

            // Nạp dữ liệu thủ công cho Owner và Customer nếu cần
            //foreach (var rental in rentals)
            //{
            //    rental.Owner = await _context.Users.FindAsync(rental.OwnerId);
            //    rental.Customer = await _context.Users.FindAsync(rental.CustomerId);
            //}

            return rentals;
        }


        public async Task<IEnumerable<Rental>> GetRentalByCarId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            IQueryable<Rental> query = _context.Rentals.Where(r => r.CarId == id)
                .Include(r => r.Car).
                ThenInclude(i => i.Images)
                .Include(r => r.Car).ThenInclude(m => m.Model)
                .ThenInclude(b => b.Brand)
                .Include(r => r.Owner)
                .Include(r => r.Customer)
                .Include(r => r.Contracts)
                .Include(r => r.Payments).AsQueryable();

            if (filter.HasValue)
            {
                query = query.Where(r => r.RentalStatus == filter.Value);
            }
            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);

            }
            if (page > 0 && limit > 0)
            {
                // Phân trang
                query = query.Skip((page - 1) * limit)
                         .Take(limit);
            }
            return await query.ToListAsync();
        }


        public async Task<Rental> GetRentalByIdAsync(Guid id)
        {
            var rental = await _context.Rentals
                                        .Include(r => r.Car).ThenInclude(r => r.Model).ThenInclude(m => m.Brand)
                                        .Include(r => r.Car).ThenInclude(c => c.Images)
                                        .Include(r => r.Owner)
                                        .Include(r => r.Customer)
                                        .Include(r => r.Contracts)
                                        .Include(r => r.Payments)
                                        .FirstOrDefaultAsync(r => r.RentalId == id);

            // Kiểm tra nếu không tìm thấy rental
            if (rental == null)
            {
                throw new Exception("Rental does not exist.");
            }

            // Lấy thông tin chủ sở hữu và khách hàng từ bảng Users
            rental.Owner = await _context.Users.FirstOrDefaultAsync(u => u.Id == rental.OwnerId);
            rental.Customer = await _context.Users.FirstOrDefaultAsync(c => c.Id == rental.CustomerId);

            if (rental.Owner == null)
            {
                throw new Exception($"Owner with Id {rental.OwnerId} does not exist.");
            }

            if (rental.Customer == null)
            {
                throw new Exception($"Customer with Id {rental.CustomerId} does not exist.");
            }

            return rental;
        }

        public async Task<PaginatedResult<Rental>> GetRentalByOwnerId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            IQueryable<Rental> query = _context.Rentals.Where(r => r.OwnerId == id).Include(r => r.Car)
                .ThenInclude(i => i.Images)
                .Include(c => c.Car).ThenInclude(m => m.Model).ThenInclude(b => b.Brand)
                .Include(r => r.Owner)
                .Include(r => r.Customer)
               .Include(r => r.Contracts)
               .Include(r => r.Payments).OrderByDescending(o => o.CreatedAt).AsQueryable();

            if (filter.HasValue)
            {
                query = query.Where(r => r.RentalStatus == filter.Value);
            }
            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);

            }
            int totalItems = await query.CountAsync();

            if (page > 0 && limit > 0)
            {
                // Phân trang
                query = query.Skip((page - 1) * limit)
                         .Take(limit);
            }
            return new PaginatedResult<Rental>
            {
                Items = await query.ToListAsync(),
                TotalCount = totalItems
            };
        }

        public async Task<IEnumerable<Rental>> GetRentalByUserId(Guid id, int page, int limit, RentalStatus? filter, DateTime? startDate, DateTime? endDate)
        {
            IQueryable<Rental> query = _context.Rentals.Where(r => r.CustomerId == id).Include(r => r.Car)
                .ThenInclude(i => i.Images)
                .Include(c => c.Car).ThenInclude(m => m.Model).ThenInclude(b => b.Brand)
                .Include(r => r.Owner)
                .Include(r => r.Customer)
               .Include(r => r.Contracts)
               .Include(r => r.Payments).AsQueryable();

            if (filter.HasValue)
            {
                query = query.Where(r => r.RentalStatus == filter.Value);
            }
            if (startDate.HasValue && endDate.HasValue)
            {
                query = query.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);

            }
            if (page > 0 && limit > 0)
            {
                // Phân trang
                query = query.Skip((page - 1) * limit)
                         .Take(limit);
            }
            return await query.ToListAsync();
        }
    }
}
