using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingProject.Data
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options)
          : base(options)
        {
        }

        public DbSet<Models.Cart> Carts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Cart>()
                 .HasKey(sc => new { sc.ID, sc.Product });



        }
    }
}
