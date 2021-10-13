using System;

namespace Lesson_02_index
{

    /// <summary>
    /// 索引器适用于除自动属性外的所有属性特征
    /// </summary>
    class Person
    {
        public string name;
        public int age;
        char sex;

        public Person(string name, int age, char sex)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
        }

        /// <summary>
        /// 索引器的写法例子
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public string this[int x]
        {
            get
            {
                switch (x)
                {
                    case 0: return name;
                    case 1: return age.ToString();
                    case 2: return sex.ToString();
                    default: return "数据异常";
                }
            }
            set
            {
                switch (x)
                {
                    case 0: name = value; break;
                    case 1: age = int.Parse(value); break;
                    case 2: sex = char.Parse(value); break;
                    default:
                        break;
                }
            }
        }

    }
    class Program
    {


        static void Main(string[] args)
        {

            // this的用法：1.代表当前对象
            Person person = new Person("Killen", 25, 'F');
            Console.WriteLine(person.name);
            Console.WriteLine(person[1]);
            person[1] = "22";
            Console.WriteLine(person[1]);
        }
    }
}
