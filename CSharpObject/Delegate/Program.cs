using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{

    class Program
    {
        //委托：就是持有一个或多个方法的对像，并且该对象可以执行，可以传递
        //声明委托类型：delegate 返回类型 类型名();
        //给委托对象赋值 委托类型名 委托对象名 = 方法名；
        
        class Dog
        {
            public string name;
            public Dog(string name)
            {
                this.name = name;
            }
            public void priName()
            {
                Console.WriteLine("my name is " + name);
            }
            public void speak()
            {
                Console.WriteLine("speak wang wang");
            }
        }
        delegate void Do();
        static void Main(string[] args)
        {
            Do a;
            Dog b = new Dog("tom");
            a = b.priName;
            a += b.speak;
            a();
            Console.ReadKey();

        }
    }
}
