using MocatiCar.Core.Domain.Content;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MocatiCar.Core.Domain.Identity;

namespace MocatiCar.Core.Models.content.Responses
{
    public class CarResponse
    {
       
        public Guid Owner { get; set; } 
        public string LicensePlate { get; set; }
        public string Slug { get; set; }
        public string Brand { get; set; } // Extracted from Model or CarType
        public string Model { get; set; } // Extracted from Model entity
      
        public int Seats { get; set; }
        public string Transmission { get; set; }
        public string FuelType { get; set; }
        public string FuelConsumption { get; set; }
        public string ?Description { get; set; }
        public string Location { get; set; }
        public decimal PricePerDay { get; set; }
        public ICollection<ImageResponse> Images { get; set; }
        public ICollection<ReviewResponse> Reviews { get; set; }

        public string RentalStatus { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }

    // ImageResponse class
    public class ImageResponse
    {
        public Guid ImageId { get; set; }
      
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    // ReviewResponse class
    public class ReviewResponse
    {
        public Guid ReviewId { get; set; }
        public Guid? Author { get; set; }
        public int Rating { get; set; }
        public string ?Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

   

}