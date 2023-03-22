using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_接口
{
    //一个类只能继承一个父类，但是能有多个接口
    internal class classInterface : Bird, Interface1, Interface2
    {
        public void Method1()
        {
            throw new NotImplementedException();
        }

        public void Method2()
        {
            throw new NotImplementedException();
        }
    }
}
