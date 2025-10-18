using InventoryManagement.Models;
using InventoryManagement.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Controllers
{
    [AllowAnonymous]
    public class RegisterController : Controller
    {
        private readonly AppDbContext _context;

        public RegisterController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([FromForm] User user)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { message = "Invalid form data." });

            var existingUser = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == user.Username);

            if (existingUser != null)
                return Conflict(new { message = "This email is already registered." });

            user.CreatedAt = DateTime.UtcNow;
            _context.Users.Add(user);

            try
            {
                await _context.SaveChangesAsync();
                return Ok(new { message = "Registration successful!" });
            }
            catch (DbUpdateException)
            {
                return StatusCode(500, new { message = "An error occurred while saving. Please try again." });
            }
        }
    }
}