namespace _10_面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.name = "李明";
            c1.age = 21;
            c1.address = "上海";
            c1.creatTime = "2023年3月20日";

            c1.Show();
        }
    }
}