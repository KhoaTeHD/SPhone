﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Category")]
    public class Category
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        public string? Name { get; set; }
        public int? ParentId { get; set; }

        [Required(ErrorMessage = "Chưa đặt trạng thái hoạt động!")]
        public bool? IsActive { get; set; }

        public virtual Category? Parent { get; set; }
        public virtual ICollection<Category>? InverseParent { get; set; }
        public virtual ICollection<Product>? Products { get; set; }
    }
}
