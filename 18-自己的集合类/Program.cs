namespace _18_自己的集合类
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //List<int> list = new List<int>() { 1, 2, 3, 4 };
            //list.Add(1);
            //Console.WriteLine(list.Capacity);
            //list.Insert(0, 2);
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list.Count);
            //list.RemoveAt(0);
            //Console.WriteLine(list.IndexOf(2));
            //Console.WriteLine(list.LastIndexOf(2));
            //list.Sort();

            MyList<int> mylist = new MyList<int>();
            Console.WriteLine(mylist.Capacity);
            mylist.Add(0);
            mylist.Add(1);
            mylist.Add(2);
            mylist.Add(3);
            mylist.Add(4);
            mylist.Add(5);
            mylist.Add(7);
            mylist.Add(8);
            mylist.Add(9);
            mylist.Insert(6, 2);
            mylist.Insert(3, 88);

            Console.WriteLine("capacity = " + mylist.Capacity);
            Console.WriteLine("count = " + mylist.Count);

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.Write(mylist[i] + " ");
            }
            Console.WriteLine();
            mylist.RemoveAt(11);
            mylist.Insert(17, -1);
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.Write(mylist[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("从前到后" + mylist.IndexOf(2));
            Console.WriteLine("从后到前" + mylist.LastIndexOf(2));
            mylist.Sort();
            mylist.Show();
        }
    }
}