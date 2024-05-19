using Microsoft.AspNetCore.Mvc;

namespace SPhone.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
