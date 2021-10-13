using System;

/// <summary>
/// 什么类的对象，就调用什么类的方法（除开多态）。
/// </summary>
namespace Lesson_05_1RichterReplacement
{/// <summary>
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
            Console.WriteLine("Person, I'm {0}, {1}. I'm {2} years old.", name, sex, age);
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

    class Teacher:Person
    {
        public void SayHello()
        {
            Console.WriteLine("I'm a teacher");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //子类对象---》父类对象 ：则子类中的的特有属性则无法使用。
            Student student = new Student("Killen", 25, 'F', 1.8f, "Csharp");
            student.Show();//调用的是子类的show方法
            student.major = "C#";

            Person p = student;
            p.Show();//调用的是父类中的show方法
            //p.major="" //则子类中的的特有属性则无法使用 
             Person li= new Student("Killen", 25, 'F', 1.8f, "Csharp");
             */


            //什么类的对象，就调用什么类的方法（除开多态）。

            /* 
             //父类对象---》子类对象（风险很大）
             //编译虽然通过了，但运行时会报错。
              Person person = new Person("KK", 25, 'M');
              Student student =(Student) person;
              student.major = "";
            */

            /* //父类对象---》子类对象（风险很大）
             //外壳是person      内核是student对象
             Person person = new Student("Killen", 25, 'F', 1.8f, "Csharp");
             person.Show();//调用的是父类的show函数
             ((Student)person).major = "C#";
             Student s = (Student)person;
             s.Show();//调用的是子类的show函数
        */



            // is as 判断是否可做里式转换 
            // is 表示类型转换 ，转换成功返回true，不成功，返回false
            // as 表示类型转换，转换成功则返回对应的对象，不成功，返回null
            Person p1 = new Person("KK", 25, 'M');
            if (p1 is Student)
            {

            }
            else
            {
                Console.WriteLine("不能转化");
            }


            Person p2 = new Student("Killen", 25, 'F', 1.8f, "Csharp");
            if (p2 is Student)
            {
                //强制转换很危险，容易出错
                Console.WriteLine(((Student)p2).name);
            }


            Person p3 = new Teacher();
            p3.name = "KK";
            Student s = p3 as Student;
             
        }
    }
}
