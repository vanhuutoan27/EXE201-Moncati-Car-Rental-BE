using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Responses
{
    public class CarResponeIdandSlug
    {
        public Guid CarId { get; set; }
        public Guid Owner { get; set; }
        public string LicensePlate { get; set; }
        public string Slug { get; set; }
        public string Brand { get; set; } // Extracted from Model or CarType
        public string Model { get; set; } // Extracted from Model entity
        public ICollection<string> Features { get; set; }
        public int Seats { get; set; }
        public Transmission Transmission { get; set; }
        public FuelType FuelType { get; set; }
        public string FuelConsumption { get; set; }
        public string? Description { get; set; }
        public string Location { get; set; }
        public decimal PricePerDay { get; set; }
        public List<string> Images { get; set; }


        public CarRentalStatus RentalStatus { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

