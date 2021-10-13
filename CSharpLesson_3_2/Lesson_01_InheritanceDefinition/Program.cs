using System;

namespace Lesson_01_InheritanceDefinition
{


    /// <summary>
    /// 共有的写在父类中
    /// </summary>
    class Person
    {
        public string name;
        public int age; 

        public void Show()
        {
            Console.WriteLine("name:{0},age:{1}", name, age);
        }
    }


    /// <summary>
    /// 特有写在子类中
    /// </summary>
    class Student : Person
    {
        public void SayHello()
        {
            Console.WriteLine("student,name:{0},age:{1}", name, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.age = 10;
            student.name = "Killen";
            student.Show();
            student.SayHello();
        }
    }
}
