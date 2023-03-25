using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_委托
{
    internal class MathOp
    {
        public static double MultiplyByTwo(double x)
        {
            return x * 2;
        }

        public static double Square(double x)
        {
            return x * x;
        }
    }
}