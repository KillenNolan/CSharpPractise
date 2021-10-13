using System;

/// <summary>
/// 不同鸭子不同叫声
/// </summary>
namespace Lesson_01_2DuckTest
{


    class Duck
    {
        public string name;
        public Duck(string name)
        {
            this.name = name;
        }


        public virtual void Call()
        {
            Console.WriteLine("Father call()");
        }
    }



    class RealDuck : Duck
    {
        public RealDuck(string name) : base(name)
        {

        }


        public override void Call()
        {
            Console.WriteLine("ReaDuck {0} Quack 嘎嘎叫 call()", name);
            //base.Call();
        }

    }


    /// <summary>
    /// 木头鸭子WoodDuck
    /// </summary>
    class ToyDuck : Duck
    {
        public ToyDuck(string name) : base(name)
        {

        }


        public override void Call()
        {
            Console.WriteLine("ToyDuck {0} Squeak 吱吱叫 call()", name);
            //base.Call();
        }

    }


    /// <summary>
    /// 橡皮鸭子
    /// </summary>
    class RubberDuck : Duck
    {
        public RubberDuck(string name) : base(name) { }

        public override void Call()
        {
            Console.WriteLine("RubberDuck {0} Chrip 唧唧叫  call()", name);
            //base.Call();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // 多态：相同的方法作 作用于不同的对象 产生不同的效果
            //Duck duck = new RealDuck("KK");
            Duck[] ducks = new Duck[4];
            ducks[0] = new Duck("Father duck");
            ducks[1] = new ToyDuck("Toy duck");
            ducks[2] = new RealDuck("Real duck");
            ducks[3] = new RubberDuck("Rubber duck");
            foreach (var item in ducks)
            {
                item.Call();
            }
        }
    }
}
