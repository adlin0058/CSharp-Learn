using System.Threading.Channels;

namespace _28_线程
{
    internal class Program
    {
        private static void Test()
        {
            Console.WriteLine("TestStarted");
            Thread.Sleep(10000);
            Console.WriteLine("TestCompleted");
        }

        private static void DownLoad(object o)
        {
            //模拟下载
            string address = o as string;
            Thread.Sleep(3000);
            Console.WriteLine(address + "下载完成");
        }

        public struct Data
        {
            //注意为public否则外部无法访问
            public string Name;

            public int age;
        }

        public static void Print(object o)
        {
            //                  ↓因为struct为值类型，不能用null赋值
            //         强转↓  不能用o as Data
            Data data = (Data)o;
            Console.WriteLine(data.Name);
            Console.WriteLine(data.age);
        }

        private static void Main(string[] args)
        {
            ////定义一个线程    这个线程会执行一段时间（因为Sleep（））
            ////Thread t = new Thread(Test);
            ////也可以用匿名方法↓
            //Thread t = new Thread(() => Console.WriteLine("Child Thread " + Thread.CurrentThread.ManagedThreadId));
            //t.Start();//线程开始，Test()开始执行
            ////在这线程执行的同时别的线程也可执行
            //Console.WriteLine("MainCompleted " + Thread.CurrentThread.ManagedThreadId);

            //无参
            //Thread t = new Thread(Test);
            //t.Start();

            //参数为变量(单一)
            Thread d = new Thread(DownLoad);
            d.Start("www.github.com/xxx.zip");

            //多个参数
            Data data = new Data();
            data.Name = "lm";
            data.age = 21;
            Thread p = new Thread(Print);
            p.Start(data);

            d.Priority = ThreadPriority.AboveNormal;
            p.Priority = ThreadPriority.Lowest;
        }
    }
}