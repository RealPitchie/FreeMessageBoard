﻿using Microsoft.AspNetCore.Identity;

namespace FMB.Core.Data.Data
{
    public class AppUser : IdentityUser<long>
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpirationTime { get; set; }
    }
}
