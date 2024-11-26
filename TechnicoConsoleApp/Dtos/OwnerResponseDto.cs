namespace TechnicoAPI.Dtos;

public class ResponseAPI<T>
{
    public int StatusCode { get; set; }
    public string Description { get; set; } = string.Empty;
    public T? Value { get; set; }
}

public class PropertyOwnerRequestDto
{
    public string VATNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty;
    public int Id { get; set; }
}

public class PropertyOwnerResponseDto
{
    public int Id { get; set; }
    public string VATNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string UserType { get; set; } = string.Empty;
    public ICollection<PropertyItemResponseDto>? Properties { get; set; }
}

public class PropertyItemRequestDto
{
    public string PropertyIdentificationNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int YearOfConstruction { get; set; }
    public string VATNumber { get; set; } = string.Empty;
    public int PropertyOwnerId { get; set; }
    public int Id { get; set; }
}

public class PropertyItemResponseDto
{
    public int Id { get; set; }
    public string PropertyIdentificationNumber { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public int YearOfConstruction { get; set; }
    public string VATNumber { get; set; } = string.Empty;
    public int PropertyOwnerId { get; set; }
    public PropertyOwnerResponseDto? PropertyOwner { get; set; }
    public ICollection<RepairResponseDto>? Repairs { get; set; }
}

public class RepairRequestDto
{
    public DateTime Date { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public int PropertyItemId { get; set; }
    public int Id { get; set; }
}

public class RepairResponseDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public decimal Cost { get; set; }
    public int PropertyItemId { get; set; }
    public PropertyItemResponseDto? PropertyItem { get; set; }
}