namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateFeatureRequest
    {
        public string FeatureName { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
    }
}
