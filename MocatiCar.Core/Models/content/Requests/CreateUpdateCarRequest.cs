using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateCarRequest
    {
   
        [Required]
        public string LicensePlate { get; set; } = string.Empty;

        [Required]
        public string Slug { get; set; } = string.Empty;
   

        [Required]

        public int Seats { get; set; }

        [Required]
        public string Transmission { get; set; } = string.Empty;

        [Required]
        public string FuelType { get; set; } = string.Empty;

        public string FuelConsumption { get; set; }

        public string? Description { get; set; }

        [Required]
        public string Location { get; set; } = string.Empty;

     
      
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Price per day must be a positive value.")]
        public decimal PricePerDay { get; set; }
        [Required]
        public Guid BrandId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public Guid CarTypeId { get; set; }
        [Required]
        public Guid ModelId { get; set; }

        [Required]
        public List<string> Images { get; set; } = new List<string>();
        //[Required]
        //public List<ReviewDto> Reviews { get; set; }
        [Required]
        public string RentalStatus { get; set; }
        [Required]
        public bool Status { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
