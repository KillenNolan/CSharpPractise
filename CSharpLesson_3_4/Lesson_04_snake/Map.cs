using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_04_snake
{

    class Map
    {
        GameObject[] mapGameObects;
        string icon;
        Vector2 size;
        Vector2 startPos;
        ConsoleColor color;

        public Map(string icon, ConsoleColor color, Vector2 size, Vector2 startPos)
        {
            this.icon = icon;
            this.color = color;
            this.size = size;
            this.startPos = startPos;
        }


        public Map(string icon, ConsoleColor color, int sizeX, int sizeY, int posX, int posY)
            : this(icon, color, new Vector2(sizeX, sizeY), new Vector2(posX, posY))
        {

        }
        int index = 1;

        private void CreateWall()
        {
            mapGameObects = new GameObject[size.x * size.y];
            GameObject start = new GameObject(icon, color, startPos);
            mapGameObects[0] = start;



            //向左
            for (int i = 1; i < size.x; i++)
            {
                Vector2 pos = mapGameObects[index - 1].pos + new Vector2(2, 0);
                GameObject game = new GameObject(icon, color, pos);
                mapGameObects[index] = game; index++;
            }

            //向下
            for (int i = 1; i < size.y; i++)
            {
                Vector2 pos = mapGameObects[index - 1].pos + new Vector2(0, 1);
                GameObject game = new GameObject(icon, color, pos);
                mapGameObects[index] = game; index++;
            }

            //向右
            for (int i = 1; i < size.x; i++)
            {
                Vector2 pos = mapGameObects[index - 1].pos + new Vector2(-2, 0);
                GameObject game = new GameObject(icon, color, pos);
                mapGameObects[index] = game; index++;
            }

            //向上
            for (int i = 1; i < size.y; i++)
            {
                Vector2 pos = mapGameObects[index - 1].pos + new Vector2(0, -1);
                GameObject game = new GameObject(icon, color, pos);
                mapGameObects[index] = game; index++;
            }


        }

        GameObject food;
        public Vector2 FoodPos
        {
            get { return food.pos; }
        }
        /// <summary>
        /// 创建食物
        /// </summary>
        public void CreateFood()
        {
            int minX = startPos.x + 2;
            // x的最大值坐标需-4，因为-2时开始画的话，刚好重叠在线上；y最大值理由同上
            int maxX = startPos.x + (size.x - 2) * 2;
            int minY = startPos.y + 1;
            int maxY = startPos.y + size.y - 2;
            //Console.SetCursorPosition(minX, minY);
            //Console.Write("☆");
            //Console.SetCursorPosition(minX, maxY);
            //Console.Write("☆");
            //Console.SetCursorPosition(maxX , minY);
            //Console.Write("☆");
            //Console.SetCursorPosition(maxX , maxY);
            //Console.Write("☆");


            Random random = new Random();
            int FoodX = random.Next(minX, maxX + 1);
            int FoodY = random.Next(minY, maxY + 1);

            Console.SetCursorPosition(50, 10);
            Console.Write("Food: x:{0},y:{1};minX:{2},MaxX:{3},minY:{4},maxY:{5}", FoodX, FoodY, minX, maxX, minY, maxY);

            food = new GameObject("☆", ConsoleColor.Red, new Vector2(FoodX, FoodY));
            food.Draw();
        }

        /// <summary>
        /// 画地图并初次生成食物
        /// </summary>
        public void Draw()
        {
            CreateWall();
            for (int i = 0; i < index; i++)
            {
                mapGameObects[i].Draw();
            }
            CreateFood();
        }

    }
}
