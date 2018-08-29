using NetSock;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

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
    public class Client
    {
        private TcpClient client;

        
        public void Start()
        {
            BatProtocol testProtocol = new BatProtocol { Type = "Login", UserName = "Batman", Password = "BBBB", RecieverIP = "10.20.38.150", RecieverPort = 5000 };
            client = new TcpClient(testProtocol.RecieverIP, testProtocol.RecieverPort);

            Thread batThread = new Thread(SendProtocol);
            batThread.Start(testProtocol);

            Thread listenerThread = new Thread(Send);
            listenerThread.Start();

            Thread senderThread = new Thread(Listen);
            senderThread.Start();

            senderThread.Join();
            listenerThread.Join();
            //batThread.Join();
        }

        public void Listen()
        {
            string message = "";

            try
            {
                while (true)
                {
                    NetworkStream n = client.GetStream();
                    message = new BinaryReader(n).ReadString();
                    Console.WriteLine("Other: " + message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Send()
        {
            string message = "";

            try
            {
                while (!message.Equals("quit"))
                {
                    NetworkStream n = client.GetStream();

                    message = Console.ReadLine();
                    BinaryWriter w = new BinaryWriter(n);
                    w.Write(message);
                    w.Flush();
                }

                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void SendProtocol(Object input)
        {
            BatProtocol p = (BatProtocol)input;
            client = new TcpClient(p.RecieverIP, p.RecieverPort);

            NetworkStream n = client.GetStream();
            BinaryWriter w = new BinaryWriter(n);

            string protocol = JsonConvert.SerializeObject(p);
            w.Write(protocol);
            
        }
    }
}