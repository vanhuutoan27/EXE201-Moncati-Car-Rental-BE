using MocatiCar.Core.Domain.Identity;
using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Content
{
    public class Car
    {
        [Key]
        public Guid CarId { get; set; }
        public string Slug { get; set; }
        public string licensePlate { get; set; }
        public int Seats { get; set; }
        public Transmission Transmission { get; set; }
        public FuelType FuelType { get; set; }
        public float? FuelConsumption { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public decimal PricePerDay { get; set; }
        //public string? RentalOptions { get; set; }
        public CarRentalStatus RentalStatus { get; set; } = CarRentalStatus.Unavailable;
        public bool Status { get; set; }
        public float? discount { get; set; }
        public bool? InstantBooking { get; set; }
        public string? LocationDetails { get; set; }
        public int? MaxDeliveryDistance { get; set; }
        public int? DeliveryFeePerKm { get; set; }
        public int? FreeDeliveryWithinKm { get; set; }
        public int? LimitKilometersPerDay { get; set; }
        public int? OverLimitFeePerKm { get; set; }
        public string? RentalTerms { get; set; }
        public int year { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        //FK 
        public Guid? CarTypeId { get; set; }
        [ForeignKey(nameof(CarTypeId))]
        public CarType CarType { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<CarFeature> CarFeatures { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Rental> Rentals { get; set; }
        public Guid ModelId { get; set; }
        [ForeignKey(nameof(ModelId))]
        public Model Model { get; set; }

        public Guid? OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public AppUser User { get; set; }

    }
}
