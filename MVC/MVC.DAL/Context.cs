using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApp.MVC.Models;

namespace MVC.DAL
{
    public class Context : IdentityDbContext
    {
        public Context() : base("DefaultConnection")
        {
        }

        static Context()
        {
            //        Database.SetInitializer<Context>(new ApplicationDbInitializer());
        }

        public static Context Create()
        {
            return new Context();
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("user");
            modelBuilder.Entity<ApplicationUser>().ToTable("user");

            modelBuilder.Entity<IdentityRole>().ToTable("role");
            modelBuilder.Entity<IdentityUserRole>().ToTable("userrole");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("userclaim");
            modelBuilder.Entity<IdentityUserLogin>().ToTable("userlogin");
        }
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
