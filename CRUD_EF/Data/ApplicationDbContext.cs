using CRUD_EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_EF.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=crud_EF;Trusted_Connection=True;TrustServerCertificate=True");
        }
       public DbSet <Product> Products { get; set; }
       public DbSet <Order>  Orders { get; set; }

    }
}
