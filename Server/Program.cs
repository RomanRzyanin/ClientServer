using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Server
{
class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Это наш сервер");
        OurServer server = new OurServer();
    }
}
}


