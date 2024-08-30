using AutoMapper;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoncatiCar.Data.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public PaymentService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public Task AddPayment(Payment payment)
        {
            throw new NotImplementedException();
        }

        public async Task<PageResult<PaymentReponse>> GetAllBaseStatus(int page, int limit, string PaymentStatus)
        {
            var listPayment = await _repositoryManager.PaymentRepository.GetAllPaymentAsync(page, limit, PaymentStatus);

            var PaymentReponses = _mapper.Map<IEnumerable<PaymentReponse>>(listPayment);

       /*     foreach (var paymentResponse in PaymentReponses) {
                var payment = listPayment.FirstOrDefault(p => p.PaymentId == paymentResponse.PaymentId);

                if (payment != null)
                {
                    if (payment.Rental != null)
                    {
                        var customerId = payment.Rental.CustomerId ?? Guid.Empty;

                        // Retrieve customer details using the customerId from the Rental object
                        var customer = await _repositoryManager.UserRepository.GetUserById(customerId);

                        // Retrieve car details using carId from payment
                        if (paymentResponse.Rental.User == null)
                        {
                            paymentResponse.Rental.User = new UserResponse();
                        }

                        // Enrich the PaymentResponse object with additional customer and car details
                        paymentResponse.Rental.User.FullName = customer?.FullName;
                        paymentResponse.Rental.User.Address = customer?.Address;
                        paymentResponse.Rental.User.Avatar = customer?.Avatar;
                    }
                }


            }*/

            var totalItems = listPayment.Count();


            return new PageResult<PaymentReponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = PaymentReponses
            };
        }

        public Task<PaymentReponse> GetPaymentById(Guid rentalId)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentReponse> GetPaymentByUserId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentReponse> GetPaymentRentalId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePayment(Payment payment, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
