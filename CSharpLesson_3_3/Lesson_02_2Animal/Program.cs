using System;


/// <summary>
/// 动物的抽象类，实现两个子类猫猫狗狗叫
/// </summary>
namespace Lesson_02_2Animal
{


    abstract class Animal
    {
        public string name;

        public abstract void Shut();
    }


    class Dog : Animal
    {
        public Dog(string name)
        {
            this.name = name;
        }
        public override void Shut()
        {
            Console.WriteLine("Dog {0} is Crying", name);
            //throw new NotImplementedException();
        }
    }

    class Cat : Animal
    {
        public Cat(string name)
        {
            this.name = name;
        }

        public override void Shut()
        {
            Console.WriteLine("Cat {0} is Crying", name);
            //throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Cat("Cathy");
            animals[1] = new Dog("Dudu");
            animals[2] = new Dog("Dudu2");
            // 相同的方法，作用于不同的对象，产生不同的效果。
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Shut();
            }

        }
    }
}
