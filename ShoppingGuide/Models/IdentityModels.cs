﻿using Microsoft.AspNet.Identity.EntityFramework;

namespace ShoppingGuide.Models
{
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ShoppingGuideDB")
        {
        }
    }
}