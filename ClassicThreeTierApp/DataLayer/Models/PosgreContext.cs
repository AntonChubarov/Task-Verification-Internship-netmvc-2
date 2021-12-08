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
            string host = "ec2-34-254-120-2.eu-west-1.compute.amazonaws.com";
            string database = "d310f9vgu4t52t";
            string user = "rppeqibaqtiqvz";
            string port = "5432";
            string password = "a6ab082300485ee445c201b6ccbcc48d9b12ed544cf75b98035e203b178de692";
            optionsBuilder.UseNpgsql($"Host={host};Port={port};Database={database};Username={user};Password={password};SslMode=Require;Trust Server Certificate=true");
        }
    }
}
