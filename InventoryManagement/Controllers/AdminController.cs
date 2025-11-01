using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers;

public class AdminController : Controller
{
    // GET
    
    private readonly AppDbContext _context;

    public AdminController(AppDbContext context)
    {
        _context = context;
    }
    
    
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetAllUsers()
    {
        var users = await _context.Users
            .AsNoTracking()
            .ToListAsync();
        return Ok(users);

    }

    // [HttpPut]
    // public async Task<ActionResult<User>> UpdateAdminStatus(User user)
    // {
    //     
    // }
    //
    // [HttpPut]
    // public async Task<ActionResult<User>> UpdateUserStatus(User user)
    // {
    //     
    // }
    //
    // [HttpDelete]
    // public async Task<ActionResult<User>> DeleteUser(User user)
    // {
    //     
    // }
    //
    
}