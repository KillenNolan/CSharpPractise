using System;

namespace Lesson4_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   // 隐试转换
               int a = 10;
               Console.WriteLine(10/3);// 3
            */



            /*// 显示转换 Convert
            Console.WriteLine("Please input your English Score:");
            string enScore = Console.ReadLine();
            Console.WriteLine("Please input your Chinese Score:");
            string cnScore = Console.ReadLine();
            int sum = Convert.ToInt32(enScore) + Convert.ToInt32(cnScore);
            Console.WriteLine("TotalScore:" + sum);
            Console.WriteLine(Convert.ToSingle(i));// float ==>ToSingle 
            */


            /*// 显示转换 Parse
            string str = "12345";
            string str2 = "456";
            int i = int.Parse(str);
            int i2 = int.Parse(str2);
            Console.WriteLine(i+i2); 
            */


            /* // 显示转换 TryParse（Parse的高级用法）
             string str = Console.ReadLine();
             int num;
             bool b = int.TryParse(str, out num);
             string results = b ? "Correct" : "Wrong";
             Console.WriteLine("b:{0},num:{1},Result：{2}", b, num, results);
            */


            /*Console.WriteLine("Please input your math score:");
            string math = Console.ReadLine();

            Console.WriteLine("Please input your chinese score:");
            string chinese = Console.ReadLine();

            Console.WriteLine("Please input your english score:");
            string english = Console.ReadLine();


            int mathScore, englishScore, chineseScore;
            bool cnResults = int.TryParse(chinese, out chineseScore);
            bool mathResuts = int.TryParse(math, out mathScore);
            bool enResults = int.TryParse(english, out englishScore);
            string strRre = enResults && cnResults && mathResuts ?
                   "Total:" + (chineseScore + englishScore + mathScore) + "Average:" + (chineseScore + englishScore + mathScore) / 3.0f :
                   "Wrong Input";
            Console.WriteLine(strRre);

             */


            // 异常捕获
            try
            {
                string str = "123a";
                int i = int.Parse(str);
                Console.WriteLine("The data is:" + i) ;
            }
            catch (Exception  e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine( "Test");









        }
    }
}
