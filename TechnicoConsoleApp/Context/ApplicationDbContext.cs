using Microsoft.EntityFrameworkCore;
using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Context;

// ApplicationDbContext.cs
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<PropertyOwner> PropertyOwners { get; set; }
    public DbSet<PropertyItem> PropertyItems { get; set; }
    public DbSet<Repair> Repairs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PropertyOwner>()
            .HasMany(p => p.Properties)
            .WithOne(p => p.PropertyOwner)
            .HasForeignKey(p => p.PropertyOwnerId);

        modelBuilder.Entity<PropertyItem>()
            .HasMany(p => p.Repairs)
            .WithOne(r => r.PropertyItem)
            .HasForeignKey(r => r.PropertyItemId);
    }
}