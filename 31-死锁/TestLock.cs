using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31_死锁
{
    internal class TestLock
    {
        private object _lock1 = new object();

        private object _lock2 = new object();

        public void Mothed1()

        {
            lock (_lock1)
            {
                Console.WriteLine("执行方法1");
                lock (_lock2)
                {
                    Console.WriteLine("执行方法2");
                }
            }
        }

        public void Mothed2()
        {
            lock (_lock2)
            {
                Console.WriteLine("执行方法2");
                lock (_lock1)
                {
                    Console.WriteLine("执行方法1");
                }
            }
        }
    }
}