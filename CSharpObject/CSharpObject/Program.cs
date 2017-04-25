using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpObject;

namespace CSharpObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //子类继承父类，掩藏基类属性方法
            //Dog dog = new Dog();
            //dog.name = "Jack";
            //dog.printName();
            //Cat cat = new Cat();
            //cat.name = "Tom";
            //cat.printName();
            //Console.ReadKey();

            //通过指向派生类的基类引用，我们仅仅能访问派生类中的基类部分
            //Pet dog = new Dog();
            //dog.name = "Jack";
            //dog.printName();//调用基类中的方法
            //dog.speak();
            //Pet cat = new Cat();
            //cat.name = "Tom";
            //cat.printName();
            //cat.speak();
            //Console.ReadKey();

            //同意提高效率，通过一个容器（比如数组），保存所有的基类（Pet），描述共同的属性和行为，方便管理容易扩展
            //Pet[] pets = new Pet[] { new Dog("Jack"), new Cat("Tom") };
            //for (int i = 0; i < pets.Length; i++)
            //{
            //    pets[i].speak();
            //    pets[i].eat();
            //}
            //Console.ReadKey();

            //
            //Cat c = new Cat("Tom2");
            //ICatchMice catchM= (ICatchMice)c;
            //IClimbTree climb = (IClimbTree)c;
            //c.catchMice();
            //c.climbTree();
            //catchM.catchMice();
            //climb.climbTree();
            //Console.ReadKey();

        }
    }
}
