namespace _26_Lambda表达式
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //匿名方法
            Func<int, int, int> plus = delegate (int x, int y)
            {
                return x + y;
            };
            //↓使用lambda表达式
            Func<int, int, int> plus1 = (x, y) => { return x + y; };
            //                                  只有一句话↑
            //                      可省略{return x}↓
            Func<int, int, int> plus2 = (x, y) => x + y;

            Func<double, double> square = (x) => x * x;
            //                 只有一个参数时↑
            //                    可省略括号↓
            Func<double, double> square1 = x => x * x;

            //可访问外部变量
            int a = 9;
            Func<int, int> f = x => x + a;
            Console.WriteLine(f(4));//result:13
            a = 4;
            Console.WriteLine(f(4));//result:8

            //!! 使用时需谨慎同一个输入有不同的输出↑
        }
    }
}