using System.ComponentModel.DataAnnotations;

namespace MocatiCar.Core.Domain.Content
{
    public class Feature
    {
        [Key]
        public Guid FeatureId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }


        ICollection<CarFeature> CarFeatures { get; set; }
    }
}
