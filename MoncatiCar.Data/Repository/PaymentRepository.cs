using Microsoft.EntityFrameworkCore;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Repository;
using MoncatiCar.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Repository
{
    public class PaymentRepository : RepositoryBase<Payment, Guid>, IPaymentRepository
    {
        public PaymentRepository(MocatiContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Payment>> GetAllPaymentAsync(int page, int limit, string PaymentStatus)
        {


            if (string.IsNullOrEmpty(PaymentStatus))
            {
                if (page > 0 && limit > 0)
                {
                    return await _context.Payments
                   /*     .Include(p=> p.Rental)
                            .ThenInclude(c => c.App)*/
                        .Include(p => p.Rental)
                            .ThenInclude(c => c.Car)
                            .ThenInclude(r => r.CarType)
                        .Skip((page - 1) * limit).Take(limit).ToListAsync();
                }
                return await _context.Payments
                    .Include(r => r.Rental)
                            .ThenInclude(r => r.Customer)
                            .ThenInclude(r => r.Cars)
                            .ThenInclude(r => r.CarType).ToListAsync();
            }
            else
            {
                return await _context.Payments
                    .Where(s => s.PaymentStatus.ToLower().Contains(PaymentStatus.ToLower()))
                    .Include(r => r.Rental)
                            .ThenInclude(r => r.Customer)
                            .ThenInclude(r => r.Cars)
                            .ThenInclude(r => r.CarType)
                    .Skip((page - 1) * limit).Take(limit).ToListAsync();
            }
        }
    }
}
