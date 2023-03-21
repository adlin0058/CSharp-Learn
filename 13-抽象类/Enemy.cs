using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_抽象类与密封类
{
    abstract class Enemy
    {
        //↓可以有数据类型
        protected int Hp;
        protected int Attact;
        //抽象函数只能在抽象类中声明，抽象类中可以有非抽象方法
        public abstract void Move();
        
    }
}
