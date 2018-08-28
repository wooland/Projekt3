using System;
using System.Collections.Generic;

namespace BAT.Models.Data
{
    public partial class BatUsers
    {
        public BatUsers()
        {
            BatMessage = new HashSet<BatMessage>();
            UserInChat = new HashSet<UserInChat>();
        }

        public int Uid { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public ICollection<BatMessage> BatMessage { get; set; }
        public ICollection<UserInChat> UserInChat { get; set; }
    }
}
