using System;

/// <summary>
/// 子类和父类同名
/// 如果在子类中声明的一个成员，与父类中重名，将默认启用new关键字，
/// 将会为这个新的成员申请一个新的空间，而父类中的成员将会被隐藏(也就是子类中的同名方法或者变量会覆盖父类中的)
/// （什么类的对象则调用什么类的方法。没有多态的前提下）
/// </summary>
namespace Lesson_04_DuplicateName
{  /// <summary>
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
        public float heigh;
        public string major;
        public Student(string name, int age, char sex, float heigh, string major) : base(name, age, sex)
        {
            this.heigh = heigh;
            this.major = major;
        }
        public void Show()
        {
            Console.WriteLine("student,name:{0},age:{1},heigh:{2}", name, age, heigh);
        }

        public void SayHello()
        {
            Console.WriteLine("student,name:{0},age:{1},heigh:{2}", name, age, heigh);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Killen", 25, 'F', 160, "Computer");
            student.Show();


            Person person = new Person("KK", 22, 'M');
            person.Show();
        }
    }
}
