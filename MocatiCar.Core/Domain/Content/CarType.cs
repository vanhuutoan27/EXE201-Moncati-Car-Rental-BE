using System.ComponentModel.DataAnnotations;

namespace MocatiCar.Core.Domain.Content
{
    public class CarType
    {
        [Key]
        public Guid CarTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }

        public ICollection<Car> Cars { get; set; }
    }
}
