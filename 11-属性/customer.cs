using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_属性
{
    internal class customer
    {
        public string name;
        public string address;
        private int age;
        public string creatTime;

        //只有一个get为只读
        //只有一个set为只写
        public int Age
        {
            get 
            { 
                return age; 
            }
            set
            {
                if (value < 0) return;
                age = value; 
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; 
            }
        }
        public string Address
        {
            get 
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string CreatTime
        {
            get
            {
                return creatTime;
            }
            set
            {
                creatTime = value;
            }
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
