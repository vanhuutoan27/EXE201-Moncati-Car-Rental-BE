using AutoMapper;
using Microsoft.AspNet.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.Models.content.Requests;
using MocatiCar.Core.Models.content.Responses;
using MocatiCar.Core.SeedWorks;
using MocatiCar.Core.SeedWorks.Enums;
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

        public async Task<bool> AddPayment(CreatePaymentRequest payment)
        {
            var rentalId = await _repositoryManager.RentalRepository.GetRentalByIdAsync(payment.RentalId ?? Guid.Empty);
            if (rentalId == null)
            {
                throw new Exception("RentalId is not found");
            }
            //var paymentStatus = PaymentStatus.Pending;


            var newPayment = new Payment
            {
                Amount = payment.Amount,
                CreatedAt = DateTime.Now,
                CreatedBy = rentalId.CustomerId,
                PaymentId = Guid.NewGuid(),
             //   PaymentMethod = payment.PaymentMethod,
                PaymentStatus = payment.PaymentStatus,
                RentalId = rentalId.RentalId,
            };
            _repositoryManager.PaymentRepository.Add(newPayment);
            await _repositoryManager.SaveAsync();
            return true;

        }

        public async Task<bool> DeletePayment(Guid id, Guid UserId)
        {
                var getPayment = await _repositoryManager.PaymentRepository.GetPaymentByPaymentId(id);
            if (getPayment == null)
            {
                throw new Exception("Not Found");
            }
            getPayment.PaymentStatus = PaymentStatus.Deleted;
            getPayment.UpdatedBy = UserId;  
            getPayment.UpdatedAt = DateTime.Now;    

            _repositoryManager.PaymentRepository.Update(getPayment);
            await _repositoryManager.SaveAsync();
            return true;

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

        public async Task<PaymentReponse> GetPaymentById(Guid rentalId)
        {
            var getPayment = await _repositoryManager.PaymentRepository.GetPaymentByPaymentId(rentalId); 
            return _mapper.Map<PaymentReponse>(getPayment); 
        }

        public async Task<IEnumerable<PaymentReponse>> GetPaymentByUserId(Guid id)
        {
           /* var listPayment = await _repositoryManager.PaymentRepository.GetAllPaymentAsync(1, 10, null);
            var getPaymentByUser =  listPayment.Where(p => p.Rental.CustomerId == id);*/
           var getPaymentByUser = await _repositoryManager.PaymentRepository.getPaymentByUserId(id);    
            return _mapper.Map<IEnumerable<PaymentReponse>>(getPaymentByUser);

        }

        public async Task<PaymentReponse> GetPaymentRentalId(Guid id)
        {
            var listPayment = await _repositoryManager.PaymentRepository.GetPaymentByRentalId(id);
            return _mapper.Map<PaymentReponse>(listPayment);
        }

        public async Task<bool> UpdatePayment(CreateUpdateAllFieldPaymentRequest payment,Guid UserUpdate)
        {
            var existingPayment = await _repositoryManager.PaymentRepository.GetPaymentByPaymentId(payment.PaymentId);
            if(existingPayment == null) {
                throw new Exception(" Can not found");
            }
            existingPayment.PaymentId = existingPayment.PaymentId;
            existingPayment.RentalId = payment.RentalId;
            existingPayment.UpdatedBy = UserUpdate;
            existingPayment.Amount = payment.Amount;
            existingPayment.CreatedAt = existingPayment.CreatedAt;
            existingPayment.CreatedBy = existingPayment.CreatedBy;
            //existingPayment.PaymentMethod = payment.PaymentMethod;
            existingPayment.PaymentStatus = ((PaymentStatus)payment.PaymentStatus);
            existingPayment.UpdatedAt = DateTime.Now;
            _repositoryManager.PaymentRepository.Update(existingPayment);
              await _repositoryManager.SaveAsync();
            return true;

        } 

        public async Task<bool> UpdateStatus(CreateUpdatePaymentRequest payment, Guid userUpdate)
        {
            // Tìm kiếm bản ghi Payment theo ID
            var existingPayment = await _repositoryManager.PaymentRepository.GetPaymentByPaymentId(payment.PaymentId);

            if (existingPayment == null)
            {
                throw new Exception("Payment not found.");
            }

            // Cập nhật trạng thái thanh toán của Payment
            existingPayment.PaymentStatus =((PaymentStatus)payment.PaymentStatus);
            existingPayment.UpdatedAt = DateTime.Now;        // Cập nhật thời gian cập nhật
            existingPayment.UpdatedBy = userUpdate;   // Cập nhật người thực hiện thay đổi

            // Lưu thay đổi vào cơ sở dữ liệu
             _repositoryManager.PaymentRepository.Update(existingPayment);
            await _repositoryManager.SaveAsync();

            return true;
        }
    }
}
