using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_自己的集合类
{
    internal class MyList<T>
    {
        private T[] list = new T[0];

        //显示每个
        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }

        //Capacity获取容量大小
        public int Capacity//属性
        {
            get { return list.Length; }
        }

        //Count获取元素个数
        private int count = 0;

        public int Count
        { get { return count; } }

        //索引器
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count - 1)
                    throw new IndexOutOfRangeException("索引超出范围");
                else
                    return list[index];
            }
            set
            {
                if (index < 0 || index > count - 1)
                    throw new IndexOutOfRangeException("索引超出范围");
                list[index] = value;
            }
        }

        //添加元素
        public void Add(T item)
        {
            if (Capacity == 0)
            {
                list = new T[4];
            }
            if (count >= Capacity)
            {
                T[] temp = new T[Capacity * 2];
                for (int i = 0; i < list.Length; i++)
                {
                    temp[i] = list[i];
                }
                list = temp;
            }
            list[count] = item;
            count++;
        }

        //插入
        public void Insert(int index, T item)
        {
            if (index > count || index < 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                if (Capacity == 0)
                {
                    list = new T[4];
                    list[index] = item;
                    count++;
                }
                if (count >= Capacity)
                {
                    T[] temp = new T[Capacity * 2];
                    for (int i = 0; i < list.Length; i++)
                    {
                        temp[i] = list[i];
                    }
                    list = temp;
                }
                for (int i = count; i > index; i--)
                {
                    list[i] = list[i - 1];
                }
                list[index] = item;
                count++;
            }
        }

        //删除
        public void RemoveAt(int index)
        {
            if (index > count - 1 || index < 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                if (Capacity == 0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    for (int i = index; i < count - 1; i++)
                    {
                        list[i] = list[i + 1];
                    }
                    count--;
                }
            }
        }

        //查找从前往后
        public int IndexOf(T item)
        {
            int index = -1;
            for (int i = 0; i < count; i++)
            {
                if (item.Equals(list[i]))
                {
                    index = i; break;
                }
            }
            return index;
        }

        //从后往前
        public int LastIndexOf(T item)
        {
            int index = -1;
            for (int i = count - 1; i >= 0; i--)
            {
                if (item.Equals(list[i]))
                {
                    index = i; break;
                }
            }
            return index;
        }

        //排序从小到大
        public void Sort()
        {
            Array.Sort(list, 0, count);
        }
    }
}