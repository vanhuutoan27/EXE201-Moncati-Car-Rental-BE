using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateDrivingLicenseRequest
    {
        [JsonPropertyName("user")]
        public Guid UserId { get; set; }
        [Required(ErrorMessage = "License number is required.")]
        public string LicenseNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }

    }
}
