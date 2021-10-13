using System;

namespace Lesson5_6_game2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// 控制台颜色修改
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello World!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hello World!");

            // 设置光标位置
            Console.SetCursorPosition(5, 5);
            Console.Write("World!");*/


            int x = 0;
            int y = 0;

            while (true)
            {
                // 光标复位
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        // Ctrl+Shift+M+X:打開搜狗符號大全
                        Console.Write("X");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("X");
                //// 將光標移远，修复因光标导致的问题
                //Console.SetCursorPosition(5, 5);
                Console.ForegroundColor = ConsoleColor.Gray;


                // 按键已经接收到，ReadKey(true)但不会显示在控制台上
                char input = Console.ReadKey(true).KeyChar;

                switch (input)
                {
                    case 'a':
                    case 'A':
                        x -= 1;
                        if (x <= 0)
                        {
                            x = 0;
                        }
                        break;
                    case 'd':
                    case 'D':
                        x += 1;
                        if (x > 3)
                        {
                            x = 3;
                        }
                        break;
                    case 'w':
                    case 'W':
                        y -= 1;
                        if (y <= 0)
                        {
                            y = 0;
                        }
                        break;
                    case 's':
                    case 'S':
                        y += 1;
                        if (y > 1)
                        {
                            y = 1;
                        }
                        break;
                }
            }





        }
    }
}
