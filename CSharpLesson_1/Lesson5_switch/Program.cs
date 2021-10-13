using System;

namespace Lesson5_switch
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string input = Console.ReadLine();
            switch (input)
            {
                case "A": Console.WriteLine("the ouput is A"); break;
                case "B": Console.WriteLine("the input is B"); break;
                default: Console.WriteLine("Not AB"); break;
            }

            if (input=="A")
            {
                Console.WriteLine("the ouput is A");
            }
            else if (input =="B")
            {
                Console.WriteLine("the ouput is B");
            }
            else
            {
                Console.WriteLine( "Not AB");
            }*/

            /*int salary = 4000;
            int performance = 0;
            Console.WriteLine("Please rate the teacher:");
            char c = Console.ReadKey().KeyChar;
            switch (c)
            {
                case 'A': performance = 400; break;
                case 'B': performance = 0; break;
                case 'C': performance = -300; break;
                case 'D': performance = -500; break;
                case 'E': performance = -800; break;
            }
            Console.WriteLine("the salary of teacher zhang:" + salary + performance);*/

            /*Console.WriteLine("Please enter a score:");
            string input = Console.ReadLine();
            int score;
            int.TryParse(input, out score);

            score = score / 10;

            switch (score)
            {
                case 10: Console.WriteLine("perfect"); break;
                case 9: Console.WriteLine("perfect"); break;
                case 8: Console.WriteLine("excellent"); break;
                case 7: Console.WriteLine("good"); break;
                case 6: Console.WriteLine("pass"); break;
                default: Console.WriteLine("Keep working hard"); break;
            }
            */

            /*// switch 贯穿
            int num = 3;
            switch (num)
            {
                case 1:
                case 2: Console.WriteLine("1-2"); break;
                case 3:
                case 4:
                case 5: Console.WriteLine("3-5"); break;
            }*/

            Console.WriteLine("Please enter year:");
            string strYear = Console.ReadLine();
            Console.WriteLine("Please enter month");
            string strMonth = Console.ReadLine();
            int year, month;
            int.TryParse(strYear, out year);
            int.TryParse(strMonth, out month);

            bool borunnian = false;

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                borunnian = true;
            }

            // 31:1,3,5,7,8,10,12
            // 30:4,6,9,11
            // 28/29:2

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: Console.WriteLine("31"); break;
                case 4:
                case 6:
                case 9:
                case 11: Console.WriteLine("30"); ; break;
                case 2:
                    if (borunnian)
                    {
                        Console.WriteLine("29");
                    }
                    else
                    {
                        Console.WriteLine("28");
                    }
                    break;
            }

        }
    }
}
