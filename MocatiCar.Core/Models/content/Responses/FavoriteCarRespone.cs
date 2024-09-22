using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Responses
{
    public class FavoriteCarRespone
    {

        public Guid FavoriteCarId { get; set; }
        [JsonPropertyName("car")]
        public Guid? CarId { get; set; }
        [JsonPropertyName("owner")]
        public Guid? OwnerId { get; set; }
        public string ownerName { get; set; }
        public string ownerAvatar { get; set; }
        public string licensePlate { get; set; }
        public string slug { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public int seats { get; set; }
        public Transmission transmission { get; set; }
        public FuelType fuelType { get; set; }

        public string? description { get; set; }
        public string? location { get; set; }
        public decimal pricePerDay { get; set; }
        public string image { get; set; }
        public decimal commissionAmount { get; set; }
        public int totalRentals { get; set; }
        public int totalReviews { get; set; }
        public double averageRating { get; set; }
    }
}