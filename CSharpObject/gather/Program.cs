using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gather
{
    //集合：就是存放多个数据的容器类型，比如数组Array；
    //预定义的常用集合
    // 动态数组：ArrayList  
    //列表：List
    //字典：Dictionary
    //队列：Queue
    //栈：stack

    class Program
    {   class Monkey
        {
            public string name;
            public Monkey(string name)
            {
                this.name = name;
            }
            public void pritName()
            {
                Console.WriteLine("my name is " + name);
            }
        }
        static void Main(string[] args)
        {
            //1.Array
            //数组大小固定，数组项类型一样
            int[] a = new int[2];
            a[0] = 10;
            a[1] = 12;
            for (int i = 0;i<a.Length;i++)
            {
                Console.WriteLine("a[{0}]:{1}", i, a[i]);
            }

            //2.ArrayList
            //初始化可以不指定大小，Count属性获取长度，Add添加，Remove/RemoveAt删除，访问[index]
            //数组里面的每一项类型可以不一样
            ArrayList arrList = new ArrayList();
            arrList.Add(10);
            arrList.Add(new Monkey("a"));
            for (int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine("arrList[{0}]:{1}", i, arrList[i].ToString());
            }

            //List<T>
            List<string> b = new List<string>();
            b.Add("wang");
            b.Add("cheng");
            int len = b.Count;
            b.RemoveAt(1);


            //Dictionary<TKey,TValue>
            //字典容器存储的是一系列的键值对，每个值对应一个唯一的键，可以通过键高效的访问到值
            //数量Count，添加Add(key,val)，删除Remove，访问[Key]
            Dictionary<string, Monkey> dic = new Dictionary<string, Monkey>();
            dic.Add("A", new Monkey("A"));
            dic.Add("B", new Monkey("B"));
            dic["A"].pritName();
            dic["B"].pritName();

            //stack:先进后出
            //出栈：Pop
            //入栈：Push
            //获取栈顶元素：Peek
            Stack<Monkey> sta = new Stack<Monkey>();
            sta.Push(new Monkey("A"));
            sta.Push(new Monkey("B"));
            sta.Peek().pritName();
            sta.Pop();
            sta.Peek().pritName();

            //Queue:先进先出的集合容器
            //出队：Dequeue；
            //入队：Enqueue；
            Console.ReadKey();
        }
    }
}
