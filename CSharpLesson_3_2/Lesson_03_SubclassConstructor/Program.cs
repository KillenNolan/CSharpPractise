using System;

/// <summary>
/// 子类的无参构造函数需要继承父类的无参构造函数
/// 子类构造函数可以指向父类构造函数（相同类用this，父类用base)
/// </summary>
namespace Lesson_03_SubclassConstructor
{
    /// <summary>
    /// 共有的写在父类中
    /// </summary>
    class Person
    {
        public string name;
        public int age;
        public char sex;
        public float heigh;

        public Person() { }


        public Person(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        /// <summary>
        /// 重载构造函数的一种那个方式
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="sex"></param>
        /// <param name="heigh"></param>
        public Person(string name, int age, char sex, float heigh) : this(name, age, sex)
        {
            this.heigh = heigh;
        }

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
        public string major;
        public Student(string name, int age, char sex, string major) : base(name, age, sex)
        {
            this.major = major;
        }

        public void SayHello()
        {
            Console.WriteLine("student,name:{0},age:{1}", name, age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Killen", 25, 'F', 150);
        }
    }
}
