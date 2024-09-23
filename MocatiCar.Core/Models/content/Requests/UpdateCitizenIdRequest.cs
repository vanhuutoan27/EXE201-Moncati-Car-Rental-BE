using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateCitizenIdRequest
    {
        public string IdNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuingAuthority { get; set; }
    }
}