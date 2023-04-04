using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _35_UDP服务端
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Socket udpServer = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            //创建ip和端口
            //IP                                     本机ip地址↓
            IPAddress iP = new IPAddress(new byte[] { 10, 200, 4, 39 });
            //IP + port（端口）
            IPEndPoint iPEndPoint = new IPEndPoint(iP, 2233);

            //绑定端口
            udpServer.Bind(iPEndPoint);

            //可接收 来自任意地址、任意端口的信息
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 0);
            byte[] buffer = new byte[1024];

            EndPoint endPoint = (EndPoint)ip;
            //                          ↓执行到此处等待接收
            int length = udpServer.ReceiveFrom(buffer, ref endPoint);
            string message = Encoding.UTF8.GetString(buffer, 0, length);
            Console.WriteLine("接收到：" + message);
        }
    }
}