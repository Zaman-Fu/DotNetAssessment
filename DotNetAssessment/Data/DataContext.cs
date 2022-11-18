
using DotNetAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetAssessment.Data
{
    public class DataContext : DbContext { 
       
    
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Owner> Owners { get; internal set; }
        public DbSet<Vehicle> Vehicles { get; internal set; }
        public DbSet<Claim> Claims { get; internal set; }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>()
                .HasOne<Owner>()
                .WithMany()
                .HasForeignKey(p => p.OwnerId);

            modelBuilder.Entity<Claim>()
                .HasOne<Vehicle>()
                .WithMany()
                .HasForeignKey(p => p.VehicleId);
        }
    }
}
