using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPhone.Models;
using System.ComponentModel.DataAnnotations;

namespace SPhone.Areas.Admin.Views.Category
{
    public class CategoryModel
    {
        public List<Models.Category> Categories { get; set; }

        [BindProperty]
        public Models.Category? Input { get; set; }

        public CategoryModel()
        {
        }
    }
}
