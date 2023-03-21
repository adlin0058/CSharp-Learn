namespace _11_属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            customer lm = new customer();

            lm.Age = 21;
            lm.Name = "liming";
            lm.Address = "shanghai";
            lm.creatTime = "2023年";
            Console.WriteLine(lm.Age);
            Console.WriteLine(lm.Name);
            Console.WriteLine(lm.Address);
            Console.WriteLine(lm.creatTime);
            lm.Show();

            //匿名数据类型
            var age2 = 22;
            //给age2初始化后，类型确定，不可修改类型
            //可赋值，相同类型
            age2 = 33;
            age2 = 44;
            Console.WriteLine(age2);

        }
    }
}