using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Repository
{
    public interface IPaymentRepository : IRepositoryBase<Payment, Guid>
    {
        Task<IEnumerable<Payment>> GetAllPaymentAsync(int page, int limit, string PaymentStatus);

        Task<Payment> GetPaymentByPaymentId(Guid id);
        Task<Payment> GetPaymentByRentalId(Guid id);

        Task<IEnumerable< Payment>> getPaymentByUserId(Guid userId);

    }
}
