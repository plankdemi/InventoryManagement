using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class Inventory
{
    [Required]
    public int UserId {get;set;}
    [Required]
    public string InventoryId { get; set; }

    public int NumofItems { get; set; } = 0;
    
    [Required] 
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}