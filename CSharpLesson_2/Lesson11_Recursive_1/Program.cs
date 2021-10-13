using System;

namespace Lesson11_Recursive_1
{
    /// <summary>
    /// 递归函数：自己调用自己
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //Test(5);

            /*
                        Console.WriteLine(Factorial(3));
                        //Console.WriteLine(FactorialSum(3));
                        FactorialSum(3);*/

            /*Console.WriteLine(CutHalf(100, 10));

            Console.WriteLine(Peach(1));*/

            Triangle(4);

            //Console.WriteLine(GetNum(3, 3));



        }


        /// <summary>
        /// 三角函数：第一行只有一个数，以下每一行的数是他正上方的数，右上方的数，左上方的数的和，不存在则为0(x不变，y变)
        /// (0,0):0+1+0
        /// (1,1):(0,-1)+(0,0)+(0,1)
        /// (2,2):(1,0)+(1,1）+(1,2)
        /// (3,3):(2,1)+(2,2)+(2,3)
        /// ...
        /// (m,n):(m-1,n-2)+(m-1,n-1)+(m-1,n)
        /// </summary>
        /// <param name="rows"></param>
        /// <returns></returns>
        static void Triangle(int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write(GetNum(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 三角函数：第一行只有一个数，以下每一行的数是他正上方的数，右上方的数，左上方的数的和，不存在则为0(x不变，y变)
        /// (0,0):0+1+0
        /// (1,1):(0,-1)+(0,0)+(0,1)
        /// (2,2):(1,0)+(1,1）+(1,2)
        /// (3,3):(2,1)+(2,2)+(2,3)
        /// ...
        /// (m,n):(m-1,n-2)+(m-1,n-1)+(m-1,n)
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns>m行n列的那一个数</returns>
        static int GetNum(int m, int n)
        {
            if (m == 0 && n == 0)
            {
                return 1;
            }
            else if (m == 0 && n != 0)
                return 0;
            else
                return GetNum(m - 1, n - 2) + GetNum(m - 1, n - 1) + GetNum(m - 1, n);

        }


        /// <summary>
        ///  第一天吃一半多一个，第二天吃第一天的一半多一个...第十天剩一个,求第一天摘了多少个
        ///  10：1
        ///  9:(1+1)*2
        ///  8：((1+1)*2+1)*2
        /// </summary>
        /// <param name="days"></param>
        /// <returns></returns>
        static int Peach(int days)
        {
            if (days == 10)
            {
                return 1;
            }
            else
            {
                return (Peach(++days) + 1) * 2;
            }
        }



        /// <summary>
        /// 100米的竹子，每天砍一半，第10天还剩多长
        /// </summary>
        /// <param name="length"></param>
        /// <param name="days"></param>
        /// <returns></returns>
        static float CutHalf(float length, int days)
        {
            if (days == 1)
                return length;
            else
            {
                length *= 0.5f;
                return CutHalf(length, --days);
            }
        }



        /// <summary>
        /// 3!=3*2*1
        /// 2!=2*1
        /// 1!=1
        /// 阶乘相加
        /// </summary>
        /// <param name="x"></param>
        static int FactorialSum(int x)
        {
            /* int sum = 0;
             while (x > 0)
             {
                 int jieChen = 1;
                 for (int i = 1; i <= x; i++)
                 {
                     jieChen *= i;
                 }
                 sum += jieChen;
                 x--;
             }
             Console.WriteLine("sum:{0}", sum);*/
            if (x > 1)
            {
                return Factorial(x) + FactorialSum(x - 1);
            }
            else
            {
                return 1;
            }


        }


        /// <summary>
        /// 阶乘Factorial
        /// </summary>
        /// <param name="x"></param>
        static int Factorial(int x)
        {
            /* int sum = 1;
             for (int i = 1; i <= x; i++)
             {
                 sum *= i;
             }*/
            if (x > 1)
            {
                return x * Factorial(x - 1);
            }
            else
            {
                return 1;
            }
        }


        /// <summary>
        /// 条件向边界靠拢
        /// </summary>
        /// <param name="a"></param>
        static void Test(int a)
        {
            Console.WriteLine("a:" + a);
            if (a > 0)
                Test(--a);
        }

        /// <summary>
        /// 死循环
        /// </summary>
        static void Test()
        {
            Test();
        }
    }
}
