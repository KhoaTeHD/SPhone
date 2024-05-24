using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Variation")]
    public partial class Variation
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Chưa đặt trạng thái hoạt động!")]
        public bool? IsActive { get; set; }

        public virtual ICollection<VariationOption>? VariationOptions { get; set; }
    }
}
