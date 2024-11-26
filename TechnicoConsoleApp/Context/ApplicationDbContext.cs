using Microsoft.EntityFrameworkCore;
using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<PropertyOwner> PropertyOwners { get; set; }
    public DbSet<PropertyItem> PropertyItems { get; set; }
    public DbSet<Repair> Repairs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Set up your connection string and other configuration here
        optionsBuilder.UseSqlServer(
            "Server = localhost\\\\SQLEXPRESS; Database = TechnicoDB; Trusted_Connection = True; TrustServerCertificate = True;");

        // Enable sensitive data logging (only in development)
        optionsBuilder.EnableSensitiveDataLogging();

        // Additional configurations as needed
    }
}