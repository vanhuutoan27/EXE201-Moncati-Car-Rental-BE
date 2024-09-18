using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? VipStartDate { get; set; }
        public DateTime? VipExpireDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public Gender? Gender { get; set; }
        public bool Status { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public ICollection<Car> Cars { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Address> Addresses { get; set; }
        [InverseProperty(nameof(Rental.Customer))]
        public ICollection<Rental> CustomerRentals { get; set; }
        [InverseProperty(nameof(Rental.Owner))]
        public ICollection<Rental> OwnerRentals { get; set; }

        public ICollection<FavoriteCar> FavoriteCars { get; set; }
    }
}
