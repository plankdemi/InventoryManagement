using Microsoft.AspNetCore.Mvc;
using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers;

[Authorize]
public class AdminController : Controller
{
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

    [HttpPut]
    public async Task<IActionResult> UpdateAdminStatus(int id, string cmd)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(user=> user.Id == id);
        if(user == null) return NotFound("User not found");
        
        switch (cmd)
        {
            case "RM_ADMIN":
                user.IsAdmin = false;
                await _context.SaveChangesAsync();
                return Ok("User is no longer an admin");
            case "ADD_ADMIN":
                user.IsAdmin = true;
                await _context.SaveChangesAsync();
                return Ok("User is now admin");
        }

        return BadRequest();
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateUserStatus(int id, string cmd)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(user => user.Id == id);
        if (user == null) return NotFound("User not found");
        
        switch (cmd)
        {
            case "BLOCK":
                user.UserStatus = UserStatus.Blocked;
                await _context.SaveChangesAsync();
                return Ok("User Blocked");
            case "UNBLOCK":
                if(user.UserStatus != UserStatus.Blocked) return BadRequest("User Not Blocked");
                user.UserStatus = UserStatus.Unverified;
                await _context.SaveChangesAsync();
                return Ok("User Unblocked");
        }

        return BadRequest();
    }
    
    [HttpDelete]
    public async Task<IActionResult> DeleteUser(int id)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(user => user.Id == id);
        if (user == null) return NotFound("User not found");
         
        _context.Users.Remove(user);
        await _context.SaveChangesAsync();
        return Ok("User deleted");

    }
    
    
}