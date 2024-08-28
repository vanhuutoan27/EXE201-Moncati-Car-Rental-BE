using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateCarRequest
    {

       
        public string LicensePlate { get; set; } = string.Empty;
        public int Seats { get; set; }
        [Required]
        public int Transmission { get; set; }
        [Required]
        public int FuelType { get; set; }

    
      
        public int Year { get; set; }   
        public float? discount { get; set; }    
        public bool? InstantBooking { get; set; } = false;
        public string? LocationDetails { get; set; }
        public int? MaxDeliveryDistance { get; set; } = 0;
        public int? DeliveryFeePerKm { get; set; } = 0;
        public int? FreeDeliveryWithinKm { get; set; } = 0;
        public int? LimitKilometersPerDay { get; set; } = 0;
        public int? OverLimitFeePerKm { get; set; } = 0;
        public string? RentalTerms { get; set; }
        public float? FuelConsumption { get; set; }

        public string? Description { get; set; }

        public string Location { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Price per day must be a positive value.")]
        public decimal PricePerDay { get; set; }
        
     
        [JsonPropertyName("owner")]

        public Guid OwnerId { get; set; }
     
        [JsonPropertyName("carType")]

        public Guid CarTypeId { get; set; }
        [Required]
        [JsonPropertyName("model")]

        public string ModelName { get; set; }

        [Required]
        [JsonPropertyName("brand")]
        public string BrandName { get; set; }
        public List<string>? Images { get; set; } = new List<string>();

        public List<string> Features { get; set; }

      



    }
}
