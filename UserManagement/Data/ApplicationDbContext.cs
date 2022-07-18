using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace UserManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<ApplicationUser>().ToTable("users","security");
            builder.Entity<IdentityRole>().ToTable("roles", "security");

            builder.Entity<IdentityUserRole<string>>().ToTable("userRoles", "security");
            builder.Entity<IdentityUserClaim<string>>().ToTable("userClaim", "security");
            builder.Entity<IdentityUserLogin<string>>().ToTable("userLogin", "security");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("roleClaim", "security");
            builder.Entity<IdentityUserToken<string>>().ToTable("userToken", "security");
        }
    }
}
