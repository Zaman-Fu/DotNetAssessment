
using DotNetAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetAssessment.Data
{
    public class DataContext : DbContext { 
       
        public DataContext()
        {
        }
    
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Owner> Owners { get; internal set; }
        public DbSet<Vehicle> Vehicles { get; internal set; }
        public DbSet<Claim> Claims { get; internal set; }
    }
}
