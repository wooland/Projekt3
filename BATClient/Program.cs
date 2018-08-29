using NetSock;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using static NetSock.BatNetworking;

namespace BATClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client myClient = new Client();

            Thread clientThread = new Thread(myClient.Start);
            clientThread.Start();
            clientThread.Join();
        }
    }
}