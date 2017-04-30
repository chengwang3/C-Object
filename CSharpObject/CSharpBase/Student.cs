using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnCsharp
{
    //枚举是一组命名的整型常量。枚举类型使用 enum 关键字声明。
    //C# 枚举是值的数据类型。换句话说，枚举包含它自己的值，不能继承或被继承。
    //枚举中不能定义字段属性和方法
    //枚举值是从0递增的整数
   public enum Sex{
        男,女
    }
    //关键字 class 声明
    //如果没有说明，则默认访问的类的类型为 internal对成员的默认访问类型是 private 。
    public class Student
    {
        //访问修饰符
        //Public 访问修饰符允许一个类将其成员变量和成员函数暴露给其他的函数和对象。任何公有成员可以被外部的类访问。
        //Private 访问修饰符允许一个类将其成员变量和成员函数对其他的函数和对象进行隐藏。只有同一个类中的函数可以访问它的私有成员。即使是类的实例也不能访问它的私有成员。
        //Protected 访问修饰符允许子类访问它的基类的成员变量和成员函数。这种方式有助于实现继承
        //Internal 访问修饰符允许一个类将其成员变量和成员函数暴露给当前程序中的其他函数和对象。换句话说，带有 Internal 访问修饰符的任何成员可以被定义在该成员所定义的应用程序内的任何类或方法访问。
        //Protected internal 访问修饰符允许一个类将其成员变量和成员函数对同一应用程内的子类以外的其他的类对象和函数进行隐藏。这也被用于实现继承。
        //
        private string _className = "3(2)班";//private 访问修饰符，不能被外部访问；className字段，被赋值
        
        private int _age;

        /// <summary>
        /// 年纪
        /// </summary>
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value>=12 && value<=15)
                {
                    _age = value;
                }
                
            }
        }
        private Sex _sex;
        /// <summary>
        /// 性别
        /// </summary>
        public Sex Sex
        {
            get
            {
                return _sex;
            }

            set
            {            
               _sex = value;                          
            }
        }
        public string Name { get; set; }

        public string ClassName
        {
            get
            {
                return _className;
            }
        
        }
        /// <summary>
        /// 爱好
        /// </summary>
        /// <param name="sport">运动项目</param>
        public void love(string sport)
        {
            Console.WriteLine("我喜欢：{0}", sport);
        }
        /// <summary>
        /// 爱好 方法重载：同一个类中，多个方法名字相同但参数不同—参数的个数不同或类型不同；
        /// </summary>
        /// <param name="count">爱好的个数</param>
        public void love(int count)
        {
            if (count>3)
            {
                Console.WriteLine("你喜爱的运动项目很广泛");
            }else
            {
                Console.WriteLine("你喜爱的运动项目较少");
            }
        }

        //构造方法的作用：为属性赋值；
        //如果没有显示定义构造方法，则会有一个默认的无参数构造方法
        //如果显示定义构造方法，则没有默认构造方法
        //只能用new 构造方法名() 的形式调用构造方法；
        //构造方法没有返回值类型，且构造方法名与类名相同
        public Student(string name)
        {
            this.Name = name;
        }
        /// <summary>
        /// 构造方法重载
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">名字</param>
        public Student(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Student()
        {

        }
    }


    //结构：struct关键字声明，属于值类型
    //结构体可以有方法，域，属性，索引器，操作方法，和事件。
    //1.字段不能被初始赋值 2.不能包含显示的无参数的构造函数 3.有构造方法，则必须在构造方法中为所有字段赋值 4.可以不必实例化，直接声明
    //结构体不能继承其他的结构体或这其他的类
    //结构体不能用于作为其他结构或者类的基
    //结构体可以有方法，域，属性，索引器，操作方法，和事件。
    //结构体成员不能被指定为抽象的，虚拟的，或者保护的对象。
    //结构体可以实现一个或多个接口。
    //使用 New 运算符创建结构体对象时，将创建该结构体对象，并且调用适当的构造函数。与类不同的是，结构体的实例化可以不使用 New 运算符。
   //如果不使用 New 操作符，那么在初始化所有字段之前，字段将保持未赋值状态，且对象不可用。
    struct Book
    {
        public string title;
        public string author;
        public string subject;
        public int book_id;

        //有构造方法，则必须在构造方法中为所有字段赋值
        public Book(string title,string author, string subject, int book_id)
        {
            this.author = author;
            this.book_id = book_id;
            this.subject = subject;
            this.title = title;
        }
    }
}
