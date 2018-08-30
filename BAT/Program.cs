using BAT.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetSock.BatNetworking;

namespace BAT
{
    static class Program
    {
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// //Test
        [STAThread]
        static void Main()
        {
            
            //Thread servThread = new Thread(StartServer);
            //servThread.Start();
            


            BATContext context = new BATContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UserLogin(context));
            //Application.Run(new Chatbox(context));
            //servThread.Join();
        }

        private static void StartServer()
        {
            
            Server myServer = new Server();
            Thread serverThread = new Thread(myServer.Run);
            serverThread.Start();
            serverThread.Join();
            //Console.ReadKey();
            
        }
    }
}
