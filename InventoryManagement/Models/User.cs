using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace InventoryManagement.Models;

public enum UserStatus
{
    Unverified,
    Verified,
    Blocked
}

public class User
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required] 
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    [Required, MaxLength(100)] 
    public string Username { get; set; }
    public string AuthProvider { get; set; } = "Local";

    [Required, PasswordPropertyText, MaxLength(100)]
    public string Password { get; set; }


    public bool IsAdmin { get; set; } = false;


    public int InventoriesCreated { get; set; } = 0;
    
    public UserStatus UserStatus { get; set; } = UserStatus.Unverified;



}
