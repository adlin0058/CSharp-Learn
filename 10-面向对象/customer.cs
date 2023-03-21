using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_面向对象
{
    //顾客类
    internal class customer
    {
        public string name;
        public string address;
        public int age;
        public string creatTime;

        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("创建时间：" + creatTime);
        }
    }
}
