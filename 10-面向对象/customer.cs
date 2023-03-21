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
        private int age;
        public string creatTime;

        //构造函数
        public customer() {
            Console.WriteLine("构造函数");
        }
        //构造函数的重构
        public customer (string name, string address, int age ,string creatTime)
        {
            this.name = name;
            this.address = address;
            this.age = age;
            this.creatTime = creatTime;
        }
        public void SetAge(int age)
        {
            if (age < 0) return;
            this.age = age;
        }
        public int GetAge()
        {
            return age;
        }
        public void Show()
        {
            Console.WriteLine("名字：" + name);
            Console.WriteLine("年龄：" + age);
            Console.WriteLine("地址：" + address);
            Console.WriteLine("创建时间：" + creatTime);
        }
    }
}
