using Microsoft.EntityFrameworkCore;
using Service_Center_Management_System.Data.Entities;

namespace Service_Center_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BodyType> BodyTypes { get; set; }
        // public DbSet<VehicleType> VehicleTypes { get; set; }
        // public DbSet<ContactInformation> Contacts { get; set; }
        // public DbSet<FileDetails> Files { get; set; }
        // public DbSet<Location> Locations { get; set; }
        // public DbSet<Manufacturer> Manufacturers { get; set; }
        // public DbSet<Engine> Engines { get; set; }
        // public DbSet<Vehicle> Vehicles { get; set; }
    }
}
