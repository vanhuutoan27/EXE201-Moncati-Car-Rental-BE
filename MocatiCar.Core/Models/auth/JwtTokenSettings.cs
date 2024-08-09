namespace MocatiCar.Core.Models.auth
{
    public class JwtTokenSettings
    {
        public string Key { get; set; }
        public string Issuer { get; set; }
        public int ExpireInHours { get; set; }
    }
}
