using System;

/// <summary>
/// 书写一个GameObject类，有这些属性：位置，大小，颜色
/// 有这些方法：图形绘制draw，图形摖除remove，移动move
/// </summary>
namespace Lesson_05_3GameObject
{

    class Graphic
    {
        public int x, y;
        public ConsoleColor color;
        public string icon;


        public Graphic(int x, int y, ConsoleColor color, string icon)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
            this.color = color;

        }

        /// <summary>
        /// 清屏
        /// </summary>
        public void Clear()
        {
            Console.Clear();
        }


        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
    }



    class Rect : Graphic
    {

        public int heigh, width;
        public Rect(int x, int y, ConsoleColor color, string icon, int heigh, int width) : base(x, y, color, icon)
        {
            this.heigh = heigh;
            this.width = width;
        }

        public void Draw( )
        {
            Console.ForegroundColor = color;
            for (int i = 0; i < heigh; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.SetCursorPosition(x + j, y + i);
                    Console.Write(icon);
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Rect rect = new Rect(5, 5, ConsoleColor.Green,"*", 5, 5);
            rect.Draw(  );
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                if (input=='d')
                {
                    rect.Move(1, 0);
                }
                rect.Clear();
                rect.Draw();
            }
        }
    }
}
