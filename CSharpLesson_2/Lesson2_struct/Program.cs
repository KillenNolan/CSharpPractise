using System;

namespace Lesson2_struct
{
    class Program
    {
        /// <summary>
        /// 结构体不能定义在函数里面，要在函数外面。
        /// </summary>
        struct Person
        {
            public string name;
            public int age;
            public char sex;
            public Person(string name, int age, char sex)
            {
                this.name = name;
                this.age = age;
                this.sex = sex;
            }

        }

        struct Student
        {
            public string name;
            public char sex;
            public int age;
            public string Major;
        }

        struct Vector2
        {
            public int x, y;
        }

        struct Vector3
        {
            public Vector2 v2;
            public int z;
        }

        struct Color
        {
            public float red, green, blue, alpha;
        }

        struct Rectangle
        {
            public Vector2 position;
            public float width, heigth;

        }
        static void Main(string[] args)
        {

            /*Person zhangsan = new Person();
            zhangsan.name = "zhangsan";
            zhangsan.age = 18;
            zhangsan.sex = 'M';


            //or
            Person lisi = new Person("lisi", 20, 'M');*/

            Student student = new Student();
            student.name = "Killen";
            student.age = 18;
            student.sex = 'F';
            student.Major = "Internet";


        }
    }
}
