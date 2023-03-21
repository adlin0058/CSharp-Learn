using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_继承
{
    internal class Enemy
    {
        protected int Hp;
        protected int Attack;
        protected int Speed;

        public void Move()
        {
            Console.WriteLine("移动");
        }
        public void Ai()
        {
            Console.WriteLine("AI攻击");
        }
    }
}
