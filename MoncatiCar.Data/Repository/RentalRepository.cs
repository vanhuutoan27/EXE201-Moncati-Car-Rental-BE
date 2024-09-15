using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.Repository;
using MocatiCar.Core.SeedWorks.Enums;
using MoncatiCar.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Repository
{
    public class RentalRepository : RepositoryBase<Rental, Guid>, IRentalRepository
    {
        public RentalRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Rental>> GetAllRentalAsync(int page, int limit, RentalStatus? filter, DateTime? createAt)
        {
            IQueryable<Rental> query = _context.Rentals
                                               .Include(r => r.Car)
                                               .Include(r => r.Contracts)
                                               .Include(r => r.Payments);

            // Thêm log để kiểm tra filter và createAt
            Console.WriteLine($"Filter: {filter}, CreateAt: {createAt}");

            // Chỉ lọc theo RentalStatus nếu filter có giá trị
            if (filter.HasValue)
            {
                query = query.Where(r => r.RentalStatus == filter.Value);
            }

            if (createAt.HasValue)
            {
                var startDate = new DateTime(createAt.Value.Year, createAt.Value.Month, 1);
                var endDate = createAt.Value;
                query = query.Where(r => r.CreatedAt >= startDate && r.CreatedAt <= endDate);
            }

            // Phân trang
            query = query.Skip((page - 1) * limit)
                         .Take(limit);

            var rentals = await query.ToListAsync();

            // Nạp dữ liệu thủ công cho Owner và Customer nếu cần
            foreach (var rental in rentals)
            {
                rental.Owner = await _context.Users.FindAsync(rental.OwnerId);
                rental.Customer = await _context.Users.FindAsync(rental.CustomerId);
            }

            return rentals;
        }


        public async Task<IEnumerable<Rental>> GetRentalByCarId(Guid id)
            {
                var rentals = await _context.Rentals.Include(c =>c.Car).Where(c => c.CarId == id).Include(r => r.Contracts)
                                                                           .Include(p => p.Payments)
                                                                           .Include(c => c.Contracts)
                                                                          .ToListAsync();
                foreach (var rental in rentals)
                {
                    rental.Owner = await _context.Users.FindAsync(rental.OwnerId);
                    rental.Customer = await _context.Users.FindAsync(rental.CustomerId);

                    // Kiểm tra null cho Owner và Customer để tránh lỗi NullReferenceException
                    if (rental.Owner == null)
                    {
                        throw new Exception($"Owner   does not exist.");
                    }

                    if (rental.Customer == null)
                    {
                        throw new Exception($"Customer  does not exist.");
                    }
                }
                return rentals;
            }

        public async Task<Rental> GetRentalByIdAsync(Guid id)
        {
            var rental = await _context.Rentals
                                       .Include(r => r.Car)
                                       .Include(r => r.Contracts)
                                       .Include(r => r.Payments)
                                       .FirstOrDefaultAsync(r => r.RentalId == id);

            if (rental == null)
            {
                throw new Exception("Rental does not exist.");
            }

            rental.Owner = await _context.Users.FirstOrDefaultAsync(u => u.Id == rental.OwnerId);
            rental.Customer = await _context.Users.FirstOrDefaultAsync(o => o.Id == rental.CustomerId);

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



        public async Task<IEnumerable<Rental>> GetRentalByUserId(Guid id)
        {
            var users = await _context.Rentals.Include(c => c.Car).Where(u => u.CustomerId == id || u.OwnerId == id)
                                          .Include(r => r.Contracts)
                                          .Include(r => r.Payments).ToListAsync();
                                                                    
            foreach (var rental in users)
            {
                rental.Owner = await _context.Users.FindAsync(rental.OwnerId);
                rental.Customer = await _context.Users.FindAsync(rental.CustomerId);

                // Kiểm tra null cho Owner và Customer để tránh lỗi NullReferenceException
                if (rental.Owner == null)
                {
                    throw new Exception($"Owner does not exist.");
                }

                if (rental.Customer == null)
                {
                    throw new Exception($"Customer does not exist.");
                }
            }
            return users;
        }
    }
}
