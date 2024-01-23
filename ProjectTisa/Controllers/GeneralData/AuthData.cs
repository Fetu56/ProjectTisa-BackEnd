﻿namespace ProjectTisa.Controllers.GeneralData
{
    public record AuthData
    {
        public required string Issuer { get; init; }
        public required string Audience { get; init; }
        public required string IssuerSigningKey { get; init; }
        public required TimeSpan ExpirationTime { get; set; }
        public required int IterationCount { get; set; }
        public required int SaltSize { get; set; }
    };
}
