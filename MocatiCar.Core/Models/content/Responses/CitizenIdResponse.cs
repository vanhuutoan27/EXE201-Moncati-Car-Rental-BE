using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Responses
{
    public class CitizenIdResponse
    {
        public Guid CitizenId { get; set; }
        public string IdNumber { get; set; }
        public string FullName { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuingAuthority { get; set; }
        public bool Verified { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
