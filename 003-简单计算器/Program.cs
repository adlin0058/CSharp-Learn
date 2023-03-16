//数的输入与输出
namespace _003_简单计算器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("请输入第一个数：");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数：");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("两个数的和为："+(a+b));
            Console.WriteLine("两个数的平均数为："+((a+b)/2));
            Console.WriteLine("两个数的商为："+(b/a));
        }
    }
}