﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Product")]
    public class Product
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? CategoryId { get; set; }
        public string Avatar { get; set; } = null!;
        public int SumQty { get; set; }
        public bool IsActive { get; set; }

        public virtual Category? Category { get; set; }
        public virtual ICollection<ProductVariation> ProductVariations { get; set; }
    
        public virtual ICollection<User> Users { get; set; }
    }
}
