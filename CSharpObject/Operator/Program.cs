using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator
{
    //自定义转换：为自己的结构或类定义显示和隐士转化
    //目的：为了让我们自己的结构或类可以变成一个预期相关的类型，并且使这种转换变得更加简单
    public class Dog
    {
        public int age;
        public string name;
        public Dog(string name)
        {
            this.name = name;
            this.age = 0;
        }
        public void sayName()
        {
            Console.WriteLine("name:" + name);
        }
        //转换方法
        //前面必须是public static
        //implicit隐式 explicit显示
        //operator操作符
        public static implicit operator Cat(Dog dog)
        {
            return new Cat(dog.name);
        }
        //重载运算符：利用现有的某种运算符（不能创造新的运算符），针对自定义类或结构，定义某种运算符
        //目的：利用现有的运算符，简化自定义类型的操作。最好是，该运算符与该操作，具有一定的相关性
        //public static Dog operator +(Dog Male,Dog Female)
        //{
        //    .........
        //    return new Dog();
        //}
        public static Dog operator ++(Dog dog)
        {
            ++dog.age;
            return dog;
        }
    }
    public class Cat
    {
        public string name;
        public Cat(string name)
        {
            this.name = name;
        }
        public void sayName()
        {
            Console.WriteLine("name:" + name);
        }
        public static explicit operator Dog(Cat cat)
        {
            return new Dog(cat.name);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            //装箱：根据值类型的值，在堆上创建一个完整的引用类型对象，并返回对象的引用，是一种隐士转换
            //目的：有时候需要将值类型转换为引用类型(object)来进行统一的操作和统一的存储（object[]）
            int i = 3;
            int j = 4;
            object o = null;
            object o2 = null;
            o = i;
            o2 = j;
            //拆箱：将装箱后的对象转换为值类型的过程，是一种显示转换
            int x = (int)o;
            object[] orra = new object[] { o, o2 };
            Console.WriteLine(o.ToString());

            Dog dog = new Dog("wang wang");
            //隐式转账
            Cat cat = dog;
            cat.sayName();
            Cat cat1 = new Cat("miao miao");
            //显示转换
            Dog dog1 = (Dog)cat1;
            dog.sayName();

            Dog[] dogArr = new Dog[] { new Dog("dog1"), new Dog("dog2"), new Dog("dog3") };
            for (int a = 0;a<dogArr.Length;++a)
            {
                dogArr[a]++;
                Console.WriteLine(dogArr[a].name + "的年纪是" + dogArr[a].age);
            }

            Console.ReadKey();
        }
      
    }
}
