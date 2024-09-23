using MocatiCar.Core.Domain.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Content
{
    public class Review
    {
        [Key]
        public Guid ReviewId { get; set; }
        public Guid? CarId { get; set; }
        public Guid? Author { get; set; }
        public int Rating { get; set; }
        public string? Content { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public bool Flag { get; set; }

        [ForeignKey(nameof(Author))]
        public AppUser User { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }
        public Guid RentalId { get; set; }
        [ForeignKey("RentalId")]
        public Rental Rental { get; set; }
    }
}
