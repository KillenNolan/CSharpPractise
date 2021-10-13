using System;

namespace CSharpLesson_3_4
{
    /// <summary>    
    /// 接口可以包含方法、属性、事件和索引器。
    /// 接口是多继承的，一个接口可以继承另一个或者多个接口，一个类可以继承一个或多个接口。
    /// 
    /// 优势：让类更灵活，降低代码关联性
    /// 劣势：
    /// </summary>
    interface ISpeak
    {
        void Test()
        {
            Console.WriteLine("I speak");
        }

        void Speak();
    }


    interface IMove
    {
        void Move();
    }

    class Animal
    {

    }

    class Person : Animal, ISpeak, IMove
    {

        public string name;


        public Person(string name)
        {
            this.name = name;
        }
        public void Move()
        {
            Console.WriteLine("{0}在走路", name);
        }

        public void Speak()
        {
            Console.WriteLine("{0}在说话", name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ISpeak s = new Person("killen");
            s.Test();
            s.Speak();
            if (s is IMove)
            {
                (s as IMove).Move();
            }
        }
    }
}
