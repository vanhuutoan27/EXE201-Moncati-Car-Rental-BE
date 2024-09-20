using System.Text.Json.Serialization;

namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateReviewRequest
    {
        public Guid RentalId { get; set; }
        [JsonPropertyName("car")]
        public Guid CarId { get; set; }
        public Guid Author { get; set; }
        public int Rating { get; set; }
        public string? Content { get; set; }
    }
}
