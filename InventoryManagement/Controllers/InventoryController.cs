using InventoryManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers;

public class InventoryController : Controller
{
    private readonly AppDbContext _context;
    
    public InventoryController(AppDbContext context)
    {
        _context = context;
    }
    // GET
    public IActionResult Index(string id)
    {
        return View();
    }

    [HttpGet]
    public async Task<ActionResult<bool>> GetIsInventoryPublicState(string id)
    {
        var state = await _context.FullInventories
            .AsNoTracking()
            .Where(i => i.InventoryId == id)
            .Select(i => i.IsPublic)
            .FirstOrDefaultAsync();

        return Ok(state);

    }

    [HttpPut]
    public async Task<IActionResult> UpdateInventoryPublicState(string id, bool isPublic)
    {
        var inventory = await _context.FullInventories
            .FirstOrDefaultAsync(i=> i.InventoryId == id);
        if(inventory is null) return NotFound();
        inventory.IsPublic = isPublic;
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpPut]
    public async Task<IActionResult> UpdateCustomId(string id, string customId)
    {
        var inventory = await _context.FullInventories
            .FirstOrDefaultAsync(i=> i.InventoryId == id);
        if(inventory is null) return NotFound();
        inventory.InventoryCustomId = customId;
        await _context.SaveChangesAsync();
        return Ok();
    }
}