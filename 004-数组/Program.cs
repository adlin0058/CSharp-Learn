//将输入的数字从小到大排序
namespace _004_数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();//存放输入的字符串
            string[] strArray = str.Split(" ");//将字符串按空格分开成字符串类型的数组
            int[] intArray = new int[strArray.Length];//定义一个新的整型数组用于存放转化来的数组
            for(int i = 0; i < strArray.Length; i++)//将字符转化成整型
            {
                int number = Convert.ToInt32(strArray[i]);
                intArray[i] = number;
            }
            //排序 1、Array.sort(intArray) 2、冒泡排序

            //Array.Sort(intArray);

            //输出排序后的数组
            foreach(int number in intArray)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();

            //冒泡排序
            //从头到尾比较并交换
            //每一次（0~n-1）遍历最后一个数最大
            //下一次（0~n-2）
            int min = intArray[0];
            for(int i = 0;i < intArray.Length-1;i++)
            {
                for(int j = 0;j < intArray.Length-1-i;j++)
                {
                    if (intArray[j] > intArray[j + 1])
                    {
                        int temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                    }
                }
            }
            //输出排序后的数组
            foreach (int number in intArray)
            {
                Console.Write(number+" ");
            }
            Console.WriteLine();
        }
    }
}