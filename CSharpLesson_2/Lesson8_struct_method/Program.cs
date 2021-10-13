using System;

namespace Lesson8_struct_method
{
    class Program
    {

        struct Person
        {
            public string name;
            public int age;
            public char sex;


            /// <summary>
            /// 构造函数
            ///     1. 函数名和结构体名必须 一模一样
            ///     2. 结构体中不能有无参数的够着函数：系统默认有个无参构造函数
            ///     3. 构造函数必须对 结构体中 所有属性赋值 
            /// </summary>
           /* public Person(string name, int age)
            {
                // this代表当前构造函数构造出来的对象
                this.name = name;
                this.age = age;
                this.sex = 'M';
            }*/
            public Person(string strName, int age, char sex)
            {
                // this代表当前构造函数构造出来的对象
                this.name = strName;
                this.age = age;
                this.sex = sex;
            }

            /// <summary>
            /// Person的功能，函数，方法
            /// </summary>
            public void Speak()
            {
                Console.WriteLine("Name:{0},Age:{1},Sex:{2}", name, age, sex);
            }
        }
        static void Main(string[] args)
        {
            //Person person = new Person();
            Person person = new Person("Killen", 18, 'F');
            person.Speak();
        }
    }
}
