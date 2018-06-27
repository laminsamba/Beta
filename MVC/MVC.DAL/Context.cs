using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using WebApp.MVC.Models;

namespace MVC.DAL
{
    public class Context : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Team> Teams { get; set; }  
    }

    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
