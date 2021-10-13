using System;

/// <summary>
/// 如果实例方法声明中有virtual修饰符，可以将实例方法称为“虚方法”
/// 什么叫覆盖方法？什么叫重写方法?==>我的理解是同一个意思。
/// 重写返回类型相同，签名相同且同名虚方法
/// 签名：是指函数访问修饰符，参数个数，返回类型，以及函数名称都相同。
/// </summary>

namespace Lesson_01_1virtualMethod
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

        public void SayHello()
        {
            Console.WriteLine("Person,name:{0},age:{1}", name, age);
        }


        public virtual void Work()
        {
            Console.WriteLine("I'm an Adult, I need to Work");
        }

    }



    class Student : Person
    {
        public string major;
        public Student(string name, int age, string major) : base(name, age)
        {
            this.major = major;
        }

        public void SayHello()
        {
            Console.WriteLine("Student,name:{0},major:{1}", name, major);
        }

        /// <summary>
        /// 重写父类虚方法，用override修饰符；
        /// 重写返回类型相同，签名相同且同名虚方法
        /// </summary>
        public override void Work()
        {
            // 调用父类中的方法
            // base.Work();
            Console.WriteLine("I'm a student, my current work is studying.");
        }
    }



    class Teacher : Person
    {
        public int salary;
        public Teacher(string name, int age, int salary) : base(name, age)
        {
            this.salary = salary;
        }

        public  sealed override void Work()
        {
            Console.WriteLine("I'm a teacher, my work is teaching");
            //base.Work();
        }

    }




    class UnityTeacher : Teacher
    {
        public string skills;
        public UnityTeacher(string name, int age, int salary,string skills) : base(name, age, salary)
        {
            this.skills = skills;
        }

        ///// <summary>
        ///// 当父类中有sealed修饰词，子类就不能用override修饰词重写了
        ///// </summary>
        //public override void Work()
        //{
        //    //base.Work();
        //}
    }


    class Program
    {
        static void Main(string[] args)
        {

            /*  Student student = new Student("Student", 25, "IT");
              student.SayHello();
              Person person = student;
              person.SayHello();*/



            /*// 里式转换
            Person person = new Student("Student", 25, "IT");
            //普通方法，是数据类型 Person person 决定调用什么类中的方法
            //虚方法，是内核 new Student("Student", 25, "IT") 决定调用什么方法。
            person.SayHello();
            if (person is Student)
            {
                (person as Student).SayHello();
            }*/



            //普通方法，是数据类型 Person person 决定调用什么类中的方法
            //虚方法，是内核 new Student("Student", 25, "IT") 决定调用什么方法。
            Person person = new Student("Student", 25, "IT");
            person.Work();

            Person person1 = new Person("Student", 25);
            person1.Work();

        }
    }
}
