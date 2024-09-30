using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Content
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; }
        public Guid? RentalId { get; set; }
      //  public string PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; } // su dung enum 
        public decimal Amount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        [ForeignKey(nameof(RentalId))]
        public Rental Rental { get; set; }
    }
}
