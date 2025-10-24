using InventoryManagement.Data;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;

public class PersonalController:Controller
{
    private readonly AppDbContext _context;
    public PersonalController(AppDbContext context)
    {
        
        _context = context;
    }
    
    //TODO, MOST IMPORTANT WORK ON HOME PAGE > PERSONAL PAGE FIRST > WORK ON INVENTORY PAGE > WORK ON ITEMS PAGE
}