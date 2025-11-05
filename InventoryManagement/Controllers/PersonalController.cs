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

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FullInventory>>> GetPersonalInventory()
    {
        
        var value = User.FindFirstValue("UserId"); 
        if (!Guid.TryParse(value, out var userId))
            throw new UnauthorizedAccessException("Invalid or missing UserId claim.");
        
        var user = await _context.Users.AsNoTracking().FirstOrDefaultAsync(u=> u.Id == userId);
        if(user is null) return NotFound("User not found");


        var inventories = await _context.FullInventories
            .AsNoTracking()
            .Where(i => i.UserId == user.Id)
            .ToListAsync();
        return Ok(inventories);

    }
    
    

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateNewInventory([FromForm] FullInventory fullInventory)
    {
        
        var value = User.FindFirstValue("UserId"); 
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
        
        var user = await _context.Users.FirstOrDefaultAsync(x => x.Id == userId);
        if(user is null) return NotFound("User not found");
        user.InventoriesCreated += 1;
        
        try
        {
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }catch (DbUpdateException){
             return RedirectToAction(nameof(Index));
        }
    }

   
}