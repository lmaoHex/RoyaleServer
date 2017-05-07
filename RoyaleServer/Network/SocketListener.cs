using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace RoyaleServer.Network
{
    class SocketListener
    {
        private const int PORT = 5000;
        private const int MAX_CLIENTS = 90;
        private static int ClientCount = 0;
        public List<TcpClient> ConnectedClients = new List<TcpClient>();

        private static IPAddress LocalAddr;
        private static TcpListener TcpServer;


        public SocketListener()
        {
#pragma warning disable CS0618 // Type or member is obsolete
            LocalAddr = Dns.Resolve("localhost").AddressList[0];
            TcpServer = new TcpListener(LocalAddr, PORT);
            TcpServer.Start();

            while (true)
            {
                TcpClient ConnectingUser = TcpServer.AcceptTcpClient();
                Debug.LogInfo($"User {ConnectingUser.Client.RemoteEndPoint} connected");
                ConnectedClients.Add(ConnectingUser);
            }
#pragma warning restore CS0618 // Type or member is obsolete

        }
    }
}
