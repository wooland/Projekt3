using System;
using System.Collections.Generic;
using System.Text;

namespace NetSock
{
    
    public class BatProtocol
    {
        public string Type { get; set; }

        public string Message { get; set; }

        public double Version { get; set; }

        public int UID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string RecieverIP { get; set; }

        public int RecieverPort { get; set; }

    }
}
