namespace MocatiCar.Core.Models.content.Requests
{
    public class ReviewDto
    {
        public Guid Author { get; set; }   // The author of the review
        public int Rating { get; set; }      // The rating given by the author
        public string Content { get; set; }
    }
}