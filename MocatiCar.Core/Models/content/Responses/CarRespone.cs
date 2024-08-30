using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Responses
{
    public class CarResponse
    {
        public Guid CarId { get; set; }
        public Guid Owner { get; set; }
        public string LicensePlate { get; set; }
        public string Slug { get; set; }
        public string Brand { get; set; } // Extracted from Model or CarType
        public string Model { get; set; } // Extracted from Model entity  
        public int Seats { get; set; }
        public Transmission Transmission { get; set; }
        public FuelType FuelType { get; set; }
        public float FuelConsumption { get; set; }
        public string? Description { get; set; }
        public string Location { get; set; }
        public decimal PricePerDay { get; set; }

        //public ICollection<ReviewResponse> Reviews { get; set; }
        public List<string> Images { get; set; }
        public ICollection<string> Features { get; set; }
        public float? Discount { get; set; }
        public bool? InstantBooking { get; set; } = false;
        public int? MaxDeliveryDistance { get; set; } 
        public int? DeliveryFeePerKm { get; set; } 
        public int? FreeDeliveryWithinKm { get; set; } 
        public int? LimitKilometersPerDay { get; set; } 
        public int? OverLimitFeePerKm { get; set; } 
        public string? RentalTerms { get; set; }
        public CarRentalStatus RentalStatus { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }

    // ImageResponse class


    // ReviewResponse class
    public class ReviewResponse
    {
        public Guid ReviewId { get; set; }
        public Guid? Author { get; set; }
        public int Rating { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }



}