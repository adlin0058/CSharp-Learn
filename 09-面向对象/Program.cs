using System.Linq.Expressions;

namespace _09_面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] Array = { 1, 2, 3, 4, 5 };
            //try
            //{
            //    int temp = Array[5];
            //}
            //catch (IndexOutOfRangeException)//如果不写()则只要出现异常就会执行以下代码
            //{
            //    //出现这个异常时如何处理
            //    Console.WriteLine("异常");
            //}
            //finally
            //{
            //    Console.WriteLine("无论是否错误都会执行");
            //}
            //以上为测试
            //两个数相加，若输入不是数字重新输入
            int number1 = 0,number2 = 0;
            while (true)
            {
                try
                {
                    number1 = Convert.ToInt32(Console.ReadLine());//如果错误try下面语句不执行
                    number2 = Convert.ToInt32(Console.ReadLine());//如果错误try下面语句不执行
                    break;//前两个输入都正确，跳出
                }
                catch(FormatException e)
                {
                    Console.WriteLine("请重新输入");
                }
            }
            Console.WriteLine(number1 + number2);
        }
    }
}