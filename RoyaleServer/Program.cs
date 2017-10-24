using RoyaleServer.Network;
using RoyaleServer.Data;
using System;

namespace RoyaleServer
{

    class Royale
    {
        public static Store Database = new Store("ROYALE_TEST_DATA");
        public static SocketListener Server = new SocketListener(5000);
        public static Player RandomPlayer;

        static void Main(string[] args)
        {
            RandomPlayer = new Player("Hex", new PlayerPosition());
            Server.Start();
            Console.ReadLine(); // remove me idiot
        }
    }
}
