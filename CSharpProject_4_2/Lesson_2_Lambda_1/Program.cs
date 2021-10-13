using System;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// 匿名函数
/// </summary>
namespace Lesson_2_Lambda_1
{
    public delegate void Test();
    class Program
    {
        static void Main(string[] args)
        {
            //匿名方法是没有名称只有主体的方法
            //delegate (Paramter)
            //{
            //    方法快
            //}


            // 匿名函数
            Test de = new Test(
            delegate ()
            {
                Console.WriteLine("匿名函数");
            });
            de();


            //Lambert表达式
            Test de2 = new Test(() => { Console.WriteLine("Lambda1"); });
            Test de3 = new Test(() => Console.WriteLine("Lambda2"));
            de2();
            de3();


            //排序委托实现   
            List<int> ll = new List<int>();
            ll.Add(1);
            ll.Add(2);
            ll.Add(10);
            ll.Add(12);
            ll.Add(11);
            ll.Add(20);

            for (int i = 0; i < ll.Count; i++)
            {
                Console.WriteLine(ll[i]);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            // 如果ll列表中有该数字，则返回该数字，没有返回0--》委托时讲解
            Console.WriteLine(ll.Find((a) =>
            {
                return a == 8;
            }));

            ll.Sort((x, y) =>
            {
                return x - y;
            });

            Console.WriteLine("+++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < ll.Count; i++)
            {
                Console.WriteLine(ll[i]);
            }
        }
    }
}
