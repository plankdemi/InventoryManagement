using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models;

public class FullInventory
{
    
    [Required]
    public Guid UserId {get;set;}
    [Required]
    public string InventoryId { get; set; } = Guid.NewGuid().ToString();
    
    [Required, MaxLength(50)]
    public string title {get;set;}
    [MaxLength(255)]
    public string description {get;set;}
    public string imageUrl {get;set;}

    public bool isPublic { get; set; } = false;
    
    
    public bool customSingleStringState1 { get; set; } = false;
    public bool customSingleStringState2 { get; set; } = false;
    public bool customSingleStringState3 { get; set; } = false;
    public string customSingleStringName1{get;set;} 
    public string customSingleStringName2{get;set;}
    public string customSingleStringName3{get;set;}
    
    public bool customMultStringState1 { get; set; } = false;
    public bool customMultiStringState2 { get; set; } = false;
    public bool customMultiStringState3 { get; set; } = false;
    public string customMultiStringName1{get;set;} 
    public string customMultiStringName2{get;set;}
    public string customMultiStringName3{get;set;}
    
    
    
    public bool customIntState1 { get; set; } = false;
    public bool customIntState2 { get; set; } = false;
    public bool customIntState3 { get; set; } = false;
    public string customIntName1 {get;set;}
    public string customIntName2 {get;set;}
    public string customIntName3 {get;set;}
    
    
    public bool customBoolState1 { get; set; } = false;
    public bool customBoolState2 { get; set; } = false;
    public bool customBoolState3 { get; set; } = false;
    public bool customBoolName1 { get; set; } = false;
    public bool customBoolName2 { get; set; } = false;
    public bool customBoolName3 { get; set; } = false;
    
    public bool customLinkState1 { get; set; } = false;
    public bool customLinkState2 { get; set; } = false;
    public bool customLinkState3 { get; set; } = false;
    public string customLinkName1{get;set;}
    public string customLinkName2{get;set;}
    public string customLinkName3{get;set;}

    [Required]
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}