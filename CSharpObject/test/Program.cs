using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
         static class  Aniaml
        {
            public static void say()
            {
                Console.WriteLine("i am a animal");
            }
            public static void walk()
            {
                Console.WriteLine("walk fast");
            }

        }
        class Pet
        {
            public delegate void display1();
            public display1 a;
            private string _name;
            public Pet(string name)
            {
                this._name = name;
                a += Aniaml.say;
            }
            public void pritName()
            {
                a();
                Console.WriteLine("my name is " + _name);
            }      

        }
        class Dog :Pet
        {
            public Dog(string name) : base(name)
            {
                
            }
            public void doSomething()
            {
                a += Aniaml.walk;
                a();
                

            }  
        }
        static void Main(string[] args)
        {
            Dog pet = new Dog("pet");
            pet.pritName();
            pet.doSomething();
            Console.ReadKey();
        }
    }
}
