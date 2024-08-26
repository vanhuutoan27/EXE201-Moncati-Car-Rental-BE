namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateUserRequest
    {
        public string FullName { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Role { get; set; }


    }
}
