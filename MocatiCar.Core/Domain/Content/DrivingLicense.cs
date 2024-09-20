using MocatiCar.Core.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MocatiCar.Core.Domain.Content
{
    public class DrivingLicense
    {
        [Key]
        public Guid DrivingLicenseId { get; set; }
        [Required(ErrorMessage = "License number is required.")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "License number must be exactly 12 characters.")]
        [RegularExpression(@"^\S{12}$")]
        public string LicenseNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool Verified { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public Guid UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public AppUser Users { get; set; }
    }
}
