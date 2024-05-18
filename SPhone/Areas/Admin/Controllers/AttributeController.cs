using Microsoft.AspNetCore.Mvc;
using SPhone.Models;

namespace SPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AttributeController : Controller
    {
        private SPhoneContext context = new SPhoneContext();
        public IActionResult Index()
        {
            List<Variation> Variations = context.Variations.ToList();

            return View(Variations);
        }
    }
}
