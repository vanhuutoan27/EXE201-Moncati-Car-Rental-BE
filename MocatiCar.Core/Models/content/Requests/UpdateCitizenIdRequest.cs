using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MocatiCar.Core.SeedWorks.Enums;

namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateCitizenIdRequest
    {
        public string IdNumber { get; set; }
        public DateTime Dob { get; set; }
        public Gender Gender { get; set; }
        public string Nationality { get; set; }
        public string Address { get; set; }
        public DateTime IssueDate { get; set; }
        public string IssuingAuthority { get; set; }
    }
}