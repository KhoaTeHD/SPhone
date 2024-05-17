using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class Notification
    {
        public string Id { get; set; } = null!;
        public int? UserId { get; set; }
        public string? Title { get; set; }
        public string? NotiContent { get; set; }
        public DateTime? Date { get; set; }

        public virtual User? User { get; set; }
    }
}
