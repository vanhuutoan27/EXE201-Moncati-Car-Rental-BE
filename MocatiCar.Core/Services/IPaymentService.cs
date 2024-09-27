using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Models.content.Requests;
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

        Task <PaymentReponse> GetPaymentById(Guid id);
        Task<IEnumerable<PaymentReponse>> GetPaymentByUserId(Guid id);
        Task<PaymentReponse> GetPaymentRentalId(Guid id);
        Task <bool> AddPayment(CreatePaymentRequest payment);
        Task<bool> UpdatePayment(CreateUpdateAllFieldPaymentRequest payment, Guid userUpdate); 

        Task <bool> DeletePayment(Guid id, Guid UserId);

        Task <bool> UpdateStatus( CreateUpdatePaymentRequest payment, Guid userUpdate);

    }
}
