using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _33_服务端TCPServer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //插口---->需说明插口形状大小等         ipv4的地址↓                流↓              TCP协议↓
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            //创建ip和端口
            //IP                                     本机ip地址↓
            IPAddress iP = new IPAddress(new byte[] { 10, 200, 4, 39 });
            //IP + port（端口）
            IPEndPoint iPEndPoint = new IPEndPoint(iP, 2233);

            //绑定
            tcpServer.Bind(iPEndPoint);
            //最大连接数
            tcpServer.Listen(100);

            Console.WriteLine("等待连接……");
            //等待连接（此时线程暂停），连接成功返回客户端“插头”（线程继续）
            Socket client = tcpServer.Accept();

            //连接成功后
            Console.WriteLine("连接成功！");

            //buffer用于暂存接收的数据
            byte[] buffer = new byte[1024];
            //接收数据  返回数据长度
            int length = client.Receive(buffer);
            //将数据重写编码，变成可读的信息
            string message = Encoding.UTF8.GetString(buffer, 0, length);
            Console.WriteLine("收的的信息是：" + message);

            string message1 = "发送的数据";
            tcpServer.Send(Encoding.UTF8.GetBytes(message1));

            //先打开的后关闭
            client.Close();
            tcpServer.Close();
        }
    }
}