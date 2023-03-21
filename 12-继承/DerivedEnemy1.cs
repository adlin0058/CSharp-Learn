using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_继承
{
    internal class DerivedEnemy1 : Enemy
    {
        public DerivedEnemy1(int hp,int attack,int speed)
        {
            Hp = hp;
            Attack = attack;
            Speed = speed;
        }

        //隐藏方法，父类中不需要virtual
        public new void Ai()
        {
            Console.WriteLine("小怪傻傻的AI");
        }
    }
}
