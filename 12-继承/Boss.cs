using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _12_继承
{
    internal class Boss:Enemy
    {

        private int Count = 3;

        public Boss(int count,int hp,int attack,int speed)
        {
            Count = count;
            Hp = hp;
            Attack = attack;
            Speed = speed;
        }

        public void Skill()
        {
            Console.WriteLine("Boss Skill");
        }
        public void Print()
        {
            Console.WriteLine("Hp:" + Hp);
            Console.WriteLine("Count:" + Count);
            Console.WriteLine("Attack:" + Attack);
            Console.WriteLine("Speed:"+Speed);
            base.Ai();
        }
        public new void Ai()
        {
            Console.WriteLine("Boss的特有的Ai攻击");
        }
    }
}
