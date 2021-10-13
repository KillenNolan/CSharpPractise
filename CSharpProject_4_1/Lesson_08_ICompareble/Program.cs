using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Lesson_08_ICompareble
{
    enum CompareType
    {
        chinese = 0,
        math = 1,
        english = 2
    }

    /// <summary>
    /// 按照自己指定的栏位排序
    /// </summary>
    class Student : IComparable<Student>
    {
        public int chinese, math, english;
        public string name;
        public Student(string name, int chinese, int math, int english)
        {
            this.name = name;
            this.chinese = chinese;
            this.math = math;
            this.english = english;
        }


        /// <summary>
        /// 设置比较类型
        /// 怎么按照自己指定的方式来排序
        /// 1.可以设置枚举类型
        /// 2.可以设置全局静态变量
        /// </summary>
        public void SetCompareType(CompareType type)
        {

        }


        private static CompareType type = CompareType.chinese;
        public static CompareType Type
        {
            set
            {
                type = value;
            }
        }

        /// <summary>
        /// 按照自己指定的栏位排序
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo([AllowNull] Student other)
        {
            switch (type)
            {
                case CompareType.chinese:
                    if (other.chinese > chinese)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                case CompareType.math:
                    if (other.math > math)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }

                case CompareType.english:
                    if (other.english > english)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                default: return 0;
            }
            return 0;
        }

        public override string ToString()
        {
            return string.Format("name:{0},chinese:{1},math:{2},english:{3}", name, chinese, math, english);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Nolan", 80, 90, 62);
            Student s2 = new Student("Killen", 100, 85, 95);
            Student s3 = new Student("Jazmin", 99, 55, 60);
            Student s4 = new Student("Jack", 80, 96, 63);

            List<Student> ls = new List<Student>();
            ls.Add(s1);
            ls.Add(s2);
            ls.Add(s3);
            ls.Add(s4);

            Student.Type = CompareType.math;
            ls.Sort();

            for (int i = 0; i < ls.Count; i++)
            {
                Console.WriteLine(ls[i]);
            }
        }
    }
}
