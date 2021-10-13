using System;

namespace Lesson5_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            /*// 1-100的和，和>500,中断，并输出使和大于500的最小数字

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
            }*/


            /*
             // 讲一遍问一次，会了吗？不会，接着讲，直到会或者讲了10次放学
             int times = 1;
              while (times <= 10)
              {
                  Console.WriteLine("tmies{0}, Will you do it?", times);
                  string input = Console.ReadLine();
                  if (input == "y")
                  {
                      Console.WriteLine("Done");
                      break;
                  }
                  times++;
              }
              Console.WriteLine("After school");*/



            /*// 2021:10W  increase 80% per year ,which year touch 100W
            int year = 2021;
            float number = 10;
            while (number < 100)
            {
                number += (1 + 0.8f) * 10;
                year++;
                Console.WriteLine("year:{0},numbers:{1}", year, number);
            }*/

            /*  // 求数列1,1,2，3,5,8,13的20th位数字 
              int num1 = 1;
              int num2 = 1;
              int index = 3;
              while (index <= 20)
              {
                  int num = num1 + num2;
                  num1 = num2;
                  num2 = num;                
                  Console.WriteLine("num:{0},index:{1}", num, index);
                  index++;
              }*/

            /* int num = 0;
             while (num < 10)
             {
                 num++;
                 Console.WriteLine("num:{0}", num);

                 if (num == 3)
                 {
                     break;                    
                 }
             }*/


            /*
             * judge a number is a prime
             while (true)
            {
                Console.WriteLine("Pleas input a number:");
                string input = Console.ReadLine();

                int number;
                int i = 2;
                bool boPrime = true;
                if (int.TryParse(input, out number))
                {
                    while (number > i)
                    {
                        if (number % i == 0)
                        {
                            boPrime = false;
                            break;
                        }
                        i++;
                    }

                }
                Console.WriteLine("num:{0},boPrme:{1}", number, boPrime);
            }*/


            /*//test

            while (true)
            {

                Console.WriteLine("Please input a number(0~100):");
                string input = Console.ReadLine();
                int iinput;
                int.TryParse(input, out iinput);
                int i = 1;
                while (i <= 10)
                {
                    Console.WriteLine("Give us your guess:");
                    string getNumber = Console.ReadLine();
                    int number;
                    int.TryParse(getNumber, out number);
                    if (number == iinput)
                    {
                        if (i < 5)
                        {
                            Console.WriteLine("you are so great,{0} gussed!", i);
                        }
                        else if (i < 10)
                        {
                            Console.WriteLine("You are not so bad.");
                        }
                        else
                        {
                            Console.WriteLine("the last time, you gussesd it");
                        }
                        break;  
                    }
                    i++;
                    if(i>10)
                    {
                        Console.WriteLine("Over 10 times");
                        break;
                    }
                }*/


            /* //do while();
             do
             {
                 Console.WriteLine("Please enter your username:");
                 string strUser = Console.ReadLine();
                 Console.WriteLine("Please enter your password:");
                 string strPwd = Console.ReadLine();

                 if (strUser == "admin" && strPwd == "888888")
                 {
                     Console.WriteLine("Logon Success!");
                     break;
                 }
                 Console.WriteLine("Please try again");
             } while (true);*/


            int num1 = 1;
            int num2 = 1;
            int index = 3;
            do
            {
                int num = num1 + num2;
                num1 = num2;
                num2 = num;
                Console.WriteLine("num:{0},index:{1}", num, index);

                index++;

            } while (index <= 20);






        }
    }
}
