namespace _23_冒泡排序
{
    internal class Program
    {
        private static void Sort(int[] Array)
        {
            bool isSwap = true;
            do
            {
                isSwap = false;
                for (int i = 0; i < Array.Length - 1; i++)
                {
                    if (Array[i] >= Array[i + 1])
                    {
                        int temp = Array[i];
                        Array[i] = Array[i + 1];
                        Array[i + 1] = temp;
                        isSwap = true;
                    }
                }
            } while (isSwap);//如果发生交换就继续循环
        }

        private static void Main(string[] args)
        {
            int[] arr = { 31, 27, 53, 49, 35, 62, 75, 38 };
            Sort(arr);
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}