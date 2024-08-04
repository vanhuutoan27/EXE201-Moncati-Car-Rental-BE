using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MocatiCar.Core.Domain.Content
{
    public class CarFeature
    {
        [Key]
        public Guid CarFeatureId { get; set; }

        public Guid CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car Car { get; set; }

        public Guid FeatureId { get; set; }
        [ForeignKey(nameof(FeatureId))]
        public Feature Feature { get; set; }


    }
}
