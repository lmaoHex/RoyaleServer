using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Net.Sockets;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RoyaleServer.Network
{
    class SocketListener
    {
        private static IPAddress LocalAddr;
        private static TcpListener TcpServer;
        private Byte[] bytes = new Byte[256];
        public List<TcpClient> ConnectedClients = new List<TcpClient>();
        public List<Thread> PlayerThreads = new List<Thread>();
        private StringComparison t;

        public SocketListener(int port)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            LocalAddr = Dns.Resolve("localhost").AddressList[0];
            TcpServer = new TcpListener(LocalAddr, port);
#pragma warning restore CS0618 // Type or member is obsolete
        }

        public void Start()
        {
            TcpServer.Start();

            while (true)
            {
                TcpClient ConnectingUser = TcpServer.AcceptTcpClient();
                Debug.LogInfo($"User {ConnectingUser.Client.RemoteEndPoint} connected");
                ConnectedClients.Add(ConnectingUser);

                PlayerAsync(ConnectingUser);
            }
        }

        private async Task PlayerAsync(TcpClient player)
        {
            int i;
            string data;
            bool validUser;
            JObject authData;

            while ((i = player.GetStream().Read(bytes, 0, bytes.Length)) != 0)
            {
                data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                authData = JObject.Parse(data);

                validUser = Auth.Login(authData.GetValue("username"), authData.GetValue("password"));
                if (validUser)
                {
                    // complete login process
                }
            }
        }
    }
}
