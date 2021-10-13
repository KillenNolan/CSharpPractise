using System;
using System.Threading;

namespace Lesson_1_delegate_demo
{

    public delegate void DelegateTest();
    //public delegate void DelegateTest(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
          /*  // Thread也是基于委托的
            Thread t = new Thread(Test1);
            t.Start();*/
            Console.WriteLine("__________________________________");

            /* //多波委托
             // 声明一个DelegeateTest委托，将Test1委托给dele
             DelegateTest dele = new DelegateTest(Test1);

             // 将Test2也委托给dele
             dele += Test2;

             *//*     // 1.执行这个委托
                  dele();*//* 
             // 2.执行这个委托
             dele.Invoke();

             Console.WriteLine("-----------------------------------------");
             dele -= Test1;
             dele();
 */

            // 将函数当成一个参数进行传递，载体就是委托
            Test(Test1);

        }
        static void Test(DelegateTest t)
        {
            t();
        }


        static void Test1()
        {
            Console.WriteLine("Test1");
        }

        static void Test2()
        {
            Console.WriteLine("Test2");
        }


    }
}
