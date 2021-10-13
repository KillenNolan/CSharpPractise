using System;

namespace Lesson_03_1ToString
{
    class Person : Object
    {
        public string name;
        public int age;

        public override string ToString()
        {
            return string.Format("name:{0},age:{1}",name,age);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            string s = x.ToString();


            Person person = new Person();
            person.name = "KIllen";
            person.age = 20;
            Console.WriteLine(person);

            // 我希望的输出 name:Killen,age:20

        }
    }
}
