using System;

namespace Lesson_01_3EmployeeTest
{

    class Employee
    {
        public string name;
        public Employee(string name)
        {
            this.name = name;
        }

        public virtual void Mark()
        {
            Console.WriteLine("9点打卡,{0}",name);
        }
    }
    

    class HR : Employee
    {
        public string major;
        public HR(string name,string major):base(name)
        {
            this.major = major;
        }
    }

    class Manager:Employee
    {
        public Manager(string name) : base(name) { }
        public override void Mark()
        {
            Console.WriteLine("11点打卡，{0}",name);
            //base.Mark();
        }
    }



    class Programer : Employee
    {
        public Programer (string name) : base(name) { }

        public override void Mark()
        {
            Console.WriteLine("程序员不用打卡,{0}",name);
            //base.Mark(); 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[3];
            employees[0] = new HR("HR","");
            employees[1] = new Manager("M");
            employees[2] = new Programer("P");

            foreach (var item in employees)
            {
                item.Mark();
            }

        }
    }
}
