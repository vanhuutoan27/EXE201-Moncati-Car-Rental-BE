using MocatiCar.Core.SeedWorks.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Responses
{
    public class RentalRespone
    {
        [JsonPropertyName("rental")]
        public Guid RentalId { get; set; }
        [JsonPropertyName("car")]
        public Guid? CarId { get; set; }
        [JsonPropertyName("owner")]
        public Guid? OwnerId { get; set; }
        [JsonPropertyName("customer")]
        public Guid? CustomerId { get; set; }
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
