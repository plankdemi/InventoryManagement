using InventoryManagement.Data;
using InventoryManagement.Models;
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

    [HttpPost, ValidateAntiForgeryToken]
    public async Task<IActionResult> CreateNewInventory(CreateInventoryCmd cmd)
    {
        var inv = new Inventory
        {
            Name = cmd.Name?.Trim(),
            CreatedAt = DateTime.UtcNow,
            Fields = (cmd.Fields ?? new())
                .Where(f => !string.IsNullOrWhiteSpace(f.Name) && !string.IsNullOrWhiteSpace(f.Type))
                .Select(f => new InventoryField { Name = f.Name.Trim(), Type = f.Type.Trim() })
                .ToList()
        };

        _context.Inventories.Add(inv);
        await _context.SaveChangesAsync();

        return RedirectToAction("PersonalPage"); // or wherever you list inventories
        
    }
    
    //TODO, MOST IMPORTANT WORK ON HOME PAGE > PERSONAL PAGE FIRST > WORK ON INVENTORY PAGE > WORK ON ITEMS PAGE
}