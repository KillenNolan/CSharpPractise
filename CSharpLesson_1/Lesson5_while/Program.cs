using System;

namespace Lesson5_while
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            if (a > 0)
            {
                Console.WriteLine("a:" + a);
            }

            // 死循环
            int b = 10;
            while (b > 0)
            {
                Console.WriteLine("b:" + b);
                b--;// 不加会死循环
            }*/

            /* int num = 100;
             while (num > 0)
             {
                 Console.WriteLine("I want learn C# well, then learn Unity well!" + num);
                 num--;
             }*/

            /*int num = 0;
            while (num < 101)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("even:" + num);
                }
                num++;
            }*/



            /* int num = 1, sum = 0;
             while (num < 100)
             {
                 sum += num;
                 num++;
             }
             Console.WriteLine("sum of 100:" + sum);
            */


            /*// break:跳出循环
            // continue:跳出本次循环
            int num = 0;
            while (num < 10)
            {
                num++;
                if (num == 3)
                {
                    break;
                }
                Console.WriteLine("num:" + num);                
            }
            
            
            int num1 = 0;
            while (num1 < 10)
            {
                num1++;
                if (num1 == 3)
                {
                    continue;
                }
                Console.WriteLine("num1:" + num1);

            }*/


            /* int num = 1, sum = 0;
             while (num < 101)
             {
                 if (num % 7 == 0)
                 {
                     num++;
                     continue;
                 }
                 sum += num;
                 num++;
             }
             Console.WriteLine("sum:" + sum);*/


            /*// 判定是否是质数
            int num = 7;
            int i = 2;
            bool boPrime = true;
            while (i < num )
            {
                if (num % i == 0)
                {
                    boPrime = false;
                }
                i++;
                
            }*/

            /*  // 素数/质数：只能被1和这个数字本身整除的数字，1不是质数，2是最小的质数
              // 找出100以内所有的质数(一个数如果不能被整除，判断至这个数的一半就能知道了)
              int number = 2;
              while (number < 100)
              {
                  int num = number;
                  int i = 2;
                  bool boPrime = true;
                  while (i < num )
                  {
                      if (num % i == 0)
                      {
                          boPrime = false;
                          break;
                      }
                      i++;                    
                  }
                  if (boPrime)
                  {
                      Console.WriteLine("number:" + number + " is Prime number:" + boPrime);
                  }
                  number++;
              }*/


            // 1-100的和，和>500,中断，并输出使和大于500的最小数字

            int i = 1, sum = 0;
            while (i < 100)
            { 
                sum += i;
                if (sum > 500)
                {
                    Console.WriteLine("sum:" + sum + ",i:" + i);
                    break;
                }
                i++;
            }





        }
    }
}
