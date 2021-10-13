using System;
// 1.引入命名空间
using System.Threading;

namespace Lesson_03_Thread
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.开辟一条线程
            Thread thread = new Thread(Testthread);
            // 3.开启线程
            thread.Start();
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                if (input == 'S')
                {

                    // 4.销毁线程
                    // thread.Abort()销毁时报错Thread abort is not supported on this platform
                    // .net 5 ++ 版本  不支持 Thread.Abort
                    thread.Interrupt();
                    
                }
                Console.WriteLine(input);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        static void Testthread()
        {
            while (true)
            {
                // 2.1 线程的具体操作，休眠800毫秒
                Thread.Sleep(800);
                Console.WriteLine("TestThread");

            }

        }
    }
}
