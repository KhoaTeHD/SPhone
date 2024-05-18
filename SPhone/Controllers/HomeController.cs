using Microsoft.AspNetCore.Mvc;
using SPhone.Models;
using System.Diagnostics;

namespace SPhone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [Route("lovedproduct")]
        public IActionResult LovedProduct()
        {
            return View();
        }

        [Route("phoneshop")]
        public IActionResult PhoneShop()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}