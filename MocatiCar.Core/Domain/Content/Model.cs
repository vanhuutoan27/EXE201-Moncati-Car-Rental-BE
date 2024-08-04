using System.ComponentModel.DataAnnotations;

namespace MocatiCar.Core.Domain.Content
{
    public class Model
    {
        [Key]
        public Guid ModelId { get; set; }

        public string ModelName { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }


        public ICollection<Car> Cars { get; set; }
    }
}
