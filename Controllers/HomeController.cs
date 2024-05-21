using Microsoft.AspNetCore.Mvc;

namespace MVCAuth.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}