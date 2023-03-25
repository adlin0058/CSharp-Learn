namespace _21_Action委托
{
    internal class Program
    {
        private static void Test1()
        {
            Console.WriteLine("Test1");
        }

        private static void Test2(int x)
        {
            Console.WriteLine("Test2" + x);
        }

        private static void Test3(int x, double y)
        {
            Console.WriteLine("Test3" + x + y);
        }

        private static void Main(string[] args)
        {
            //Action 是泛型，可有任意参数，但是一定无返回值
            Action method = Test1;
            method();

            Action<int> method2 = Test2;
            method2(666);

            Action<int, double> method3 = Test3;
            method3(2233, 88.88);
        }
    }
}