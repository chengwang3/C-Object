using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//面向对象编程中，都遵循一个原则：依赖倒置原则。换句话说就是程序设计要依赖于抽象类(Pet),而不依赖具体类(Dog);
namespace CSharpObject
{
    //Object是所有类的共同基类，他是唯一的非派生类，是继承层次结构的基础

    //抽象类的存在只有一个目的，就是被继承
    //抽象类不能实例化，用abstract修饰
    //抽象类可以包含抽象成员和普通成员，以及他们的任意组合
    //抽象类的抽象成员在派生类中需要用override关键字实现
    abstract public class Animal
    {   
        //必须是方法，属性，事情，索引
        //必须用abstact修饰符标记
        //抽象方法不能有实际的函数体
        abstract public void eat();
    }
    //pet基类
    public class Pet: Animal
    {
        protected string _name;
        public Pet(string name)
        {
            this._name = name;
        }
        public void printName()
        {
            Console.WriteLine("my name is {0}", _name);
        }
        //虚方法：声明为virtual的方法就是虚方法。基类的虚方法可以在派生类中使用override重写
        //多态：通过指向派生类的基类引用，调用虚函数，会根据引用所指向派生类的实际类型，调用派生类中的同名重写函数，便是多态
       
        virtual public void speak()
        {
            Console.WriteLine(_name + "speak");
        }
        public override void eat()
        {
            Console.WriteLine(_name + "is eatting");
        }
    }
    //Dog 子类 继承父类的属性方法，只能继承一个父类
    public class Dog :Pet
    {
        public Dog(string name):base(name)
        {
        }
        //隐藏方法：我们不能删除基类中的任何成员，但是可以用与基类成员名称相同的成员来屏蔽基类成员
        //方法：1-屏蔽数据成员：在派生类中声明名称和类型相同的成员
        //      2-屏蔽函数成员：在派生类中声明新的带有相同函数签名的成员
        //      3-让编译器知道：可以添加new关键字，否则会有警告

        new public void printName()
        {
            Console.WriteLine("我的名字是：" + _name);
        }

        //1.重写虚方法必须具有相同的可访问性，且基类不能是private
        //2.不能重写static方法，或非虚方法
        //3.方法，属性，索引器，事件，都可以声明为virtual和override
        public override void speak()
        {
            Console.WriteLine(_name + "is speaking"+"汪汪");
        }

    }
    //接口就是指定一组函数成员，而不实现他们的引用类型，只能用来被实现

    interface ICatchMice
    {
        void catchMice();
    }
    interface IClimbTree
    {
        //默认public，不能加任何访问修饰符
        void climbTree();
    }
    public class Cat : Pet,ICatchMice,IClimbTree
    {
        public Cat(string name):base(name)
        {
        }
        //密闭类：声明为sealed的类 不希望其他人通过继承来修改
        //密闭方法：声明为sealed的方法 不希望其他人重写该方法
        //sealed密闭方法：如果一个基类方法不希望子类对其重写，就可以不声明为virtual，如果是某个派生类方法不希望子类对其重写，同时是override重写，就可以使用sealed机制
        public sealed override void speak()
        {
            Console.WriteLine(_name + "is speaking" + "喵喵");
            
        }
        public void catchMice()
        {
            Console.WriteLine(_name + " is catching Mice");
        }
        public void climbTree()
        {
            Console.WriteLine(_name + " is like climbTree");
        }
    }
}
