using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateCarRequest
    {

        [Required]
        public string LicensePlate { get; set; } = string.Empty;




        [Required]

        public int Seats { get; set; }

        [Required]
        public Transmission Transmission { get; set; }

        [Required]
        public FuelType FuelType { get; set; }

        public string FuelConsumption { get; set; }

        public string? Description { get; set; }

        [Required]
        public string Location { get; set; } = string.Empty;



        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price per day must be a positive value.")]
        public decimal PricePerDay { get; set; }
        //[Required]
        //[JsonPropertyName("brand")]
        //public Guid BrandId { get; set; }
        [Required]
        [JsonPropertyName("owner")]

        public Guid OwnerId { get; set; }
        [Required]
        [JsonPropertyName("carType")]

        public Guid CarTypeId { get; set; }
        [Required]
        [JsonPropertyName("model")]

        public Guid ModelId { get; set; }

        public List<string>? Images { get; set; } = new List<string>();

        public List<string> Features { get; set; }

        [Required]
        public CarRentalStatus RentalStatus { get; set; }



    }
}
