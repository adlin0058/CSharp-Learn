using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_通过委托进行冒泡排序
{
    internal class RoomMates
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public RoomMates(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }
}