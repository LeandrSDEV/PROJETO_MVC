using Microsoft.AspNetCore.Mvc;
using Project_01.Models;
using System.Diagnostics;

namespace Project_01.Controllers
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
