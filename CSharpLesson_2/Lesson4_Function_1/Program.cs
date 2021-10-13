using System;

namespace Lesson5_Function_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 调用的是控制台写的功能
            Console.WriteLine("Hello World!");


            /*  //调用Test的函数
              Test();
  */

            /*int b = 3;
            Test1(b);
            Console.WriteLine(b);*/

            int b = 3;
            b = Test2(b);
            Console.WriteLine("b:" + b);


            int x = 4, y = 5;
            Console.WriteLine(Add(4, 5));


            /*
             * 函数调用规则
             * 1. 函数名要对
             * 2. 调用函数参数要对(数量，类型)
             * 3. 没有返回值不能接收；有返回值可接受可不接收。
             */

        }

        /* //void:没有返回值
         //括号中的参数:可以么有
         static void Test()
         {
             Console.WriteLine("TEST");
         }*/

        /* static void Test1(int a)
         {
             a += 5;
            return;
         }*/


        /// <summary>
        /// 函数声明时有返回值，函数体中必须有return
        /// return类型必须和声明时返回值一致
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int Test2(int a)
        {
            a += 5;
            return a;
        }


        static int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

    }
}
