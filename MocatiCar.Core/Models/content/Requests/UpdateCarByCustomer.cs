using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateCarByCustomer
    {

        public float? FuelConsumption { get; set; }

        public string? Description { get; set; }

        public string Location { get; set; } = string.Empty;

        [Range(0, double.MaxValue, ErrorMessage = "Price per day must be a positive value.")]
        public decimal PricePerDay { get; set; }
        public float? discount { get; set; }
        public bool? InstantBooking { get; set; } = false;
        public string? LocationDetails { get; set; }
        public int? MaxDeliveryDistance { get; set; } = 0;
        public int? DeliveryFeePerKm { get; set; } = 0;
        public int? FreeDeliveryWithinKm { get; set; } = 0;
        public int? LimitKilometersPerDay { get; set; } = 0;
        public int? OverLimitFeePerKm { get; set; } = 0;
        public string? RentalTerms { get; set; }





    }
}
