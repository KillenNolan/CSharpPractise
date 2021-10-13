using System;

namespace Lesson_4_1staticClass_1
{

    /// <summary>
    /// 静态类在整个项目中是资源共享的，唯一的
    /// 静态类在程序结束时释放资源。 ----------静态类和程序同生共死
    /// 因此静态类在项目中应该越少越好。 ----------单利设计模式
    /// </summary>
    static class Tools
    {
        
        public static void Test() { 
        
        }


        public static void Write(int x,int y,string str,ConsoleColor consoleColor=ConsoleColor.Red)
        {            
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.Gray;
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Tools.Write(10, 5,"I love Python");
        }
    }
}
