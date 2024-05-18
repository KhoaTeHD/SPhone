using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Review")]
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public int? ProductVariationId { get; set; }
        public int? UserId { get; set; }
        public string? ReviewContent { get; set; }
        public int? ReplyFor { get; set; }
        public bool? IsApproved { get; set; }

        public virtual ProductVariation? ProductVariation { get; set; }
        public virtual User? User { get; set; }
    }
}
