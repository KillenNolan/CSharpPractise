using System;


/// <summary>
/// 对象生命周期案例
/// 1.定义人类,属性有姓名,性别,爱人,秀恩爱的方法
/// 2.张三的女朋友是李四,当张三意外"死亡",此时,张三对象会销毁吗?      zhangsan=null,不会,此时lisi的lover还指向zhangsan
/// 3.怎样才能让张三这个对象销毁?     lisi.lover.name=null,此时彻底没有人指向张三.
/// </summary>
namespace Lesson_2_ObjectsCycleDemo
{


    class Person
    {
        public string name;
        public char sex;
        public Person lover;

        public Person(string name, char sex)
        {
            this.name = name;
            this.sex = sex;
        }

        public void ShowRomatic()
        {
            if (lover == null)
            {
                Console.WriteLine("No lover, can't show romantic");
                return;
            }
            Console.WriteLine("我是{0},我的对象是{1}", name, lover.name);
        }

        /// <summary>
        /// 析构函数Destructor
        /// 没有任何变量指向这个对象空间
        /// </summary>
        ~Person()
        {
            Console.WriteLine(name + " is dead.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
