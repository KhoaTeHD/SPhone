using System;
using System.Collections.Generic;

namespace SPhone.Models
{
    public partial class Tracker
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? Action { get; set; }
        public DateTime? Timestamp { get; set; }

        public virtual User? User { get; set; }
    }
}
