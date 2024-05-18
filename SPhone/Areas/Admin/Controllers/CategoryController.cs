using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPhone.Models;

namespace SPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private SPhoneContext context = new SPhoneContext();
        public ActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();

            return View(categories);
        }
    }
}
