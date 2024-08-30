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
        Task AddPayment(Payment payment);
        Task UpdatePayment(Payment payment, Guid id);


    }
}
