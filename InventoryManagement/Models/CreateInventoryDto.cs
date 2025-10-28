using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class CreateInventoryCmd
{
    [Required] 
    public string Name { get; set; }
    public List<DynamicFieldDto> Fields { get; set; } = new();
}

public class DynamicFieldDto
{
    [Required] 
    public string Name { get; set; }
    [Required] 
    public string Type { get; set; } // "string" | "integer" | "boolean"
}