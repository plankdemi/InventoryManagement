using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;

public class AdminController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}