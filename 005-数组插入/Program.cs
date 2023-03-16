namespace _005_数组插入
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入初始数组");
            string str = Console.ReadLine();
            string[] strArray = str.Split(" ");
            int[] ints = new int[strArray.Length];
            for (int i = 0; i < strArray.Length;i++)
            {
                int number = Convert.ToInt32(strArray[i]);
                ints[i] = number;
            }
            Console.WriteLine("请输入要插入的数");
            int n = Convert.ToInt32(Console.ReadLine());

            //寻找n应该插入位置的索引index
            int index = 0;
            Boolean isFind = false;
            for(int i = 0; i< ints.Length-1;i++)
            {
                if ((n >= ints[i]) && (n <= ints[i+1]))
                {
                    index = i;
                    isFind = true;
                    break;
                }
            }
            //建立一个新的int数组将原来的数和要插入的数放入
            int[] NewInts = new int[ints.Length + 1];
            //如果找到应插入的位置
            if (isFind)
            {
                //1、放入index之前的数
                
                for (int i = 0; i < index + 1; i++)
                {
                    NewInts[i] = ints[i];
                }
                //放入第index个数
                NewInts[index + 1] = n;
                //将原数组中的index+1~length-1放入新数组index+2~length
                for (int i = index + 1; i < ints.Length; i++)
                {
                    NewInts[i + 1] = ints[i];
                }
            }
            //如果未找到
            else
            {
                //如果n最大
                if(n >= ints[ints.Length-1])
                {
                    for (int i = 0; i < ints.Length; i++)
                    {
                        NewInts[i] = ints[i];
                    }
                    NewInts[ints.Length] = n;
                }
                //如果n最小
                else
                {
                    NewInts[0] = n;
                    for(int i = 0; i< ints.Length;i++)
                    {
                        NewInts[i+1] = ints[i];
                    }
                }
            }
            foreach (int i in NewInts)
            {
                Console.Write(i + " ");
            }

        }
    }
}