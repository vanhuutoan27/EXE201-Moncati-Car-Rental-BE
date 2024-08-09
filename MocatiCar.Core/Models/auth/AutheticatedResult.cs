namespace MocatiCar.Core.Models.auth
{
    public class AutheticatedResult
    {
        public required string Token { get; set; }
        public required string RefreshToken { get; set; }
        public required DateTime? ExpiryTime { get; set; }
    }
}
