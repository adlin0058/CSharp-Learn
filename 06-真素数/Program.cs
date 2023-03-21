namespace _06_真素数
{
    //练习函数的使用
    internal class Program
    {
        //判断是否为素数
        static bool isPrime(int n)
        {
            
            if (n == 1) 
                return false;
            else if (n == 2) 
                return true;
            else
            {
                bool flag = true;
                for (int i = 2; i < MathF.Sqrt(n)  ; i++)
                {
                    
                    if (n % i == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag)
                    //flag没有被改变，为素数
                    return true;
                else
                    return false;
            } 
        }

        //反转
        static int Reversal(int n)
        {
            //int m = 0;
            //int count = 0;
            ////这个数有几位
            //int temp = n;
            //while (temp != 0)
            //{
            //    count++;
            //    temp = temp / 10;
            //}
            //temp = n;
            ////ints[]用于存放这个数 反过来的数 的每一位
            //int[] ints = new int[count];
            //for (int i = 0; i < count; i++)
            //{
            //    ints[i] = temp % 10;
            //    temp = temp / 10;
            //}
            ////反向组装起来
            //for (int i = 0; i < count; i++)
            //{
            //    m = m * 10 + ints[i];
            //}
            //return m;
            string str = Convert.ToString(n);//转为字符串
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            str = new string(chars);
            int m = Convert.ToInt32(str);

            return m;
        }
        static void Main(string[] args)
        {
            //Flag用于判断范围内是否有素数
            bool Flag = false;
            //引导输入
            Console.WriteLine("请输入正整数M和N");
            string str = Console.ReadLine();
            string[] strings = str.Split(" ");
            int m = Convert.ToInt32(strings[0]);
            int n = Convert.ToInt32(strings[1]);
            
            //在循环中判断每一个数是否为真素数,并输出
            for(int i = m ; i < n + 1 ; i++)
            {
                //如果这个数和相反都为素数，则输出
                if (isPrime(i))
                {
                    if(isPrime(Reversal(i)))
                    {
                        Flag = true;
                        Console.Write(i + " ");
                    }
                        
                }
            }
            //Flag==false，未输出一个素数
            if (Flag == false)
            {
                Console.WriteLine("NO");
            }
        }
    }
}