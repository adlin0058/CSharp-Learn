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

        //virtual虚函数
        //虚函数在使用时会先检查是否重写
        public virtual void Move()
        {
            Console.WriteLine("移动");
        }
        public virtual void Ai()
        {
            Console.WriteLine("AI攻击");
        }
    }
}
