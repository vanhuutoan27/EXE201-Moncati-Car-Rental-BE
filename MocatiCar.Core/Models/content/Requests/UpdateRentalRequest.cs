using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateRentalRequest
    {
      
        public string PickupLocation { get; set; }
        public string ReturnLocation { get; set; }
        public string? Note { get; set; }
        public decimal RentalAmount { get; set; }
        public decimal InsuranceAmount { get; set; }
        public decimal DepositAmount { get; set; }
    }
}
