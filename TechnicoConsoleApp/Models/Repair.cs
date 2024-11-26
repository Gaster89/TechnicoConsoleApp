namespace TechnicoConsoleApp.Models;

internal class Repair
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public string Address { get; set; }
    public string Status { get; set; }
    public decimal Cost { get; set; }
    public int PropertyItemId { get; set; }
    public PropertyItem PropertyItem { get; set; }
}