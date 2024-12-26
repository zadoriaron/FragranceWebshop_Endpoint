using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FragranceWebshop_Entities.Entity_Models;
using Microsoft.EntityFrameworkCore;

namespace FragranceWebshop_Data
{
    public class FragranceWebshopDbContext: DbContext
    {
        public DbSet<Perfum> perfums { get; set; }
        public DbSet<Purchase> purchases { get; set; }

        public FragranceWebshopDbContext(DbContextOptions<FragranceWebshopDbContext> ctx): base(ctx)
        {
            Database.EnsureCreated();
        }

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Perfum>()
                .HasMany(p => p.Purchases)
                .WithOne(e => e.PurchasedPerfum)
                .HasForeignKey(e => e.PerfumId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

    }
}
