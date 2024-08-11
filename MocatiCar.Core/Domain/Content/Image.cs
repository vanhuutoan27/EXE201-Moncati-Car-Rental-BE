using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Content
{
    public class Image
    {
        [Key]
        public Guid ImageId { get; set; }
        public string Url { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public Guid? CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }

        public static implicit operator string(Image v)
        {
            throw new NotImplementedException();
        }
    }
}
