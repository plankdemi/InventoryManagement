using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

    // [HttpPost, ValidateAntiForgeryToken]
    // public async Task<IActionResult> CreateNewInventory([FromForm] FullInventory fullInventory)
    // {
    //     if (!ModelState.IsValid)
    //         return BadRequest(new { message = "Invalid form data." });
    //     
    //     var existingInventory = await _context.FullInventories
    //         .AsNoTracking()
    //         .FirstOrDefaultAsync(i => i.InventoryId == fullInventory.InventoryId);
    //         
    //     
    // }
    
    //TODO, MOST IMPORTANT WORK ON HOME PAGE > PERSONAL PAGE FIRST > WORK ON INVENTORY PAGE > WORK ON ITEMS PAGE
}