using System;

namespace Lesson_4_deleAndEvent
{

    delegate void TestDele();
    class Manager
    {
        public TestDele dele;
        public event TestDele eventTest;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();

            m.dele = Test;
            m.dele = Test2;
            m.dele = null;
            m.dele();


            // 加完event后就只能用+=或者-=
            //m.eventTest = Test;
            m.eventTest += Test;
            //m.eventTest = null;
            //m.eventTest();


        }

        static void Test()
        {
            Console.WriteLine("Test1");
        }


        static void Test2()
        {
            Console.WriteLine("Test2");
        }


    }
}
