using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Craft_U.Models;

namespace Craft_U.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
   
}
