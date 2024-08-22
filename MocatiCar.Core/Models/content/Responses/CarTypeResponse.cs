namespace MocatiCar.Core.Models.content.Responses
{
    public class CarTypeResponse
    {
        public Guid CarTypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }= DateTime.Now;
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
    }
}
