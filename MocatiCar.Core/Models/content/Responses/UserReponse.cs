using MocatiCar.Core.Domain.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Models.content.Responses
{
    public class UserReponse
    {
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        /*        public DateTime? VipStartDate { get; set; }
                public DateTime? VipExpireDate { get; set; }*/
        public string? Gender { get; set; }

        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Role { get; set; }


    }
}

