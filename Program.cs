using SocketBackend;
using System.Net;
using System.Net.Sockets;

namespace ServerGameOfLife
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int port = 5555; // Port sur lequel le serveur écoute

            SocketServer server = new SocketServer(port);
            await server.StartAsync();
        }
    }
}