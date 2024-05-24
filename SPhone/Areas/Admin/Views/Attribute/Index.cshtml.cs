using Microsoft.AspNetCore.Mvc;
using SPhone.Models;
using System.ComponentModel.DataAnnotations;

namespace SPhone.Areas.Admin.Views.Attribute
{
    public class VariationModel
    {
        public List<Variation> Variations { get; set; }

        [BindProperty]
        public Variation? Input { get; set; }

    }
}
