using System;
using System.Collections.Generic;

namespace BAT.Models.Data
{
    public partial class BatChat
    {
        public BatChat()
        {
            BatMessage = new HashSet<BatMessage>();
            UserInChat = new HashSet<UserInChat>();
        }

        public int Cid { get; set; }
        public string Header { get; set; }

        public ICollection<BatMessage> BatMessage { get; set; }
        public ICollection<UserInChat> UserInChat { get; set; }
    }
}
