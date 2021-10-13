using System;

namespace Lesson_1_delegate_demo2
{

    public delegate void DoThing();
    class Teacher
    {
        public string name;
        public Teacher(string name)
        {
            this.name = name;
        }

        public DoThing doThing;

        /// <summary>
        /// 供学生注册的方法
        /// </summary>
        public void Register(DoThing thing)
        {
            if (thing == null)
            {
                doThing = new DoThing(thing);
            }
            else
            {
                doThing += thing;
            }
        }

        /// <summary>
        /// 老师打铃
        /// </summary>
        public void Ding()
        {
            // 触发委托
            if (doThing != null)
            {
                doThing();
            }
        }
    }
    class Student
    {
        public string name;
        public string doSomething;
        public Student(string name, string doSomething)
        {
            this.name = name;
            this.doSomething = doSomething;
        }
        public void Do()
        {
            Console.WriteLine("下课了，{0}要去 {1}", name, doSomething);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Teacher t = new Teacher("Teacher");

            Student s1 = new Student("Json","Buy things");
            Student s2 = new Student("Killen", "Dancing");

            t.Register(s1.Do);
            t.Register(s2.Do);

            t.Ding();
        }
    }
}
