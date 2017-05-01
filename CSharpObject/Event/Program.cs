using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{   //通知某件事情发生的,就是发布者
    //对某件事情关注的,就是订阅者
    //事件触发和注册
    //事件发生时,会通知所有关注该事件的订阅者
    //想在事件发生时被通知,必须注册以表示关注
    //事件声明
    //例子:
    //delegate void Handle();声明一个委托类型
    //public event Handle NewDog;声明一个委托类型的事件名
    //NewDog += 方法名（方法可以是实例方法，静态方法，匿名方法，lamada表达式） +=订阅方法
    class Dog
    {
        public delegate void Handle();//声明一个委托类型
        public static event Handle Seen;//声明一个委托类型的事件；
        public string name;
        public static int num;
        public Dog(string name)
        {
            this.name = name;
            num++;
            if (Seen != null)
            {
                Seen();//当事件订阅不为空时，事件触发；
            }
        }
        static Dog()
        {
            num = 0;
        }
    }
    //声明委托
   
    
    class Client
    {
        public string name;
        public Client(string name)
        {
            this.name = name;
        }
        public void wangADog()
        {
            Console.WriteLine(name + " want to see the new dog");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client("Jack");
            Client c2 = new Client("Bob");
            Dog.Seen += c1.wangADog;//订阅事件c1.wangADog
            Dog.Seen += c2.wangADog;//订阅事件c2.wangADog
            Dog dog = new Dog("Q");
            Console.ReadKey();

        }
    }
}
