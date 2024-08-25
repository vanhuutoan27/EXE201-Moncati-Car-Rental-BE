namespace MocatiCar.Core.Models.auth
{
    public class RefreshTokenResult
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}
