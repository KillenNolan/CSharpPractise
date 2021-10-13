using System;

namespace Lesson_3_GenericDelegate
{

    public delegate void Test(int a);
    public delegate void TestT<T>(T a);
    class Program
    {
        static void Main(string[] args)
        {
            //TestT<int> t = new TestT<int>(Test2);
            //t += Test;
            ////t += TestString;
            //t(2);

            // C#自定义委托Action可以是一个或者多个参数的泛型委托，但没有返回值
            Action<int, int> a = new Action<int, int>(Test);


            // C#自定义委托Func的最后一个参数是返回值，此处返回值是string类型的
            Func<int, string> f = new Func<int, string>(TestFunc);
            f += TestFunc2;
            string s = f(8);
            Console.WriteLine("s:" + s);
        }

        static string TestFunc(int x)
        {
            Console.WriteLine("x:" + x);
            return "TestFunc：" + x;
        }

        static string TestFunc2(int a)
        {
            Console.WriteLine("a    :" + a);
            return "TestFunc2：" + a;
        }

        static void TestString(string a)
        {
            Console.WriteLine("String:" + a);
        }

        static void Test(int a, int b)
        {
            Console.WriteLine("Test1 int:" + a);
        }


        static void Test2(int a)
        {
            Console.WriteLine("Test2 int:" + a);
        }
    }
}
