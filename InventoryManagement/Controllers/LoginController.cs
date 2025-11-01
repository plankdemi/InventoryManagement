using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using InventoryManagement.Data;
using Microsoft.AspNetCore.Authentication.Facebook;

namespace InventoryManagement.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GoogleLogin()
        {
            var redirectUrl = Url.Action(nameof(GoogleResponse), "Login");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, GoogleDefaults.AuthenticationScheme);
        }

        [HttpGet]
        public async Task<IActionResult> GoogleResponse()
        {
            var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
            if (result?.Principal == null)
                return RedirectToAction("Index", "Home");

            var email = result.Principal.FindFirstValue(ClaimTypes.Email);
            

            var user = await GetOrCreateUserAsync(email, "Google");

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("UserId", user.Id.ToString()),
                new Claim("isAdmin", user.IsAdmin.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

            return RedirectToAction("Index", "Home");
        }

        
        
        [HttpGet]
        public IActionResult FacebookLogin()
        {
            var redirectUrl = Url.Action(nameof(FacebookResponse), "Login");
            var properties = new AuthenticationProperties { RedirectUri = redirectUrl };
            return Challenge(properties, FacebookDefaults.AuthenticationScheme);
        }

        [HttpGet]
        public async Task<IActionResult> FacebookResponse()
        {
            var result = await HttpContext.AuthenticateAsync(FacebookDefaults.AuthenticationScheme);
            if (result?.Principal == null)
                return RedirectToAction("Index", "Home");

            var email = result.Principal.FindFirstValue(ClaimTypes.Email);
            

            if (string.IsNullOrEmpty(email))
            {
                
                return BadRequest("Facebook account did not provide an email address.");
            }

            var user = await GetOrCreateUserAsync(email, "Facebook");

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("UserId", user.Id.ToString()),
                new Claim("isAdmin", user.IsAdmin.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

            return RedirectToAction("Index", "Home");
        }

        private async Task<Models.User> GetOrCreateUserAsync(string email, string oAuthProvider)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == email);
            if (user == null)
            {
                user = new Models.User
                {
                    Username = email,
                    Password = "",
                    AuthProvider = oAuthProvider,
                    CreatedAt = DateTime.UtcNow
                };
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
            }
            return user;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([FromForm] string userName, [FromForm] string password, [FromForm] bool rememberMe)
        {
            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
                return BadRequest(new { message = "Username and password are required." });

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == userName && u.AuthProvider == "Local");
            if (user == null || user.Password != password)
                return Unauthorized(new { message = "Invalid username or password." });

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim("UserId", user.Id.ToString()),
                new Claim("isAdmin", user.IsAdmin.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties { IsPersistent = rememberMe };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), authProperties);
            return Ok(new { message = "Login successful!" });
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }
    }
}
