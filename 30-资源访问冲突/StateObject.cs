using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_资源访问冲突
{
    internal class StateObject
    {
        private int state = 5;

        //锁
        private object _lock = new object();

        //多个线程同时访问方法时可能会有冲突
        public void ChangeState()
        {
            lock (_lock)
            {
                if (state == 5)
                {
                    state++;
                    Console.WriteLine("state " + state + " :" + Thread.CurrentThread.ManagedThreadId);
                }
                state = 5;
            }
        }
    }
}