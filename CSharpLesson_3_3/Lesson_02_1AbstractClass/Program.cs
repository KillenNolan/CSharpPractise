using System;

/// <summary>
/// 1.用abstract修饰过的类是抽象类
/// 2.抽象类无法被实例化（就像静态类一样）
/// 3.子类继承抽象类，必须实现抽象类中所有的抽象成员
/// </summary>
namespace Lesson_02_1AbstractClass
{

    abstract class Person
    {

        public string name;

        /// <summary>
        /// 1.抽象类不能有对象
        /// 2.抽象方法只能在抽象类中
        /// 3.抽象方法没有函数体
        /// 4.子类必须实现抽象方法
        /// </summary>
        public abstract void SayHello();
        public void Test()
        {

        }

        /// <summary>
        /// 1.
        /// 2.虚方法可以在抽象类中，也可以在普通类中
        /// 3.虚方法有函数体
        /// 4.子类可以选择性的重写
        /// </summary>
        public virtual void Move() { }
    }


    class Student : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("学生走路{0}", name);
            //throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student();
            person.name = "Killen";
            person.SayHello();
        }
    }
}
