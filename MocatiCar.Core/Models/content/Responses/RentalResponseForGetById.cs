using MocatiCar.Core.SeedWorks.Enums;
using System.Text.Json.Serialization;

namespace MocatiCar.Core.Models.content.Responses
{
    public class RentalResponseForGetById
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
        public string? OnwerPhone { get; set; }
        [JsonPropertyName("customer")]
        public Guid? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerPhone { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string PickupLocation { get; set; }
        public string ReturnLocation { get; set; }
        public string? Note { get; set; }
        public RentalStatus RentalStatus { get; set; }
        public decimal RentalAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal DepositAmount { get; set; }
        public decimal RemainAmount { get; set; }
        public decimal CommissionAmount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
