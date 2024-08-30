using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Services
{
    public interface IPaymentService 
    {
        Task<PageResult<PaymentReponse>> GetAllBaseStatus(int page, int limit, string PaymentStatus);

        Task <PaymentReponse> GetPaymentById(Guid rentalId);
        Task<PaymentReponse> GetPaymentByUserId(Guid id);
        Task<PaymentReponse> GetPaymentRentalId(Guid id);
        Task <bool> AddPayment(Payment payment);
        Task <bool>UpdatePayment(Payment payment, Guid id);

        Task <bool> DeletePayment(Guid id);

        Task <bool> UpdateStatus(Payment payment, Guid id);

    }
}
