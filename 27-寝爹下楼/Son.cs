using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_寝爹下楼
{
    internal class Son
    {
        public Son(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void TakeFood()
        {
            Console.WriteLine(Name + "的饭");
        }

        public void TakeExpress()
        {
            Console.WriteLine(Name + "的快递");
        }
    }
}