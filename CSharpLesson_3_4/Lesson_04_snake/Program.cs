using System;
using System.Threading;
namespace Lesson_04_snake
{






    class Program
    {


        static void Main(string[] args)
        {
            /*Vector2 posa = new Vector2(1, 2);
            Vector2 posb = new Vector2(2, 2);

            Console.WriteLine(posa + posb);


            GameObject game = new GameObject("☆", ConsoleColor.Red, new Vector2(2, 3));
            game.Draw();
            Console.ReadKey();
            game.Remove();
            game.Move(new Vector2(0, 1));           
            game.Draw();*/

            //1.画出地图
            Map map = new Map("■", ConsoleColor.Gray, 20, 20, 0, 0);
            map.Draw();            
            
            Snake snake = new Snake(new GameObject("●", ConsoleColor.Red, 6, 5));
            snake.Draw();


            //开辟一个线程，专门监测玩家输入的aswd键
            Thread thread = new Thread(InputDirection);
            thread.Start();


            //贪吃蛇游戏逻辑
            while (true)
            {
                //移动时先将蛇檫除掉，再重新画出来
                snake.Remove();
                snake.Move(dir); 
                //移动完之后是否有触发事件
                snake.TriggerEvent(map);

                if (Snake.isDead)
                {
                    snake.Draw();
                    thread.Interrupt();
                    break;
                } 

                snake.Draw();

                //主线程等待500毫秒
                Thread.Sleep(500);

                //Console.ReadLine();
                //map.CreateFood();

            }


        }


        static Vector2 dir = new Vector2(0, 0);

        /// <summary>
        /// 线程开启检测用户的按键
        /// </summary>
        static void InputDirection()
        {
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                switch (input)
                {
                    case 'a':
                    case 'A': dir.x = -2; dir.y = 0; break;
                    case 'd':
                    case 'D': dir.x = 2; dir.y = 0; break;
                    case 'w':
                    case 'W': dir.x = 0; dir.y = -1; break;
                    case 's':
                    case 'S': dir.x = 0; dir.y = 1; break;
                    default:
                        break;
                }
            }
        }
    }
}
