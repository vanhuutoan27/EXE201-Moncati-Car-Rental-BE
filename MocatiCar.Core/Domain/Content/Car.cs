using MocatiCar.Core.Domain.Identity;
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
        public string Color { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string FuelConsumption { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public decimal PricePerDay { get; set; }
        public string? RentalOptions { get; set; }
        public string? RentalStatus { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        //FK 
        public Guid CarTypeId { get; set; }
        [ForeignKey(nameof(CarTypeId))]
        public CarType CarType { get; set; }

        public ICollection<Image> Images { get; set; }
        public ICollection<CarFeature> CarFeatures { get; set; }
        public ICollection<Review> Reviews { get; set; }

        public Guid ModelId { get; set; }
        [ForeignKey(nameof(ModelId))]
        public Model Model { get; set; }

        public Guid OwnerId { get; set; }
        [ForeignKey(nameof(OwnerId))]
        public AppUser User { get; set; }

    }
}
