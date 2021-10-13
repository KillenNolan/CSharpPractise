using System;


/// <summary>
/// 对象的生命周期
/// 怎么判断一个对象是被使用了呢?
/// </summary>
namespace Lesson_2_1objectsItsCycle
{

    class Person
    {
        public string name;
        public int age;
        public Person() { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // 析构函数:回收对象的堆空间
        ~Person()
        {
            Console.WriteLine(name + "析构函数");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person killen = new Person("Killen", 25);
            Console.WriteLine(killen.name);
            // 置空  拿掉它的指向,切断这个对象栈和堆的联系
            killen = null;

            // 手动调用内存回收 
            // GC:Garbage Collect
            GC.Collect();

        }
    }
}
