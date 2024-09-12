using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdatePaymentRequest
    {
        public Guid PaymentId { get; set; }

        public PaymentStatus PaymentStatus { get; set; }
    }

    public class CreateUpdateAllFieldPaymentRequest
    {
        public Guid PaymentId { get; set; }

        public Guid? RentalId { get; set; }
        public string PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; } // su dung enum 
        public string Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? UpdatedBy { get; set; }
    }

}
