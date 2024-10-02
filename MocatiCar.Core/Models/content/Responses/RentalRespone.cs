using MocatiCar.Core.SeedWorks.Enums;
using System.Text.Json.Serialization;

namespace MocatiCar.Core.Models.content.Responses
{
    public class RentalRespone
    {

        public Guid RentalId { get; set; }
        [JsonPropertyName("car")]
        public Guid? CarId { get; set; }
        public string? CarName { get; set; }
        public string? CarPlate { get; set; }
        public string? CarImage { get; set; }
        [JsonPropertyName("owner")]
        public Guid? OwnerId { get; set; }
        public string? OwnerName { get; set; }
        public string? OwnerPhone { get; set; }
        [JsonPropertyName("customer")]
        public Guid? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public DateTime StartDateTime
        { get; set; }
        public DateTime EndDateTime { get; set; }
        public string PickupLocation { get; set; }
        public string ReturnLocation { get; set; }
        public string? Note { get; set; }
        public RentalStatus RentalStatus { get; set; }
        // public decimal RentalAmount { get; set; }
        // public decimal InsuranceAmount { get; set; }
        // public decimal DepositAmount { get; set; }
        // public decimal RemainAmount { get; set; }

        public decimal BasePricePerDay { get; set; }
        public decimal CommissionPercentage { get; set; } = 15;
        public decimal CommissionAmount { get; set; }
        public decimal TotalPricePerDay { get; set; }
        public decimal DepositPercentage { get; set; } = 20;
        public decimal DepositAmount { get; set; }
        public decimal TotalDaysRented { get; set; }
        public decimal TotalRentalAmount { get; set; }
        public decimal InsuranceFee { get; set; } = 60000;
        public decimal FinalRentalAmount { get; set; }
        public decimal RemainingDepositAmount { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
