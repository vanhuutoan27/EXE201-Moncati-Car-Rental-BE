using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string PickupLocation { get; set; }
        public string ReturnLocation { get; set; }
        public string? Note { get; set; }
        public RentalStatus RentalStatus { get; set; } = RentalStatus.Pending;
        public decimal RentalAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal RemainAmount { get; set; }
        public decimal CommissionAmount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }
        [ForeignKey(nameof(OwnerId)), Column(Order = 0)]
        //[NotMapped]
        public AppUser Owner { get; set; }
        [ForeignKey(nameof(CustomerId)), Column(Order = 1)]
        //[NotMapped]
        public AppUser Customer { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public Review Review { get; set; }
    }
}
