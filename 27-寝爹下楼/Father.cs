using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_寝爹下楼
{
    //声明委托
    internal delegate void DownStairDelegate();

    internal class Father
    {
        //定义空委托用于存放儿子们的事件
        public event DownStairDelegate DownStairDelegate = null;

        public Father(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void DownStair()
        {
            Console.WriteLine("寝爹" + Name + "下楼吃饭");
            //若委托不为空则调用委托
            if (DownStairDelegate != null)
            {
                DownStairDelegate();
            }
        }
    }
}