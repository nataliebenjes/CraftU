using Microsoft.AspNetCore.Mvc;

namespace CraftU.Controllers;

public class HomeController : Controller
{
    [HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
}
