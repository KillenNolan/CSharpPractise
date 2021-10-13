using System;

/// <summary>
/// 多边形的抽象类，求周长和面积
/// </summary>
namespace Lesson_02_3Area
{

    /// <summary>
    /// Polygon:多边形
    /// Graphic:绘画的，图解的
    /// </summary>
    abstract class Graphic
    {
        public abstract float GetPrimter();
        public abstract float GetArea();
    }


    /// <summary>
    /// 长方形
    /// </summary>
    class Rect : Graphic
    {
        private float width, heigh;

        public Rect(float width, float heigh)
        {
            this.width = width;
            this.heigh = heigh;
        }
        public override float GetArea()
        {
            return width * heigh;
        }

        public override float GetPrimter()
        {
            return 2 * (width + heigh);
        }
    }


    /// <summary>
    /// 圆
    /// </summary>
    class Cycle : Graphic
    {
        private float ridus;

        public Cycle(float ridus)
        {
            this.ridus = ridus;
        }
        public override float GetArea()
        {
            return 3.14f * ridus * ridus;
        }

        public override float GetPrimter()
        {
            return 2 * 3.14f * ridus;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Graphic[] graphics = new Graphic[2];
            graphics[0] = new Rect(3f, 4f);
            graphics[1] = new Cycle(2f);

            for (int i = 0; i < graphics.Length; i++)
            {
                Console.WriteLine(graphics[i].GetPrimter());
                Console.WriteLine(graphics[i].GetArea());
            }
        }
    }
}
