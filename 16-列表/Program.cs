namespace _16_列表
{
    internal class Program
    {
        static void ShowList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i] + " ");
            //}
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>(10) { 33, 12, 33, 33 };
            //增add
            list.Add(45);
            list.Add(12);
            list.Add(34);
            list.Add(56);
            list.Add(78);
            ShowList(list);
            //插入insert(index,number);
            list.Insert(3, 89);
            ShowList(list);//在第三位数后添加了数字89

            //删RemoveAt(index);Remove(number);
            list.Remove(12);
            ShowList(list);//删除了第一个12

            list.RemoveAt(2);
            ShowList(list);//删除了index为2的数

            //改list[index] = number;
            list[1] = 66;
            ShowList(list);//将index为1的数改为66

            //查IndexOf(number);查询第一个number的索引
            Console.WriteLine(list.IndexOf(33));
            //LastIndexOf(number);最后一个number的索引
            Console.WriteLine(list.LastIndexOf(33));
            //不存在返回-1
            Console.WriteLine(list.IndexOf(666));

            //排序，从小到大sort();
            list.Sort();
            ShowList(list);

            Console.WriteLine("列表长度"+list.Capacity);
            Console.WriteLine("元素个数"+list.Count);
        }
    }
}