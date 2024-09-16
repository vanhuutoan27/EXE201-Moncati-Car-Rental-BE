using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateRentalRequest
    {
        [Required]
        [JsonPropertyName("owner")]
        public Guid? OwnerId { get; set; }
        [Required]
        [JsonPropertyName("customer")]
        public Guid? CustomerId { get; set; }
        [JsonPropertyName("car")]
        public Guid? CarId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string PickupLocation { get; set; }
        public string ReturnLocation { get; set; }
        public string? Note { get; set; }
        public decimal RentalAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal DepositAmount { get; set; }
       
     }
}
