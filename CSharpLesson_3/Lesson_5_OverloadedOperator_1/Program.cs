using System;

namespace Lesson_5_OverloadedOperator_1
{
    /// <summary>
    /// 向量相加
    /// 重载运算符是具有特俗名称的函数，是通过关键字 operator 后跟运算符的符号来定义的
    /// </summary>
    class Vector2
    {
        public int x, y;
        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }


        public static Vector2 operator +(Vector2 v1, Vector2 v2)
        {
            return new Vector2(v1.x + v2.x, v1.y + v2.y);
        }


        public static bool operator ==(Vector2 v1, Vector2 v2)
        {
            return v1.x == v2.x && v1.y == v2.y;
        }

        public static bool operator !=(Vector2 v1, Vector2 v2)
        {
            return !(v1.x == v2.x) ;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Vector2 v1 = new Vector2(1, 2);
            Vector2 v2 = new Vector2(2, 3);
            Vector2 v = v1 + v2;
            Console.WriteLine("v.x:{0},v.y:{1}", v.x, v.y);
            Console.WriteLine(v1 == v2);
            Console.WriteLine(v1 != v2);
        }
    }
}
