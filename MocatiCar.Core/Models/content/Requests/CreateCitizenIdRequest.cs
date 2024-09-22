using System.Text.Json.Serialization;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateCitizenIdRequest
    {
        [JsonPropertyName("user")]
        public Guid UserId { get; set; }
        public string IdNumber { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuingAuthority { get; set; }
    }
}
