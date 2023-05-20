﻿using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Models.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string ? ProfilePicture { get; set; }
    }
}
