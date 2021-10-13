using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_04_snake
{
    /// <summary>
    /// 坐标
    /// </summary>
    struct Vector2
    {
        public int x, y;
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// 移动时，坐标变化
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.x + b.x, a.y + b.y);
        }


        /// <summary>
        /// 希望+不要返回结构体，重新ToString()方法，返回我们期望的数据格式
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"x:{x},y:{y}";
        }


        /// <summary>
        /// 移动时，判断坐标位置是否相等
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return (a.x == b.x && a.y == b.y) ? true : false;
        }

        /// <summary>
        /// 移动时，判断坐标位置不相等
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(Vector2 a, Vector2 b)
        {
            bool res = (a.x != b.x || a.y != b.y);
            return res;
            //return (a.x != b.x | a.y != b.y) ? true : false;
        }
    }

    class GameObject
    {
        public Vector2 pos;
        public string icon;
        public ConsoleColor color;

        public GameObject(string icon, ConsoleColor color, Vector2 pos)
        {
            this.icon = icon;
            this.color = color;
            this.pos = pos;
        }

        public GameObject(string icon, ConsoleColor color, int x, int y)
        {
            this.icon = icon;
            this.color = color;
            this.pos = new Vector2(x, y);
        }

        /// <summary>
        /// 画出游戏物体
        /// </summary>
        public void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = color;
            Console.Write(icon);
        }

        /// <summary>
        /// 檫除游戏物体
        /// </summary>
        public void Remove()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write("  ");
        }

        private bool isDead = false;
        public bool IsDead
        {
            get { return isDead; }
        }

        /// <summary>
        /// 移动游戏物体(移动时不能超过地图的范围)
        /// </summary>
        public void Move(Vector2 direction)
        {
            pos = pos + direction;

            if (pos.x <= 1)
            {
                pos.x = 1;
                isDead = true;
            }
            if (pos.x >= 37)
            {
                pos.x = 37;
                isDead = true;
            }
            if (pos.y <= 1)
            {
                pos.y = 1;
                isDead = true;
            }
            if (pos.y >= 19)
            {
                pos.y = 19;
                isDead = true;
            }

        }

    }
}
