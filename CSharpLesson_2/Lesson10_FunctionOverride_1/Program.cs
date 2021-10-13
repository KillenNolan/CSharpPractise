using System;

namespace Lesson10_FunctionOverride_1
{
    /// <summary>
    /// 函数重载：前提==函数名一样
    /// 1.或参数个数不同；
    /// 2.或参数个数一样但数据类型不一样；
    /// 3.或参数个数相同，类型一样，参数顺序不一样
    /// 4.根有无返回值无关；
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            /*Console.WriteLine("killen");
            Console.WriteLine(123);
            Console.WriteLine(1.5f);
            Console.WriteLine(1.2d);
            Console.WriteLine(true);*/

            /*
             * 1.变量命名规则：驼峰命名法 myAge==小驼峰
             * 2.函数、类、结构体：帕斯卡命名法 ShowInfo==大驼峰
             */
           /* GetSum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 9, 8, 5, 8, 65, 95, 65, 65, 65, 65, 6523, 65);
            GetSum(1.2f, 1.6f);
            GetSum(1.2, 2, 3.6, 5, 7.5);*/

            Reverse(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Reverse(1.2f, 2, 3, 4.5f, 5, 6, 7, 8, 9);
            Reverse("1","2","4","9","7");

        }
        static void Print(float[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Print(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }


        static void Reverse(params float[] arr)
        {
            for (int i = 0; i < arr.Length * 0.5f; i++)
            {
                float temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Print(arr);
        }


        static void Reverse(params string[] arr)
        {
            for (int i = 0; i < arr.Length * 0.5f; i++)
            {
                string temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Print(arr);
        }
        static void Reverse(params int[] arr)
        {
            for (int i = 0; i < arr.Length * 0.5f; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            Print(arr);
        }

        static void GetSum(params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("int Sum:{0}", sum);
        }


        static void GetSum(params float[] arr)
        {
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("float Sum:{0}", sum);
        }

        static void GetSum(params double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("double Sum:{0}", sum);
        }

        /*  static void Test(float a,int b)
          {


          }

          static void Test(int a, float b)
          {

          }

          static void Test(float a)
          {

          }

          static void Test(int a)
          {

          }

          static void Test (int a,int b)
          {


          }
  */
    }
}
