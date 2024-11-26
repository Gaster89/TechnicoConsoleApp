using Microsoft.EntityFrameworkCore;
using TechnicoConsoleApp.Context;
using TechnicoConsoleApp.Interfaces;
using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Services;

public class PropertyOwnerService : IPropertyOwnerService
{
    private readonly ApplicationDbContext _context;

    public PropertyOwnerService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<PropertyOwner> RegisterAsync(PropertyOwner propertyOwner)
    {
        _context.PropertyOwners.Add(propertyOwner);
        await _context.SaveChangesAsync();
        return propertyOwner;
    }

    public async Task<PropertyOwner> GetOwnerDetailsAsync(int id)
    {
        return await _context.PropertyOwners.Include(p => p.Properties).FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task UpdateOwnerAsync(PropertyOwner propertyOwner)
    {
        _context.PropertyOwners.Update(propertyOwner);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteOwnerAsync(int id)
    {
        PropertyOwner? owner = await _context.PropertyOwners.FindAsync(id);
        _context.PropertyOwners.Remove(owner);
        await _context.SaveChangesAsync();
    }
}