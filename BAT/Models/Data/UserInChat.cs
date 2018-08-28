using System;
using System.Collections.Generic;

namespace BAT.Models.Data
{
    public partial class UserInChat
    {
        public int Uicid { get; set; }
        public int? UserId { get; set; }
        public int? ChatId { get; set; }

        public BatChat Chat { get; set; }
        public BatUsers User { get; set; }
    }
}
