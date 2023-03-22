using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_接口
{
    public class Plane:IFly
    {
        public void Fly()
        {
            Console.WriteLine("飞机在飞");
        }
    }
}
