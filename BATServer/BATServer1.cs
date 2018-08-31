using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using BAT.Models.Data;
using NetSock;
using Newtonsoft.Json;


namespace BATServer
{
    class BATServer1
    {
        public static BATContext context { get; set; }
        //public BATServer1(BATContext context)
        //{
        //    this.context = context;
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("IP: " + GetLocalIPAddress());
            context = new BATContext();
            Server myServer = new Server();
            Thread serverThread = new Thread(myServer.Run);
            serverThread.Start();
            serverThread.Join();
            Console.ReadKey();
        }

        public class Server
        {
            List<ClientHandler> clients = new List<ClientHandler>();
            public void Run()
            {
                Console.WriteLine("IP: " + GetLocalIPAddress());
                int port = 5000;
                Console.WriteLine("Port: " + port);
                TcpListener listener = new TcpListener(IPAddress.Any, port);
                Console.WriteLine("Server up and running, waiting for messages...");

                try
                {
                    listener.Start();

                    while (true)
                    {
                        TcpClient c = listener.AcceptTcpClient();
                        ClientHandler newClient = new ClientHandler(c, this);
                        clients.Add(newClient);

                        Thread clientThread = new Thread(newClient.Run);
                        clientThread.Start();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (listener != null)
                        listener.Stop();
                }
            }

            public void Broadcast(ClientHandler client, string message)
            {
                List<ClientHandler> notConnectedclients = new List<ClientHandler>();

                lock (clients)
                {


                    foreach (ClientHandler tmpClient in clients)
                    {

                        try
                        {


                            //if (tmpClient != client)
                            //{
                                NetworkStream n = tmpClient.tcpclient.GetStream();
                                BinaryWriter w = new BinaryWriter(n);
                                w.Write(message);
                                w.Flush();
                            //}
                            //else if (clients.Count() == 1)
                            //{
                            //    NetworkStream n = tmpClient.tcpclient.GetStream();
                            //    BinaryWriter w = new BinaryWriter(n);
                            //    w.Write("Sorry, you are alone...");
                            //    w.Flush();
                            //}
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Client not connected, Will be removed.");
                            Console.WriteLine(ex.Message);
                            notConnectedclients.Add(tmpClient);
                        }
                    }
                    if (notConnectedclients.Count > 0)
                    {
                        foreach (var tmpClient in notConnectedclients)
                        {
                            clients.Remove(tmpClient);
                            Console.WriteLine("Removed faulty client");
                        }
                    }
                }
                Console.WriteLine($"{clients.Count} Connected clients");


            }

            public void DisconnectClient(ClientHandler client)
            {
                clients.Remove(client);
                Console.WriteLine("Client X has left the building...");
                Broadcast(client, "Client X has left the building...");
            }
        }

        public class ClientHandler
        {
            public TcpClient tcpclient;
            private Server myServer;
            public ClientHandler(TcpClient c, Server server)
            {
                tcpclient = c;
                this.myServer = server;
            }



            public void Run()
            {
                try
                {
                    string message = "";
                    while (!message.Equals("quit"))
                    {
                        NetworkStream n = tcpclient.GetStream();
                        message = new BinaryReader(n).ReadString();
                        ReadMessage(message);
                        //myServer.Broadcast(this, message);
                        //Console.WriteLine(message);
                    }

                    myServer.DisconnectClient(this);
                    tcpclient.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            private void ReadMessage(string message)
            {

                BatProtocol deSerializedMessage = JsonConvert.DeserializeObject<BatProtocol>(message);

                //Testar om message är av typen login
                if (deSerializedMessage.Type == "Login")
                {
                    Console.WriteLine("logging in...");
                    //kollar om username finns i databasen
                    if (context.BatUsers.ToList()
                        .Exists(u => u.Name == deSerializedMessage.UserName))
                    {
                        Console.WriteLine(deSerializedMessage.UserName + "Exists");

                        //Kollar om lösenord matchar med det som är lagt in i databasen under samma login.
                        if (context.BatUsers.ToList()
                            .Find(u => u.Name == deSerializedMessage.UserName)
                            .Password == deSerializedMessage.Password)
                        {
                            Console.WriteLine("Login Successful");
                            //Skickar message i retur
                            NetworkStream n = tcpclient.GetStream();
                            BatProtocol ok = new BatProtocol { Type = "Ok" };

                            new BinaryWriter(n).Write(JsonConvert.SerializeObject(ok));

                        }
                    }
                }

                else if (deSerializedMessage.Type == "PM")
                {
                    Console.WriteLine(deSerializedMessage.UserName + " PM: " + deSerializedMessage.Message);

                    NetworkStream n = tcpclient.GetStream();

                    deSerializedMessage.Type = "SM";

                    //new BinaryWriter(n).Write(JsonConvert.SerializeObject(deSerializedMessage));
                    myServer.Broadcast(this, JsonConvert.SerializeObject(deSerializedMessage));
                }

                else
                {
                    Console.WriteLine("Unhandled message Type");
                }


            }
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }

}

