using Microsoft.AspNetCore.Identity;
using MocatiCar.Core.Domain.Content;
using MocatiCar.Core.SeedWorks.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Identity
{
    public class AppUser : IdentityUser<Guid>
    {
        public required  string FullName { get; set; }
        public required  string? RefreshToken { get; set; }
        public required  DateTime? RefreshTokenExpiryTime { get; set; }
        public required  string? Address { get; set; }
        public required  string? Avatar { get; set; }
        public required  DateTime? Dob { get; set; }
        public required  DateTime? VipStartDate { get; set; }
        public required  DateTime? VipExpireDate { get; set; }
        public required  DateTime? LastLoginDate { get; set; }
        public required  string? Gender { get; set; }
        public required  bool Status { get; set; }
        public required  DateTime? CreatedAt { get; set; }
        public required  DateTime? UpdatedAt { get; set; }
        public required  Guid? CreatedBy { get; set; }
        public required  Guid? UpdatedBy { get; set; }

        public ICollection<Car> Cars { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Address> Addresses { get; set; }
        [InverseProperty(nameof(Rental.Customer))]
        public ICollection<Rental> CustomerRentals { get; set; }
        [InverseProperty(nameof(Rental.Owner))]
        public ICollection<Rental> OwnerRentals { get; set; }

        public ICollection<FavoriteCar> FavoriteCars { get; set; }
        public DrivingLicense DrivingLicenses { get; set; }
        public ICollection<Rental> Rentals { get; set; }

        public CitizenId CitizenId { get; set; } //one to ones

    }
}
