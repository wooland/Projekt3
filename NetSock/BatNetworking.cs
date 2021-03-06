﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace NetSock
{
    public static class BatNetworking
    {
        public class Server
        {
            List<ClientHandler> clients = new List<ClientHandler>();
            public void Run()
            {
                TcpListener listener = new TcpListener(IPAddress.Any, 5000);
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
                foreach (ClientHandler tmpClient in clients)
                {
                    if (tmpClient != client)
                    {
                        NetworkStream n = tmpClient.tcpclient.GetStream();
                        BinaryWriter w = new BinaryWriter(n);
                        w.Write(message);
                        w.Flush();
                    }
                    else if (clients.Count() == 1)
                    {
                        NetworkStream n = tmpClient.tcpclient.GetStream();
                        BinaryWriter w = new BinaryWriter(n);
                        w.Write("Sorry, you are alone...");
                        w.Flush();
                    }
                }
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
                        myServer.Broadcast(this, message);
                        Console.WriteLine(message);
                    }

                    myServer.DisconnectClient(this);
                    tcpclient.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public class Client
        {
            public TcpClient client;

            public string messType = "standard responsmessage";

            public Client(TcpClient tcp)
            {
                client = tcp;
            }

            #region How Start used to look like
            //public void Start(string UserIP)
            //{
            //    client = new TcpClient(UserIP, 5000);

            //    Thread listenerThread = new Thread(Send);
            //    listenerThread.Start();

            //    Thread senderThread = new Thread(Listen);
            //    senderThread.Start();

            //    senderThread.Join();
            //    listenerThread.Join();
            //}
            #endregion

                  

            //public void Start()
           
                //{
            //    BatProtocol testProtocol = new BatProtocol { Type = "Login", UserName = "Batman", Password = "BBBB", RecieverIP = "10.20.38.150", RecieverPort = 5000 };
            //    client = new TcpClient(testProtocol.RecieverIP, testProtocol.RecieverPort);

            //    Thread batThread = new Thread(SendProtocol);
            //    batThread.Start(testProtocol);

            //    Thread listenerThread = new Thread(Send);
            //    listenerThread.Start();

            //    Thread senderThread = new Thread(Listen);
            //    senderThread.Start();

            //    senderThread.Join();
            //    listenerThread.Join();
            //    batThread.Join();
            //}

            public void Listen()
            {
                string message = "In case of no inputstring: This is the response";

                try
                {
                    while (true)
                    {
                        //Här kommer svarsobjektet
                        NetworkStream n = client.GetStream();
                        message = new BinaryReader(n).ReadString();
                        //dekoda message till objekt
                        BatProtocol deSerializedMessage = JsonConvert.DeserializeObject<BatProtocol>(message);
                        //Console.WriteLine("MessageType: " + deSerializedMessage.Type);
                        
                        this.messType = deSerializedMessage.Type;

                        if (deSerializedMessage.Type == "Ok") {
                            messType = "We're thoroughugh";
                        } else if (deSerializedMessage.Type == "SM")
                        {
                            messType = deSerializedMessage.Message;
                  
                        }
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
                //client = new TcpClient(p.RecieverIP, p.RecieverPort);

                NetworkStream n = client.GetStream();
                BinaryWriter w = new BinaryWriter(n);

                string protocol = JsonConvert.SerializeObject(input);
                w.Write(protocol);
            }
        }
    }
}
