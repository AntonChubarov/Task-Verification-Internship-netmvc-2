using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataLayer.Models
{
    public class PosgreContext : DbContext
    {
        public DbSet<Material> Materials { get; set; }
        public DbSet<Directory> Directories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Directory>(entity =>
            {
                entity.HasMany(e => e.Materials)
                .WithOne(e => e.Directory)
                .HasForeignKey(p => p.DirectoryId);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=testdb;Username=postgres;Password=Cc030789");
        }
    }
}
