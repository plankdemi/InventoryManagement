using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers;

public class InventoryController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}