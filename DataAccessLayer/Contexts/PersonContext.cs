using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class PersonContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-23LHLCO\\SQLEXPRESS;database=DbPersons;integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<Persons> Person { get; set; } 
    }
}
