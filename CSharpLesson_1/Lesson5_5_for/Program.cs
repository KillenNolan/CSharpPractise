using System;

namespace Lesson5_5_for
{
    class Program
    {
        static void Main(string[] args)
        {

            /*//for
            int num = 0;
            while (num<10)
            {
                Console.WriteLine("{0}",num);
                num++;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Learn well {0}",i);

            }*/

            /*// ouput 1~100
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("{0}", i);
            }*/

            /* int sum = 0;
             for (int i = 1; i <=100; i++)
             {
                 if (i%2==0)
                 {
                     sum += i;
                 }
             }
             Console.WriteLine( "sum:{0}",sum);*/

            /* int sum = 0;
             for (int i = 0; i <= 100; i += 2)
             {
                 sum += i;
                 Console.WriteLine("i:{0}", i);
             }
             Console.WriteLine("sum:{0}", sum);*/


            /*// 水仙花数：153=1*1*1+5*5*5+3*3*3
            // 100-999之间的水仙花数 

            for (int num = 100; num < 1000; num++)
            {
                int hundred = num / 100;
                //int ten = (153 - hundred) / 10;
                //int si = 153 - hundred - ten;
                int ten = num / 10 % 10;
                int si = num % 10;
                int shui = hundred * hundred * hundred + ten * ten * ten + si * si * si;
                if (num == shui)
                {
                    Console.WriteLine("hundred:{0},ten:{1},si:{2}", hundred, ten, si);
                    Console.WriteLine("Number of daffodils:{0}", num);

                }
            }*/


            /*// 阶乘 :1!+2!+3!+....+10! === 1+2*1+3*2*1+...+10*9*8*7*6*5*4*3*2*1
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                int temp = 1;
                for (int num = 1; num <=i; num++)
                {
                    temp *= num;
                    Console.WriteLine("temp:{0},num:{1}",temp,num);
                }
                sum += temp;
                Console.WriteLine("sum:{0}",sum);
            }*/

            /*// 10*10 的空心星型方形
            for (int i = 0; i < 10; i++)
            {
                //for (int k = 0; k < 10; k++)
                //{
                //    // first and last
                //    if (i == 0 || i == 9)
                //    {
                //        Console.Write("*");
                //    }
                //    else
                //    {
                //        // 1-8 
                //        if (k == 0 || k == 9)
                //        {
                //            Console.Write("*");
                //        }
                //        else
                //        {
                //            Console.Write(" ");
                //        }
                //    }
                //}
                if (i == 0 || i == 9)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int n = 0; n < 10; n++)
                    {
                        if (n == 0 || n == 9)
                            Console.Write("*");
                        else
                            Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }*/

            /*// 10*10 的左直角三角形方阵
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/


            /*// 右直角三角形
            for (int i = 0; i < 10; i++)
            {
                //for (int j = 9; j >= 0; j--)
                //{

                //    if (j <= i)
                //        Console.Write("*");
                //    else
                //        Console.Write(" ");

                //}

                // 输出空格
                for (int m = 0; m < 10 - i; m++)
                {
                    Console.Write(" ");
                }
                // 控制输出星星
                for (int n = 0; n <= i; n++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/


            /*// 打印等边三角形 1,2,3,4,5,6,7,8,9,10
            // 控制行数
            for (int i = 0; i < 10; i++)
            {
                //// 控制列数
                for (int j = 9; j >= 0; j--)
                {
                    Console.Write(" ");

                    if (j <= i)
                        Console.Write("*");
                } 
                Console.WriteLine();
            }*/


           /* //99乘法表
            //1*1=1
            //1*2=2 2*2=4
            //1*3=3 2*3=6   3*3=9
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {                    
                    Console.Write("{0}*{1}={2} \t", j, i, i*j);
                }
                Console.WriteLine();
            }*/







            /* //this is failed,i will try next time
             // 上下正等边三角形1,3,5,7,9,11,9,7,5,3,1
             // 控制行数 正三角形
             for (int i = 1; i <=10; i++)
             {
                 for (int j = 1; j < 10 - i; j++)
                 {
                     Console.Write(" ");
                 }
                 //1,3,5,7,9... 2n-1数列
                 for (int j = 1; j < 2 * i - 1; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             // 控制行数 倒三角形
             for (int i = 1; i <= 9; i++)
             {
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write(" ");
                 }

                 for (int j = 1; j < 2 * (10 - i) - 1; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }*/


        }
    }
}
