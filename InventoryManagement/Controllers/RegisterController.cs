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

       
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

           
            var existingUser = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Username == user.Username);

            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "This email is already registered.");
                return View(user);
            }

            user.CreatedAt = DateTime.UtcNow;
            

            _context.Users.Add(user);

            try
            {
                await _context.SaveChangesAsync();

               
                

                TempData["SuccessMessage"] = "User registered successfully! Check your email!";
                return RedirectToAction("Index", "Login");
            }
            catch (DbUpdateException ex)
            {
                
                if (ex.InnerException != null && ex.InnerException.Message.Contains("Duplicate entry"))
                {
                    ModelState.AddModelError("Email", "This email is already registered.");
                }
                else
                {
                    ModelState.AddModelError("", "An error occurred while saving. Please try again.");
                }

                return View(user); 
            }
        }


    }
}
