using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models;

public class FullInventory
{
    
    [Required]
    public string InventoryId { get; set; }
    
    [Required]
    public string title {get;set;}
    public string description {get;set;}
    public string imageUrl {get;set;}

    public bool isPublic { get; set; } = false;
    
    
    public bool customSingleStringState1 { get; set; } = false;
    public bool customSingleStringState2 { get; set; } = false;
    public bool customSingleStringState3 { get; set; } = false;
    public string customSingleString1Name{get;set;} 
    public string customSingleString2Name{get;set;}
    public string customSingleString3Name{get;set;}
    
    public bool customMultStringState1 { get; set; } = false;
    public bool customMultiStringState2 { get; set; } = false;
    public bool customMultiStringState3 { get; set; } = false;
    public string customMultiString1Name{get;set;} 
    public string customMultiString2Name{get;set;}
    public string customMultiString3Name{get;set;}
    
    
    
    public bool customIntState1 { get; set; } = false;
    public bool customIntState2 { get; set; } = false;
    public bool customIntState3 { get; set; } = false;
    public string customInt1Name{get;set;}
    public string customInt2Name{get;set;}
    public string customInt3Name{get;set;}
    
    
    public bool customBoolState1 { get; set; } = false;
    public bool customBoolState2 { get; set; } = false;
    public bool customBoolState3 { get; set; } = false;
    public bool customBool1Name { get; set; } = false;
    public bool customBool2Name { get; set; } = false;
    public bool customBool3Name { get; set; } = false;
    
    public bool customLinkState1 { get; set; } = false;
    public bool customLinkState2 { get; set; } = false;
    public bool customLinkState3 { get; set; } = false;
    
    public string customLink1Name{get;set;}
    public string customLink2Name{get;set;}
    public string customLink3Name{get;set;}


}