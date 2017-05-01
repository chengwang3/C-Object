using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
   // 类的静态成员：标识为static的字段，属性，方法，构造函数，事件，就是静态成员
   //静态成员将被类的所有实例共享，所有实例都访问同一内存位置
   //静态成员直接通过类名访问
   public class Dog
    {
        public string name;
        static public int count;
        //静态构造函数用于初始化静态字段
        //在引用任何静态成员之前，和创建任何实例之前调用
        //与类同名，无访问修饰符，无参数，使用static；
        static Dog()
        {
            count = 0;
        }
        public Dog(string name)
        {
            this.name = name;
            count++;
        }
        //静态函数独立与任何实例，没有实例也可以调用
        //不能访问实例成员，仅能访问其它静态成员
        static public void showNum()
        { 
            Console.WriteLine("2狗的数量是：" + count);
        }
    }

    //静态类：1只包含静态的属性和方法，并且标识为static  2不能创建实例，不能被继承  3可以为静态内定义一个静态构造函数
    //静态类用于基础类库和扩展方法
    
    //如何扩展方法
    //如果有源代码，直接添加新方法
    //如果不能修改但也不是密闭类，可以派生子类扩展
    //如果以上条件都不满足，可以使用静态类扩展方法

    static class PetGuide
    {
        //扩展Dog类的方法
        static public void howFeed(this Dog dog)
        {
            Console.WriteLine("give Feed to Pet");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("tom");
            Dog dog2 = new Dog("jack");
            Console.WriteLine("狗的数量："+Dog.count);
            Dog.showNum();
            dog1.howFeed();
            Console.ReadKey();
        }
    }
}
