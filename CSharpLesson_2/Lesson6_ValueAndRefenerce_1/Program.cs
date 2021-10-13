using System;

namespace Lesson6_ValueAndRefenerce_1
{
    class Program
    {
        /// <summary>
        /// 值类型：存储在栈中，运行速度快，空间小
        ///         结构体，int，float...
        /// 引用类型：存储在堆中，运行速度慢，空间大
        ///         string,Array...
        /// 注意：运行速度是相对比较
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // 值类型参数：拷贝传递
            int x = 10;
            Test1(x);
            Console.WriteLine("x:" + x);


            // 引用类型传递的是：引用地址
            int[] arr = { 1, 2, 3, 4, 5 };
            Test2(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // string 是引用类型，但有特殊性
            // 假设地址是0X1245
            string str = "123456";
            Test3(str);
            Console.WriteLine("str:" + str);
            // str的地址空间还是0X1245

        }


        static void Test3(string str1)
        {
            
            // str1的地址空间是0X1245
            // string的特殊性，赋值时在堆中生成新的空间地址0X1263
            str1 = "lll";
            // str1的地址空间是0X1263
        }

        /// <summary>
        /// 函数的参数是引用类型
        /// </summary>
        /// <param name="arr"></param>
        static void Test2(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 0;
            }
        }

        /// <summary>
        /// 值类型参数
        /// </summary>
        /// <param name="a"></param>
        static void Test1(int a)
        {
            a = 0;
        }
    }
}
