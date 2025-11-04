using System.Security.Claims;
using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers;

[Authorize]
public class PersonalController : Controller
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

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateNewInventory([FromForm] FullInventory fullInventory)
    {
        // if (!ModelState.IsValid)
        //     return BadRequest(new { message = "Invalid form data." });

        var value = User.FindFirstValue("UserId"); // string?
        if (!Guid.TryParse(value, out var userId))
            throw new UnauthorizedAccessException("Invalid or missing UserId claim.");

        fullInventory.UserId = userId;

        fullInventory.CreatedAt = DateTime.Now;
        _context.FullInventories.Add(fullInventory);


        Inventory inventory = new Inventory
        {
            UserId = userId,
            InventoryId = fullInventory.InventoryId,
            CreatedAt = fullInventory.CreatedAt
            
        };
        _context.Inventories.Add(inventory);

        try
        {
            await _context.SaveChangesAsync();
            return Ok(new { message = "New Inventory Created" });
        }
         catch (DbUpdateException)
         {
             return StatusCode(500, new { message = "An error occurred while saving. Please try again." });
         }
    }

    //TODO, MOST IMPORTANT WORK ON HOME PAGE > PERSONAL PAGE FIRST > WORK ON INVENTORY PAGE > WORK ON ITEMS PAGE
}