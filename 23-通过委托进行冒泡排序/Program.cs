using _23_通过委托进行冒泡排序;

namespace _24_通过委托进行冒泡排序
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RoomMates[] rms =
            {
                new RoomMates("fang",31981138),
                new RoomMates("ming",73482927),
                new RoomMates("yu  ",69823365),
                new RoomMates("xie ",23462973),
                new RoomMates("shen",24982376),
                new RoomMates("lei ",87234893)
            };
            Sort<RoomMates>(rms, RoomMates.CompareSalary);
            foreach (RoomMates roomMates in rms)
            {
                Console.WriteLine(roomMates.Name + ":" + roomMates.Salary);
            }
        }

        public static void Sort<T>(T[] data, Func<T, T, bool> compare)
        {
            bool isSwap = true;
            do
            {
                isSwap = false;
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (compare(data[i], data[i + 1]))
                    {
                        T temp = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temp;
                        isSwap = true;
                    }
                }
            } while (isSwap);//如果发生交换就继续循环
        }
    }
}