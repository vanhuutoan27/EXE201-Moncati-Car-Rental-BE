﻿namespace MocatiCar.Core.Models.auth
{
    public class TokenRequest
    {
        public required string AccessToken { get; set; }
        public required string RefreshToken { get; set; }
    }
}
