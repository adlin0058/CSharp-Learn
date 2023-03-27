namespace _25_多播委托和匿名方法
{
    internal class Program
    {
        private static void Test1()
        {
            Console.WriteLine("test1");
        }

        private static void Test2()
        {
            Console.WriteLine("test2");
        }

        private static int Test3(int x)
        {
            return x;
        }

        private static int Test4(int x)
        {
            return x;
        }

        private static void Main(string[] args)
        {
            Action action1 = Test1;
            action1 += Test2;
            //action1();//若有多个方法就以此调用
            action1 -= Test1;
            action1();

            Func<int, int> action2 = Test3;
            action2 += Test4;
            Console.WriteLine(action2(1));//若有返回值的方法只返回最后一个
        }
    }
}