namespace _10_面向对象
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //一个类可以有很多对象
            //类==模板
            customer lm = new customer();//实例化对象
            //lm.name = "李明";
            //lm.SetAge(21);
            //lm.address = "上海";
            //lm.creatTime = "2023年3月20日";
            customer zhangsan = new customer("zhangsan","beijing",22,"2023年");
            lm.Show();
            zhangsan.Show();
            //向量类
            vector3 v1 = new vector3();
            v1.SetX(1f);
            v1.SetY(2f);
            v1.SetZ(3f);
            Console.WriteLine(v1.Length());

        }
    }
}