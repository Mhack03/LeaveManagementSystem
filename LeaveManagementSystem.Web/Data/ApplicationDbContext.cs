using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "db046d61-6c8f-4b1b-97f3-bbdf610444f8",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                },

                new IdentityRole
                {
                    Id = "ba546c2c-f506-463d-976d-cfa6f6d6383d",
                    Name = "Supervisor",
                    NormalizedName = "SUPERVISOR",
                },

                new IdentityRole
                {
                    Id = "69593294-da2a-411d-ab51-b2a2039ea8ed",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                }
            );
            var hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "28cb7da6-8e79-4467-a2bc-f30fad495996",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true

                });

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> 
                { 
                    RoleId = "69593294-da2a-411d-ab51-b2a2039ea8ed",
                    UserId = "28cb7da6-8e79-4467-a2bc-f30fad495996"
                } );
        }
        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
