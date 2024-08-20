namespace MocatiCar.Core.Models.content.Requests
{
    public class CreateUpdateUserRequest
    {
        public string FullName { get; set; }
        public string? Address { get; set; }
        public string? Avatar { get; set; }

        public string? Gender { get; set; }

        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }




    }
}
