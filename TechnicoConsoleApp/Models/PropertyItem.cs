namespace TechnicoConsoleApp.Models;

public class PropertyItem
{
    public int Id { get; set; }
    public string PropertyIdentificationNumber { get; set; }
    public string Address { get; set; }
    public int YearOfConstruction { get; set; }
    public string VATNumber { get; set; }
    public int PropertyOwnerId { get; set; }
    public PropertyOwner PropertyOwner { get; set; }
    public ICollection<Repair> Repairs { get; set; }
}