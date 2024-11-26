using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Interfaces;

public interface IPropertyItemService
{
    Task<IEnumerable<PropertyItem>> GetAllPropertiesAsync();
    Task<PropertyItem> GetPropertyDetailsAsync(int id);
    Task<PropertyItem> CreatePropertyAsync(PropertyItem propertyItem);
    Task UpdatePropertyAsync(PropertyItem propertyItem);
    Task DeletePropertyAsync(int id);
}