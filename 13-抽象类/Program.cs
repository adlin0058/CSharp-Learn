namespace _13_抽象类与密封类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //抽象类只能声明，但是不能实例化↓
            //Enemy boss = new Enemy();×
            Boss boss = new Boss(10000, 100);
            boss.Move();
            
            Console.WriteLine("Hp:"+boss.H);
            Console.WriteLine("Attack" + boss.AK);
        }
    }
}