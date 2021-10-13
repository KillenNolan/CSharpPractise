using System;
using CSharpLesson_3_2;
         

namespace Lesson_02_AcessModifier_1
{

    /// <summary>
    /// 共有的写在父类中
    /// </summary>
    class Person
    {
        public string name;
        public int age;
        public char sex;

        public void Show()
        {
            Console.WriteLine("I'm {0}, {1}. I'm {2} years old.", name, sex, age);
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
            Test test = new Test();
            test.ShowTest();

            ///代码块，用法得当，可提高代码效率
            {
                int a = 10;
                int b = a + 10;
            }
        }
    }
}
