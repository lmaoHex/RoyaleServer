using RoyaleServer.Network;
using RoyaleServer.Data;
using System;

namespace RoyaleServer
{

    class Royale
    {
        public static Store Database = new Store("ROYALE_TEST_DATA");

        static void Main(string[] args)
        {
            PlayerPosition RandomPlayer = new PlayerPosition();
            SocketListener Server = new SocketListener();

            Console.ReadLine(); // remove me idiot
        }
    }
}
