using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Content
{
    public class Rental
    {
        [Key]
        public Guid RentalId { get; set; }
        public Guid? CarId { get; set; }
        public Guid? OwnerId { get; set; }
        public Guid? CustomerId { get; set; }
        public DateTime StartDayTime { get; set; }
        public DateTime EndDayTime { get; set; }
        public string PickupLocation { get; set; }
        public string ReturnLocation { get; set; }
        public string? Note { get; set; }
        public RentalStatus RentalStatus { get; set; }
        public decimal RentalAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CommissionAmount { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public AppUser AppUser { get; set; }


    }
}
