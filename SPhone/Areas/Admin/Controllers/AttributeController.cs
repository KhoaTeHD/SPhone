using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPhone.Areas.Admin.Views.Attribute;
using SPhone.Models;

namespace SPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AttributeController : Controller
    {
        private readonly SPhoneContext _Context;

        public AttributeController(SPhoneContext context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Variations = _Context.Variations.ToList();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Variation Input)
        {
            if (ModelState.IsValid)
            {
                _Context.Variations.Add(Input);
                _Context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Variations = _Context.Variations.ToList();

            return RedirectToAction("Index", Input);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            var variation = _Context.Variations.Find(id);

            if (variation == null)
            {
                return NotFound();
            }

            _Context.Variations.Remove(variation);
            _Context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Variation variation = _Context.Variations.Find(id);

            return View(variation);
        }

        [HttpPost]
        public ActionResult Edit(Variation variation)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var variationUpdate = _Context.Variations.Find(variation.Id);
                    if (variationUpdate == null)
                    {
                        return NotFound();
                    }

                    variationUpdate.Name = variation.Name;
                    variationUpdate.IsActive = variation.IsActive;


                    _Context.Update(variationUpdate);
                    _Context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }

            return View(variation);
        }

    }
}
