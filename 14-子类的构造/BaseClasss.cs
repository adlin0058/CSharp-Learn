using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_子类的构造
{
    internal class BaseClasss
    {
        private int Hp;
        private int Speed;

        public BaseClasss(int hp, int speed)
        {
            Hp = hp;
            Speed = speed;
        }

        public BaseClasss() 
        {
            Console.WriteLine("BaseClass的构造函数");
        }
    }
}
