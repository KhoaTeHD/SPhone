using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SPhone.Areas.Admin.Views.Category;
using SPhone.Models;

namespace SPhone.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly SPhoneContext _Context;

        public CategoryController(SPhoneContext context)
        {
            _Context = context;
        }

        public ActionResult Index()
        {
            ViewBag.Categories = _Context.Categories.ToList();

            return View();
        }

        public ActionResult Add()
        {

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category Input)
        {
            if (ModelState.IsValid)
            {
                _Context.Categories.Add(Input);
                _Context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Categories = _Context.Categories.ToList();

            return RedirectToAction("Index", Input);
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            var category = _Context.Categories.Find(id);

            if (category == null)
            {
                return NotFound();
            }

            _Context.Categories.Remove(category);
            _Context.SaveChanges();


            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Category category = _Context.Categories.Find(id);

            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var categoryUpdate = _Context.Categories.Find(category.Id);
                    if (categoryUpdate == null)
                    {
                        return NotFound();
                    }

                    categoryUpdate.Name = category.Name;
                    categoryUpdate.ParentId = category.ParentId;
                    categoryUpdate.IsActive = category.IsActive;


                    _Context.Update(categoryUpdate);
                    _Context.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                }
                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }
    }
}
