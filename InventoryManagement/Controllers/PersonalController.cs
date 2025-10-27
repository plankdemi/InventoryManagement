using InventoryManagement.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;

[Authorize]
public class PersonalController:Controller
{
    private readonly AppDbContext _context;
    public PersonalController(AppDbContext context)
    {
        
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost, FromForm]
    public IActionResult CreateNewInventory()
    {
        
        
    }
    
    //TODO, MOST IMPORTANT WORK ON HOME PAGE > PERSONAL PAGE FIRST > WORK ON INVENTORY PAGE > WORK ON ITEMS PAGE
}