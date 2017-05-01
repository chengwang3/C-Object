using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classT
{
    //泛型类：泛型类就是一个模子，装入类型的材料，可以塑造出想要的产品
    //优势：代码量更小，只有需要的类型才会被实例化；易于维护，修改模板，所有的实例都将改变
    //class Cage<T> 填充对应的宠物类型，得到专属的笼子
    //{
    //    T[] petArr;
    //    public void putIn(T pet)
    //    {

    //    }
    //    public T takeOut()
    //    {

    //    }
    //}
    //Cage<Dog> dogCage;  Cage<Dog>类型的引用
    //dogCage = new Cage<Dog>();构造实例

    //泛型接口：允许我们将接口成员的参数和返回类型设置为泛型参数的接口
    //语法
    //interface IMySelf<T>
    //{
    //    T MySelf(T self);
    //} 
    //实现泛型接口语法
    //class A : IMySelf<A> 类型参数可以是实现类本身或者是其他类型
    //{
    //    public A MySelf(A self)
    //    {

    //    }
    //}


    //泛型方法：就是方法的模型，给定具体的类型，就可以实例化出一个操作该类型的具体方法
    //class Dog
    //{
    //    void dogIsHappy<T>(T target)
    //    {

    //    }
    //}

    //约束：只有添加了约束，才能调用泛型参数中（比如T）的方法
    //约束的类型：类名（该类或者继承该类的类），Class（任何类），Struct（任何值），接口名（该接口类型或实现该接口的类型），new()（带有无参共有构造函数的类）
    //约束叠加规则：A主约束（类名，class，struck，只能有一个）B接口约束（任意多个） C构造约束
    class Pet
    {
      virtual public void PrinName()
        {
            
        }
    }
    class Dog:Pet
    {
        public string name;
        public Dog(string name)
        {
            this.name = name;
        }
        public override void PrinName()
        {
            Console.WriteLine("打印狗名字：" + name);
        }
    }
    class Cat:Pet
    {
        public string name;
        public Cat(string name)
        {
            this.name = name;
        }
        public override void PrinName()
        {
            Console.WriteLine("打印猫名字：" + name);
        }
    }
    class Cage<T>where T:Pet
    {
        public List<T> petArr = new List<T>();
        public void PutIn(T pet)
        {
            petArr.Add(pet);
            pet.PrinName();//因为约束了T为Pet类或其派生类，所以能调用该类的方法
        }
        public void takeOut(int index)
        {
            petArr.RemoveAt(index);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cage<Dog> dogCage;//定义一个泛型参数为Dog的Cage类变量
            dogCage = new Cage<Dog>();//实例化一个狗笼子的对象
            dogCage.PutIn(new Dog("A"));
            Console.WriteLine("放入狗笼子里狗的数量：" + dogCage.petArr.Count + "狗的名字" + dogCage.petArr.First().name);


            Cage<Cat> catCage = new Cage<Cat>();
            catCage.PutIn(new Cat("miao"));
            Console.WriteLine("放入猫笼子里猫的数量：" + catCage.petArr.Count + "猫的名字" + catCage.petArr.First().name);
            Console.ReadKey();


        }
    }
}
