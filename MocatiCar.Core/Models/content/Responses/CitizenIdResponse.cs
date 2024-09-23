using System.Text.Json.Serialization;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Responses
{
    public class CitizenIdResponse
    {
        [JsonPropertyName("citizenId")]
        public Guid CitizenId { get; set; }
        public string IdNumber { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string FullName { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuingAuthority { get; set; }
        public bool Verified { get; set; }
        //public string FrontOfCard { get; set; }
        //public string EndOfCard { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
