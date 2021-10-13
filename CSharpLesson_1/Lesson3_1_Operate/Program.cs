using System;

namespace Lesson3_1_Operate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int age = 18;
              Console.WriteLine(age++);
              Console.WriteLine(age);

              string results = age >= 18 ? "Adults" : "Child";

              int num = 10;
              Console.WriteLine(++num);
              Console.WriteLine(num);*/

            /*            // 逻辑运算符 &与 |或 ！非 &&双与 ||双或
                        // &，运算级别较低，先计算出两边表达式的结果，再进行进行比较
                        // &&，运算级别较高，(当左边的表达式结果为false，则不计算右边的表达式)其中一个为false，则不计算另一个，直接返回false
                        // ||，运算级别较高，(当左边的表达式结果为true，则不计算右边的表达式)其中一个为true，则不计算另一个，直接返回true
                        // 单与/非效率更低，且结果与双与/非一样
                        // both true then true &与
                        var bo = age > 10 & num > 10;
                        Console.WriteLine(bo);


                        //one true then true |或
                        bo = age > 10 | num > 10;
                        Console.WriteLine(bo);


                        //取反 !非
                        bo = !bo;
                        Console.WriteLine(bo);*/


            /*int a = 10;
            Console.WriteLine(a > 0 | ++a > 20);//11

            int b = 10;
            Console.WriteLine(b > 0 || ++b > 20);//10
            Console.WriteLine("a:" + a + ",b:" + b);*/

            /* // 证明双与的优先级>双或的优先级
             // 双与双或也称为“短路运算”
             Console.WriteLine(true || true && false);*/

            /*  // 判断一个年份是不是闰年
              // 闰年：1.能被400整除 2.年份能被4整除，但不能被100整除
              int year = 2021;
              bool bo = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);

              bool b1 = year % 400 == 0;
              bool b2 = (year % 4 == 0) && (year % 100 != 0);
              Console.WriteLine(bo);
              Console.WriteLine(b1 || b2 ? "闰年" : "平年");*/


            /* //字符串格式化输出
             int age = 18;
             string sex = "female";
             Console.WriteLine("Age:{0},Sex:{1}", age, sex);
             Console.WriteLine("Age:" + age + ",Sex:" + sex);*/


            /* Console.WriteLine("What's your favorite sports?");
             string sports = Console.ReadLine();
             Console.WriteLine( "Haha, I like it too!");*/

            Console.WriteLine("Please input your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please input your Chinese score:");
            string CnScore = Console.ReadLine();
            Console.WriteLine("Please input your English score:");
            string EnScore = Console.ReadLine();
            Console.WriteLine("Please input your Math score:");
            string MathScore = Console.ReadLine();

            int sum = Convert.ToInt32(CnScore) + Convert.ToInt32(EnScore) + Convert.ToInt32(MathScore);
            Console.WriteLine("{0}，Total：{1}，Average：{2}", name, sum, sum / 3.0f);






        }
    }
}
