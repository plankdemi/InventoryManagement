using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

  

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }
    
    //TODO ADD INVENTORIES SORTED BY CREATEDATE
    //TODO ADD INVENTORIES SORTED BY NUM OF ITEMS IN INVENTORY
    //TODO ALL ALL TAGS

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Inventory>>> GetAllInventorySortByNewest()
    {
        var inventories = await _context.Inventories
            .AsNoTracking()
            .OrderByDescending(i=>i.CreatedAt)
            .ToListAsync();
        return Ok(inventories);
    }
        
    [HttpGet]    
    public async Task<ActionResult<IEnumerable<Inventory>>> GetAllInventorySortByPopularity()
    {
        var inventories = await _context.Inventories
            .AsNoTracking()
            .OrderByDescending(i=>i.NumofItems)
            .ToListAsync();
        return Ok(inventories);
    }  
 

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}