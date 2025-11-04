using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models;

public class FullInventory
{
    
    [Required]
    public Guid UserId {get;set;}
    [Required]
    
    [MaxLength(256)]
    public string InventoryId { get; set; } = Guid.NewGuid().ToString();
    
    [Required, MaxLength(50)]
    public string Title {get;set;}
    [MaxLength(255)]
    public string? Description {get;set;}
    [MaxLength(255)]
    public string? ImageUrl {get;set;}

    public bool IsPublic { get; set; } = false;
    
    
    public bool CustomSingleStringState1 { get; set; } = false;
    public bool CustomSingleStringState2 { get; set; } = false;
    public bool CustomSingleStringState3 { get; set; } = false;
    [MaxLength(100)]
    public string? CustomSingleStringName1 { get; set; }
    [MaxLength(100)]
    public string? CustomSingleStringName2{get;set;}
    [MaxLength(100)]
    public string? CustomSingleStringName3{get;set;}
    
    [MaxLength(100)]
    public string? CustomSingleStringValue1{get;set;}
    [MaxLength(100)]
    public string? CustomSingleStringValue2{get;set;}
    [MaxLength(100)]
    public string? CustomSingleStringValue3{get;set;}
    
    
    
    
    public bool CustomMultStringState1 { get; set; } = false;
    public bool CustomMultiStringState2 { get; set; } = false;
    public bool CustomMultiStringState3 { get; set; } = false;
    [MaxLength(100)]
    public string? CustomMultiStringName1{get;set;} 
    [MaxLength(100)]
    public string? CustomMultiStringName2{get;set;}
    [MaxLength(100)]
    public string? CustomMultiStringName3{get;set;}
    
    [MaxLength(100)]
    public string? CustomMultiStringValue1{get;set;}
    [MaxLength(100)]
    public string? CustomMultiStringValue2{get;set;}
    [MaxLength(100)]
    public string? CustomMultiStringValue3{get;set;}
    
    public bool CustomIntState1 { get; set; } = false;
    public bool CustomIntState2 { get; set; } = false;
    public bool CustomIntState3 { get; set; } = false;
    [MaxLength(100)]
    public string? CustomIntName1 {get;set;}
    [MaxLength(100)]
    public string? CustomIntName2 {get;set;}
    [MaxLength(100)]
    public string? CustomIntName3 {get;set;}
    
    [MaxLength(100)]
    public int? CustomIntValue1{get;set;}
    [MaxLength(100)]
    public int? CustomIntValue2{get;set;}
    [MaxLength(100)]
    public int? CustomIntValue3{get;set;}
    
    
    public bool CustomBoolState1 { get; set; } = false;
    public bool CustomBoolState2 { get; set; } = false;
    public bool CustomBoolState3 { get; set; } = false;
    [MaxLength(100)]
    public string? CustomBoolName1 { get; set; }
    [MaxLength(100)]
    public string? CustomBoolName2 { get; set; }
    [MaxLength(100)]
    public string? CustomBoolName3 { get; set; }
    
    public bool CustomBoolValue1 { get; set; } = false;
    public bool CustomBoolValue2 { get; set; } = false;
    public bool CustomBoolValue3 { get; set; } = false;
    
    public bool CustomLinkState1 { get; set; } = false;
    public bool CustomLinkState2 { get; set; } = false;
    public bool CustomLinkState3 { get; set; } = false;
    [MaxLength(100)]
    public string? CustomLinkName1{get;set;}
    [MaxLength(100)]
    public string? CustomLinkName2{get;set;}
    [MaxLength(100)]
    public string? CustomLinkName3{get;set;}
    
    public bool CustomLinkValue1 { get; set; }
    public bool CustomLinkValue2 { get; set; } 
    public bool CustomLinkValue3 { get; set; } 
    
    

    [Required]
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
}