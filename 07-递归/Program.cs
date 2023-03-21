namespace _07_递归
{
    //方法Fx（）
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("f(n)请输入要计算的数n:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("结果为：" + diGui(n));
        }
        static int diGui(int n)
        {
            if (n == 0)
                return 2;
            else if (n == 1)
                return 3;
            else
            {
                int sum = diGui(n - 1) + diGui(n - 2);
                return sum;
            }
        }
    }

   
}