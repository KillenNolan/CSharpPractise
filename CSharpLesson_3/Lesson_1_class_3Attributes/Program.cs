using System;

namespace Lesson_1_class_3Attributes
{

    class Person
    {
        /* 
         /// <summary>
         /// 年龄是只读
         /// </summary>
         public int age;*/

        /// <summary>
        /// 字段:具体存储数据
        /// </summary>
        private int age;
        public int Age
        {
            get
            {
                //当外界需要读取数据的时候,返回一个数据给调用的地方
                return age;
            }
            set
            {
                //当外界需要对变量进行赋值的时候调用, 赋过来的值是value
                if (value < 0)
                {
                    Console.WriteLine("数据有误,请检查数据");

                }

                age = value;
            }
        }


        /// <summary>
        /// 自动属性,随机生成一个变量,分配一个内存空间
        /// </summary>
        public int HP { get; set; }

    }

    class Student
    {

        private string name;


        private char sex;
        public char Sex
        {
            get { return sex; }
            set
            {
                if (value == '男' || value == '女')
                {
                    sex = value;
                }
            }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    age = value;
                }
            }
        }



        private int csharpScore;
        public int CsharpScore
        {
            get { return csharpScore; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    csharpScore = value;

                }
            }
        }

        private int unityScore;
        public int UnityScore
        {
            get { return unityScore; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    unityScore = value;

                }
            }
        }


        public Student(string name, char sex, int age, int csharpScore, int unityScore)
        {
            this.name = name;
            Sex = sex;
            Age = age;
            UnityScore = unityScore;
            CsharpScore = csharpScore;

        }


        public void SayHello()
        {
            Console.WriteLine("大家好,我叫{0},{1},今年{2}岁,我的CsharpScore成绩是{3},我的UnityScore成绩是{4}", name, sex, age, csharpScore, unityScore);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            /*            Console.WriteLine("Hello World!");

                        Person killen = new Person();
                        killen.Age = 25;
                        Console.WriteLine(killen.Age);*/

            Student killen = new Student("Killen", '女', 25, 100, 100);
            //UnityScore的范围有进行限制,所以200赋值不成功
            killen.UnityScore = 200;
            killen.SayHello();
        }
    }
}
