using System;
using System.Collections.Generic;

namespace BAT.Models.Data
{
    public partial class BatMessage
    {
        public int Mid { get; set; }
        public int? UserId { get; set; }
        public int? ChatId { get; set; }
        public string MessageText { get; set; }
        public DateTime? Entered { get; set; }

        public BatChat Chat { get; set; }
        public BatUsers User { get; set; }
    }
}
