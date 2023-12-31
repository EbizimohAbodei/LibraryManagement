﻿namespace WebApi.Business.src.Configuration;

public class JwtConfig
{
    public string JwtKey { get; set; } = null!;
    public string JwtIssuer { get; set; } = null!;
    public string JwtAudience { get; set; } = null!;
    public double JwtExpireMinutes { get; set; }
}
