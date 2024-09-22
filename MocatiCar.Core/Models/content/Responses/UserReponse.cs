﻿namespace MocatiCar.Core.Models.content.Responses
{
    public class UserReponse
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        /*        public DateTime? VipStartDate { get; set; }
                public DateTime? VipExpireDate { get; set; }*/
        public string? Gender { get; set; }
        public bool Status { get; set; }
        public bool CitizenId  {get ;set;}
        public bool DrivingLicense  { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Role { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}

