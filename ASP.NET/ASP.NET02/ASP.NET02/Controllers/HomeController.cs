using System.Diagnostics;
using ASP.NET02.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET02.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
