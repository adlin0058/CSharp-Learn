using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_抽象类
{
    //1、防止代码混 2、商业用途
    sealed class Child:Base
    {
        //重写过的方法可以sealed密封
        public sealed override void Print()
        {
            base.Print();
        }
    }
}
