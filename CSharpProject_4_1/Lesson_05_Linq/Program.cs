using System;

/// <summary>
/// 前四小节使用的数据对象都是object，是非类型安全的，会有以下问题：
/// 1.object类型是一切类型的父类
/// 2.通过继承，子类拥有父类的一切属性和行为，任何父类出现的地方，都可以用子类来代替。
/// 但上面object类型的方法又会带来另一个问题：拆箱和装箱，会损耗程序的性能
/// int  <----------- object 装箱
/// int  -----------> object 拆箱
/// 微软在C#2.0的时候推出了泛型，可以很好的解决上面的问题。
/// 泛型
/// </summary>
namespace Lesson_05_Generic
{
    class Person<T>
    {
        public T t;
    }


    /// <summary>
    /// 泛型约束：
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Student<T> : Person<T>
    {
        public T t2;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Program.Test(3);
             Program.Test(2.56);
             Program.Test("Killen");*/


            Person<int> person = new Person<int>();
            person.t = 12;


            Person<string> lisi = new Person<string>();
            lisi.t = "123";


            Student<int> s = new Student<int>();
            s.t2 = 12;
            s.t = 10;




        }

        /// <summary>
        /// 比拆箱，装箱效率高得多
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        static void Test<T>(T t)
        {
            Console.WriteLine(t);
        }

        static void Test2<T, U>(T t, U u)
        {
            Console.WriteLine(t);
        }
    }
}
