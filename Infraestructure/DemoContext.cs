using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class DemoContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                "Database=CodigoCapasDB; Integrated Security=True;" +
                "Trust Server Certificate=True ");
        }
    }
}
