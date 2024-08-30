using System.ComponentModel.DataAnnotations;

namespace MocatiCar.Core.Domain.Content
{
    public class Feature
    {
        [Key]
        public Guid FeatureId { get; set; }
        public string FeatureName { get; set; }
        public string DisplayName { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }


        ICollection<CarFeature> CarFeatures { get; set; }
    }
}
