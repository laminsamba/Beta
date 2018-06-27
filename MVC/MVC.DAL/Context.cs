
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace MVC.DAL
{
    public class Context : IdentityDbContext
    {

        public Context() : base("DefaultConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("user");
        //    modelBuilder.Entity<ApplicationUser>().ToTable("user");

            modelBuilder.Entity<IdentityRole>().ToTable("role");
            modelBuilder.Entity<IdentityUserRole>().ToTable("userrole");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("userclaim");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("userlogin");
        }
    }
}
