using System.Runtime.CompilerServices;

namespace _20_委托
{
    internal class Program
    {
        private delegate void IntMethodInvoker(int x);

        private delegate long TwoLong(long x, long y);

        private delegate string GetAString();

        private static void Main(string[] args)
        {
            //委托可指向静态方法和实例方法（通过某个对象调用）
            IntMethodInvoker intMethodInvoker = null;
            TwoLong twoLong = null;

            intMethodInvoker = Test;//进行委托  Test委托给intMethodInvoker
            //调用其他类应为 intMethodInkevor=Program.Test;
            intMethodInvoker(100);//委托后可直接使用Test的方法

            int x = 123;
            GetAString getAString = x.ToString;//不要括号，有括号就是调用方法
            GetAString getAString1 = new GetAString(x.ToString);
            Console.WriteLine(getAString());//此处是调用 要括号

            //委托->委托类型  变量  可传递
            DoubleOpDelegate[] operaions = { MathOp.MultiplyByTwo, MathOp.Square };
            foreach (DoubleOpDelegate opera in operaions)
            {
                Console.WriteLine(opera(9));//直接调用
                ProcessAndDisplayRes(opera, 81);
            }
        }

        //声明委托类型
        private delegate double DoubleOpDelegate(double x);

        //传递委托 进行调用
        private static void ProcessAndDisplayRes(DoubleOpDelegate op, double value)
        {
            double Result = op(value);
            Console.WriteLine("Result:" + Result);
        }

        private static void Test(int x)
        {
            Console.WriteLine("静态方法" + x);
        }
    }
}