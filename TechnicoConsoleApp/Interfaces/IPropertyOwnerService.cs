using TechnicoConsoleApp.Models;

namespace TechnicoConsoleApp.Interfaces;

public interface IPropertyOwnerService
{
    Task<PropertyOwner> RegisterAsync(PropertyOwner propertyOwner);
    Task<PropertyOwner> GetOwnerDetailsAsync(int id);
    Task UpdateOwnerAsync(PropertyOwner propertyOwner);
    Task DeleteOwnerAsync(int id);
    Task UpdateOwnerAsync(TechnicoAPI.Models.PropertyOwner propertyOwner);
    Task UpdateOwnerAsync(TechnicoAPI.Models.PropertyOwner propertyOwner);
    Task UpdateOwnerAsync(TechnicoAPI.Models.PropertyOwner propertyOwner);
}