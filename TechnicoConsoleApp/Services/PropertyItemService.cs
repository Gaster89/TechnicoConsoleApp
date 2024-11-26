using Microsoft.EntityFrameworkCore;
using TechnicoConsoleApp.Context;
using TechnicoConsoleApp.Interfaces;
using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Services;

public class PropertyItemService : IPropertyItemService
{
    private readonly ApplicationDbContext _context;

    public PropertyItemService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<PropertyItem>> GetAllPropertiesAsync()
    {
        return await _context.PropertyItems.Include(p => p.PropertyOwner).ToListAsync();
    }

    public async Task<PropertyItem> GetPropertyDetailsAsync(int id)
    {
        return await _context.PropertyItems.Include(p => p.PropertyOwner).FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<PropertyItem> CreatePropertyAsync(PropertyItem propertyItem)
    {
        _context.PropertyItems.Add(propertyItem);
        await _context.SaveChangesAsync();
        return propertyItem;
    }

    public async Task UpdatePropertyAsync(PropertyItem propertyItem)
    {
        _context.PropertyItems.Update(propertyItem);
        await _context.SaveChangesAsync();
    }

    public async Task DeletePropertyAsync(int id)
    {
        PropertyItem? property = await _context.PropertyItems.FindAsync(id);
        if (property != null)
        {
            _context.PropertyItems.Remove(property);
            await _context.SaveChangesAsync();
        }
    }
}