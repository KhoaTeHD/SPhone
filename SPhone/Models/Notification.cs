using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPhone.Models
{
    [Table("Notification")]
    public class Notification
    {
        [Key]
        public string Id { get; set; } = null!;
        public int? UserId { get; set; }
        public string? Title { get; set; }
        public string? NotiContent { get; set; }
        public DateTime? Date { get; set; }

        public virtual User? User { get; set; }
    }
}
