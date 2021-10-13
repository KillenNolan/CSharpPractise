using System;

namespace Lesson7_OutRef_1
{
    class Program
    {

        /// <summary>
        /// out:使用变量的地址
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            /*   string str = "123";
               int num;
               int.TryParse(str, out num);*/




            /*int x = 100;
            Test1(x);
            Console.WriteLine("x:{0}", x);

            // 调用out参数函数时，可以不对变量赋值
            // int y = 100; 
            Test2(out int y);
            Console.WriteLine("y:{0}", y);



            // 调用时，变量必须有初始值
            int c =10;
            Test3(ref c);
            Console.WriteLine("c:{0}", c);*/



            Console.WriteLine("Please enter your username:");
            string user = Console.ReadLine();
            Console.WriteLine("Please enter your password:");
            string pwd = Console.ReadLine();


            string info = "Login Success";
            if (Login(user, pwd, ref info))
                Console.WriteLine("{0},Welcome home", info);
            else
                Console.WriteLine(info);


        }

        static bool Login(string user, string pwd, ref string strMsg)
        {
            if (user == "admin" && pwd == "123456")
            {
                return true;
            }
            else if (user == "admin")
            {
                strMsg = "Your username is wrong";
                return false;
            }
            else
            {
                strMsg = "Your password is wrong";
                return false;

            }

        }



        /// <summary>
        /// ref 调用时，变量必须有初始值;在函数中对ref参数可以不赋值
        /// 1. 使用变量的地址
        /// </summary>
        /// <param name="a"></param>
        static void Test3(ref int a)
        {
            a = 0;
        }


        /// <summary>
        /// out 调用时,可以不初始化变量;在函数中必须对out参数赋值
        /// 1. 使用变量的地址
        /// </summary>
        /// <param name="a"></param>
        static void Test2(out int a)
        {
            a = 0;
        }

        static void Test1(int a)
        {
            a = 0;
        }

    }
}
