using MocatiCar.Core.SeedWorks.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreatePaymentRequest
    {
        public Guid? RentalId { get; set; }

        public decimal Amount { get; set; }

        public PaymentStatus PaymentStatus { get; set; }    
        

    }
}
