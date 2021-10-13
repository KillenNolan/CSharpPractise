using System;

/// <summary>
/// 定义一个Box类，有长宽高，重载加法运算符，可以计算出Box对象体积相加。
/// </summary>
namespace Lesson_5_OverloadedOperator_2example
{

    class Box
    {

        public int x, y, z;
        public Box(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        /// <summary>
        /// 计算体积
        /// </summary>
        public int GetVolumen()
        {
            return x * y * z;
        }

        public static int operator +(Box b1,Box b2)
        {
            return b1.GetVolumen() + b2.GetVolumen();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(1, 2, 3);
            Box b2 = new Box(2, 3, 4);
            Console.WriteLine(b1+b2); 
        }
    }
}
