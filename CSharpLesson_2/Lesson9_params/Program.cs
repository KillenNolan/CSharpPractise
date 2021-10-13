using System;

namespace Lesson9_params
{
    /// <summary>
    /// 
    /// params:1.参数个数可变 2.只能作为最后一个参数
    /// </summary>
    class Program
    {
        struct Student
        {
            public string name;
            public void Show(string sex = "F")
            {
                Console.WriteLine("My name is {0}, i'm a {1}", name, sex);
            }
        }

        static void Main(string[] args)
        {

            /*Test1(1, 2);

            Test2(1);
            Test2(1, 2);
            Test2(1, 2, 3);*/


            /*Sum(out int even, out int odd, 1, 2, 3, 4, 6, 7, 89, 7);
            Console.WriteLine("Even:{0}, Odd:{1}", even, odd);*/

            /*Show();
            Show("Canada");*/

            Student student = new Student();
            student.name = "Killen";
            student.Show();

        }

        static void Show(string country = "China")
        {
            Console.WriteLine(country);
        }


        static void Sum(out int even, out int odd, params int[] arr)
        {
            odd = 0;
            even = 0;
            foreach (var item in arr)
            {
                if (item % 2 != 0)
                {
                    odd += item;
                }
                else
                {
                    even += item;
                }

            }
        }

        static void Test2(params int[] arr)
        {


        }

        static void Test1(int x, int y)
        {

        }

    }
}
