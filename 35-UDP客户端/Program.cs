using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _35_UDP客户端
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Socket udpClient = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //创建ip和端口
            //IP                                     本机ip地址↓
            IPAddress iP = new IPAddress(new byte[] { 10, 200, 4, 39 });
            //IP + port（端口）
            IPEndPoint iPEndPoint = new IPEndPoint(iP, 2233);

            byte[] message = Encoding.UTF8.GetBytes("哈哈哈，客户端来喽~");

            udpClient.SendTo(message, iPEndPoint);
        }
    }
}