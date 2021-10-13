using System;

namespace Lesson_01_2Teacher
{

    class Human
    {
        public string name;
        public int age;
        public char sex;
        public Human(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

    }


    interface IAction
    {
        void CollectWork();
    }

    interface IActionSWork
    {
        void CollectWork();
    }

    class HeadMaster : Human
    {
        public HeadMaster(string name, int age, char sex) : base(name, age, sex)
        {
        }
    }


    class Teacher : Human, IAction, IActionSWork
    {
        public Teacher(string name, int age, char sex) : base(name, age, sex)
        {
        }

        public void CollectWork()
        {
            Console.WriteLine("Teacher {0} collect ordinary homework.", name);
        }

        /// <summary>
        /// 显示实现接口
        /// </summary>
         void IActionSWork.CollectWork()
        {
            Console.WriteLine("Teacher {0} collect special homework.",name);
        }

    }

    class Student : Human,IAction
    {
        public string position;
        public Student(string name, int age, char sex, string position) : base(name, age, sex)
        {
            this.position = position;
        }

        public void CollectWork()
        {
            Console.WriteLine("Student {0} collect homework.", name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IAction _action = new Student("Killen",25,'F',"matser");
            _action.CollectWork();


            IAction _lisi = new Teacher("LL", 29, 'M');
            _lisi.CollectWork();
            if (_lisi  is IActionSWork)
            {
                (_lisi as IActionSWork).CollectWork();
            }
        }
    }
}
