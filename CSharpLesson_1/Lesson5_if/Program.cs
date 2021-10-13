using System;

namespace Lesson5_if
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            string input = Console.ReadLine();
                        string reslut = input == "123" ? "Right" : "Wrong";
                        Console.WriteLine(reslut);


                        if (input=="123")
                        {
                            Console.WriteLine("Right");
                        }*/

            /*  Console.WriteLine("Please input your age:");
              string strAge = Console.ReadLine();
              int age;
              if (int.TryParse(strAge, out age))
              {
                  if (age>18)
                  {
                      Console.WriteLine("You are adults now.");
                  }
              }*/


            /* Console.WriteLine("How long have you already spent on C#?");
             string strTime = Console.ReadLine();
             int time;
             if (int.TryParse(strTime,out time ))
             {
                 if (time>=60)
                     Console.WriteLine("You are study hard!");              
             }
 */


            /*  Console.WriteLine("Please input your username:");
              string strName = Console.ReadLine();
              Console.WriteLine("Please input your password:");
              string strPwd = Console.ReadLine();

              if (strName == "admin" && strPwd == "123456")
              {
                  Console.WriteLine("Logon Success!");
              }*/


            /* Console.WriteLine("Please input your chinese score:");
             string cnScore = Console.ReadLine();
             Console.WriteLine("Please input your english score:");
             string enScore = Console.ReadLine();
             Console.WriteLine("PLease input your math score:");
             string mathScore = Console.ReadLine();

             int math, english, chinese;
             if (int.TryParse(mathScore, out math) && int.TryParse(cnScore, out chinese) && int.TryParse(enScore, out english))
             {
                 // 三个数据都是合法的
                 if (chinese > 70 && math > 80 && english > 90
                     || (chinese == 100 || math == 100 || english == 100)
                     || (chinese > 90 && (math > 70 || english > 70)))
                 {
                     Console.WriteLine("You are great!");
                 }
             }*/

            /*Console.WriteLine("Please input your score:");
            string strScore = Console.ReadLine();
            int score;
            if (int.TryParse(strScore,out score))
            {
                if (score>=90)
                {
                    Console.WriteLine("You can get 100yuan!");

                }
                else
                {
                    Console.WriteLine("You can't play ganme in a month.");
                }
            }*/

            /* Console.WriteLine("Please input your age:");
             string strAge = Console.ReadLine();
             int age;
             if (int.TryParse(strAge, out age))
             {
                 if (age < 14)
                     Console.WriteLine("Child");
                 else if (age < 18)
                     Console.WriteLine("Teens");
                 else if (age < 30)
                     Console.WriteLine("Youth");
                 else if (age < 50)
                     Console.WriteLine("Middle Aged");
                 else
                     Console.WriteLine("Elderly");
             }*/

            /*Console.WriteLine("Please input the first number:");
            string strFirst = Console.ReadLine();
            Console.WriteLine("Please input the second number:");
            string strSecond = Console.ReadLine();
            Console.WriteLine("Please input the third number:");
            string strThird = Console.ReadLine();
            int num1, num2, num3;
            if (int.TryParse(strFirst, out num1) && int.TryParse(strSecond, out num2) && int.TryParse(strThird, out num3))
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine("num1:" + num1);
                    }
                    else
                    {
                        Console.WriteLine("num3:" + num3);
                    }
                }
                else if (num2 > num3)
                {
                    Console.WriteLine("num2:" + num2);
                }
                else
                {
                    Console.WriteLine("num3:" + num3);
                }
                //else
                //{
                //    if (num2 > num3)
                //    {
                //        Console.WriteLine("num2:" + num2);
                //    }
                //    else
                //    {
                //        Console.WriteLine("num3:" + num3);
                //    }
                //}

            }*/

            /*Console.WriteLine("Please enter password:");
            string strPwd = Console.ReadLine();

            if (strPwd=="888888")
            {
                Console.WriteLine("Entered correctly!");
            }
            else
            {
                Console.WriteLine("Incorrect password, please enter again:");
                strPwd = Console.ReadLine();

                if (strPwd=="888888")
                {
                    Console.WriteLine("Login Failed!");
                }
                else
                {
                    Console.WriteLine("Login Successful!");
                }
            }*/



            /*  // 判断输入的数是偶数还是奇数
              Console.WriteLine("Please enter an integer:");
              string integer = Console.ReadLine();

              int num;
              if (int.TryParse(integer,out num))
              {
                  if (num%2==0)
                  {
                      Console.WriteLine( "your input is even.");
                  }
                  else
                  {
                      Console.WriteLine("your input is odd.");
                  }

              }*/


            /*  // 根据年龄判断是否有权限
              Console.WriteLine("Please enter your age:");
              string input = Console.ReadLine();

              int age;
              if (int.TryParse(input, out age))
              {
                  if (age > 10 && age < 18 || (age > 25 && age < 30))
                  {
                      Console.WriteLine("can visit.");
                  }
                  else
                  {
                      Console.WriteLine("access denied.");
                  }

              }*/

            /* // 判断输入的字符是否属于0-9
             Console.WriteLine("Please enter a cahr:");
             char x = Console.ReadKey().KeyChar;// 接收一个字符
             if (x >= 48 && x <= 57)
             {
                 Console.WriteLine(" is a number");
             }
             else
             {
                 Console.WriteLine(x + " isn't a number.");
             }*/

            /*
            // 判断账号密码是否输入正确
            Console.WriteLine("Please input your username:");
            string strName = Console.ReadLine();
            Console.WriteLine("Please input your password:");
            string strPwd = Console.ReadLine();

            if (strName == "admin" && strPwd == "123456")
            {
                Console.WriteLine("Logon Success!");
            }
            else if (strName=="admin")
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("username doesn't exists!");
            }*/


            /*  Console.WriteLine("Please enter a cahr:");
              string input = Console.ReadLine();
              int number;

              if (int.TryParse(input, out number))
              {
                  if (number >= 0 && number <= 9)
                  {
                      Console.WriteLine("You enter a number.");
                  }
              }
              else
              {
                  Console.WriteLine("This isn't a number.");
              }*/


/*
            Console.WriteLine("pleasr enter your age:");
            string input = Console.ReadLine();
            int age;
            if (int.TryParse(input, out age))
            {
                if (age >= 18)
                {
                    Console.WriteLine("you are adults.");
                    Console.WriteLine("you can learn advanced course.");
                }
                else if (age < 13)
                {
                    Console.WriteLine("you are child.");
                    Console.WriteLine("you can learn low-level course.");
                }
                else
                {
                    Console.WriteLine("you are teeens.");
                    Console.WriteLine("do you want to learn advanced course?(yes,no)");
                    string signal = Console.ReadLine();
                    if (signal.ToLower() == "yes")
                    {
                        Console.WriteLine("Please check.");
                    }
                    else
                    {
                        Console.WriteLine("Exit, you give up to check");
                    }

                }
            }
            */



        }
    }
}
