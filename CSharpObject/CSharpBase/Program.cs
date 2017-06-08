using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using learnCsharp;

namespace learnCsharp
{ 


    class Program
    {
        //使用ref 可以将值类型参数，按引用传递
        //不使用ref，形参的值修改，实参的值不变；
        static void groth(ref int age)
        {
             age++;
            Console.WriteLine("myAge:{0}", age);

        }
        
        //return 返回一个值，out返回多个值
        /// <summary>
        /// 计算年纪
        /// </summary>
        /// <param name="age">现在的年纪</param>
        /// <param name="lastYear">去年的年纪</param>
        /// <param name="nextYear">明年的年纪</param>
        static void groth(int age,out int lastYear,out int nextYear)
        {
            lastYear = age - 1;
            nextYear = age + 1;
        }
      
        static void Main(string[] args)
        {

            //Student wang = new Student("wang cheng");
            ////用对象初始化器初始化对象
            //Student wang1 = new Student() { Name = "wang jie" };
            //wang.Sex = (Sex)0;// Sex.男    
            //wang.Age = 14;
            //Console.WriteLine("我是" + wang.Name + ",性别：" + wang.Sex+",年纪："+wang.Age+"，来自"+wang.ClassName);
            //wang.love("踢足球");
            //Console.ReadKey();


            Student wang = new Student("wang cheng");
            //用对象初始化器初始化对象
            Student wang1 = new Student() { Name = "wang jie" };
            wang.Sex = (Sex)0;// Sex.男    
            int age = 14;
            groth(ref age);
            Console.WriteLine("myAge:{0}", age);
            int nowAg = 13;
            int ly, ny;
            groth(nowAg, out ly, out ny);
            Console.WriteLine("我今年的年纪是{0}，去年是{1}，明年是{2}", nowAg, ly, ny);
         


            //使用 New 运算符创建结构体对象
            Book book1 = new Book("追风筝的人", "AA", "情义", 002);
            Console.WriteLine("title:{0},author:{1},subject:{2},bookid:{3}", book1.title, book1.author, book1.subject, book1.book_id);
            //不使用 New 操作符，那么在初始化所有字段之前，字段将保持未赋值状态，且对象不可用
            Book book2;
            book2.title = "故乡";
            book2.author = "BB";
            book2.subject = "思念";
            book2.book_id = 003;
            Console.WriteLine("title:{0},author:{1},subject:{2},bookid:{3}", book2.title, book2.author, book2.subject, book2.book_id);
            //结构是值类型
            Book book3 = book1;
            book3.title = "你们";
            Console.WriteLine("book1 title:{0},author:{1},subject:{2},bookid:{3}", book1.title, book1.author, book1.subject, book1.book_id);//book1.title = "追风筝的人"
            Console.WriteLine("book3 title:{0},author:{1},subject:{2},bookid:{3}", book3.title, book3.author, book3.subject, book3.book_id);//book3.title = "你们"

            Console.ReadKey();
        }
    }
}
