using Microsoft.AspNetCore.Mvc;

namespace SPhone.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
