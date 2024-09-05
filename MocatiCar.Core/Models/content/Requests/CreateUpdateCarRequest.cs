using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateCarRequest
    {
        [JsonPropertyName("owner")]
        public Guid OwnerId { get; set; }
        //[JsonPropertyName("carType")]
        //public Guid CarTypeId { get; set; }
        public string LicensePlate { get; set; } = string.Empty;
        [Required]
        [JsonPropertyName("brand")]
        public string BrandName { get; set; }
        [Required]
        [JsonPropertyName("model")]
        public string ModelName { get; set; }
        public int Seats { get; set; }
        public int Year { get; set; }
        [Required]
        public int Transmission { get; set; }
        [Required]
        public int FuelType { get; set; }
        public float? FuelConsumption { get; set; }
        public string? Description { get; set; }
        public List<string> Features { get; set; }
        public decimal PricePerDay { get; set; }
        public string Location { get; set; } = string.Empty;
        public string? LocationDetails { get; set; }
        public float? discount { get; set; }    
        public bool? InstantBooking { get; set; } = false;
        public int? MaxDeliveryDistance { get; set; } = 0;
        public int? DeliveryFeePerKm { get; set; } = 0;
        public int? FreeDeliveryWithinKm { get; set; } = 0;
        public int? LimitKilometersPerDay { get; set; } = 0;
        public int? OverLimitFeePerKm { get; set; } = 0;
        public string? RentalTerms { get; set; }
        public List<string>? Images { get; set; } = new List<string>();
    }
}
