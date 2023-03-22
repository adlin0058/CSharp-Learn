using System;
using _13_抽象类与密封类;
namespace _14_子类的构造
{
    public   class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass(1000,100,10);
            Boss boss = new Boss(10,10);
        }
    }
}