namespace MocatiCar.Core.Models.content.Requests
{
    public class UpdateUserRequest
    {
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }
        public string? Gender { get; set; }

        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Role { get; set; }


    }
}
