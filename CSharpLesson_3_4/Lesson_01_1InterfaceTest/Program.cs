using System;

/// <summary>
/// 麻雀Sparrow,鸵鸟Ostrich，企鹅Penguin，鹦鹉Parrot，直升机Helicopter，天鹅Swan；
/// 直升机，鸟能飞；鸵鸟，企鹅不能飞；
/// 多态实现：虚方法，抽象类，接口
/// 飞，走，游泳
/// </summary>
namespace Lesson_01_1InterfaceTest
{

    interface IFly
    {
        void Fly();
    }


    interface ISwim
    {
        void Swim();
    }
    class Bird
    {
        public string name;
        public Bird(string name)
        {
            this.name = name;
        }

        public virtual void Walk()
        {
            Console.WriteLine("{0} is Walking.", name);
        }
    }

    class Sparrow : Bird, IFly
    {
        public Sparrow(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("麻雀{0} flying fast", name);
        }

        public override void Walk()
        {
            Console.WriteLine("麻雀{0}，蹦蹦跳跳的走路", name);
            //base.Walk();
        }
    }


    class Ostrich : Bird
    {
        public Ostrich(string name) : base(name)
        {
        }
        public override void Walk()
        {
            Console.WriteLine("鸵鸟{0},大步大步走路", name);
        }
    }

    class Penguin : Bird, ISwim
    {
        public Penguin(string name) : base(name)
        {
        }

        public void Swim()
        {
            Console.WriteLine("企鹅{0},在南极游泳", name);
        }

        public override void Walk()
        {
            Console.WriteLine("企鹅{0},张着翅膀走路", name);
        }
    }


    class Parrot : Bird, IFly
    {
        public Parrot(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("鹦鹉{0},一边说话一边飞", name);
        }
    }

    class Swan : Bird, IFly, ISwim
    {
        public Swan(string name) : base(name)
        {
        }

        public void Fly()
        {
            Console.WriteLine("天鹅{0},在空中优雅的飞", name);
        }

        public void Swim()
        {
            Console.WriteLine("天鹅{0},优雅的游泳", name);
        }
    }

    class Helicopter : IFly
    {
        public string name;
        public Helicopter(string name)
        {
            this.name = name;
        }

        public void Fly()
        {
            Console.WriteLine(" 直升机{0},在飞", name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IFly fly = new Parrot("Parrot1");
            fly.Fly();

            if (fly is ISwim)
            {
                (fly as ISwim).Swim();
            }
            if (fly is Bird)
            {
                (fly as Bird).Walk();
            }


            IFly ying = new Helicopter("helicopter");
            ying.Fly();
        }
    }
}
