using System.ComponentModel.DataAnnotations;

namespace MocatiCar.Core.Domain.Content
{
    public class Brand
    {
        [Key]
        public Guid BrandId { get; set; }
        public string BrandName { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        public ICollection<Model> Models { get; set; }

    }
}
