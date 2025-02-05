﻿namespace TechnicoConsoleApp.Models;

public class PropertyOwner
{
    public int Id { get; set; }
    public string VATNumber { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string UserType { get; set; }
    public ICollection<PropertyItem> Properties { get; set; }
}