namespace _12_继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("小怪1");
            DerivedEnemy1 de1 = new DerivedEnemy1 (100,10,5);
            de1.Ai();
            de1.Move();
            Console.WriteLine("Boss登场！");
            Boss boss1 = new Boss(3,10000,50,20);
            boss1.Print();
            boss1.Skill();
            boss1.Move();
            boss1.Ai();
        }
    }
}