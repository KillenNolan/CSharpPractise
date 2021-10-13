using System;

namespace Lesson_01_InheritPractice
{

    class Person
    {
        public string name;
        public int age;
        public char sex;


        public Person() { }
        public Person(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public void Show()
        {
            Console.WriteLine("I'm {0}, {1}. I'm {2} years old.", name, sex, age);
        }
    }


    class Reporter : Person
    {

        public Reporter(string name,int age,char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public  void MakePhot()
        {
            Console.WriteLine("I'm a reporter, my name is {0}, {1}. I'm {2} years old. I like taking photo", name, sex, age);
        }
    }


    class Driver : Person
    {
        public Driver(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public void PlayBasketball()
        {
            Console.WriteLine("I'm a Driver, my name is {0}, {1}. I'm {2} years old. I like play basketball.", name, sex, age);
        }
    }


    class Programer : Person
    {
        public Programer(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }
        public void Moive()
        {
            Console.WriteLine("I'm a programer, my name is {0}, {1}. I'm {2} years old. I like going to moives.", name, sex, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Reporter reporter = new Reporter("Reporter",25,'M');
            Driver driver = new Driver("Driver", 22, 'F');
            Programer programer = new Programer("Programer", 20, 'M');
            reporter.Show();
            driver.Show();
            programer.Show();


            reporter.MakePhot();
            driver.PlayBasketball();
            programer.Moive();
        }
    }
}
