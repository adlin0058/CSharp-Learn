using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _34_TCP客户端
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Socket tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //创建ip和端口
            //IP                                     本机ip地址↓
            IPAddress iP = new IPAddress(new byte[] { 10, 200, 4, 39 });
            //IP + port（端口）
            IPEndPoint iPEndPoint = new IPEndPoint(iP, 2233);
            //↑服务端要一致   插头和插口

            tcpClient.Connect(iPEndPoint);
            Console.WriteLine("连接上服务器了！");

            string message = "我发送了数据";
            //编码成0、1
            tcpClient.Send(Encoding.UTF8.GetBytes(message));

            byte[] buffer = new byte[1024];
            int length = tcpClient.Receive(buffer);
            string message1 = Encoding.UTF8.GetString(buffer);
            Console.WriteLine("接收的数据是：" + message1);
            tcpClient.Close();
        }
    }
}