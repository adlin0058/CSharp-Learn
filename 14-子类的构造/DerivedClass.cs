using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _14_子类的构造
{
    internal class DerivedClass:BaseClasss
    {
        private int attack;
        public DerivedClass():base()
        {
            Console.WriteLine("DerivedClass的构造函数");
        }
        public DerivedClass(int hp,int speed,int atack):base(hp,speed)
        {
            this.attack = atack;
        }
    }
}
