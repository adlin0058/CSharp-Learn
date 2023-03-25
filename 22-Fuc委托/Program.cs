namespace _22_Func委托
{
    internal class Program
    {
        private static string Test1()
        {
            return "Test1";
        }

        private static string Test2(int x, double y)
        {
            return "Test2" + x + y;
        }

        private static void Main(string[] args)
        {
            //Func 参数任意    必须有返回值
            //调用时↓  必须说明返回值类型
            Func<string> func1 = Test1;
            Console.WriteLine(func1());

            //若有参数，↓应在返回值类型前写明所有参数类型
            Func<int, double, string> func2 = Test2;
            Console.WriteLine(func2(22, 22.33));
        }
    }
}