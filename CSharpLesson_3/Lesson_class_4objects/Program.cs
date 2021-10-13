using System;

namespace Lesson_class_4objects
{
    class Person
    {
        public string name;
        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }
    }


    // 用结构体写一个奥特曼大战怪兽   值类型     传递值
    // 用类写一个奥特曼大战怪兽       引用类型   传递地址
    class AltMan
    {
        public string name;
        public int atk;
        public int hp;
    }

    class Program
    {
        static void Main(string[] args)
        {   //栈小堆大
            Person killen = new Person();

        }
    }
}
