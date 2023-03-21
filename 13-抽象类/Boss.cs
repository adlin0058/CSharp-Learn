using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _13_抽象类与密封类
{
    internal class Boss : Enemy
    {
        public Boss(int hp,int attack)
        {
            this.Hp = hp;
            this.Attact = attack;
        }
        public override void Move()
        {
            Console.WriteLine("Boss的移动方法");
        }
        public int H
        { get { return this.Hp; } }
        public int AK
        { get { return this.Attact; } }
    }
}
