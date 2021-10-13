using System;
using System.Collections.Generic;

namespace Lesson_07_List_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ll = new List<int>();
            ll.Add(1);
            ll.Add(2);
            //Console.WriteLine(ll[0] + ll[1]);
            //Console.WriteLine(ll.Capacity);
            //Console.WriteLine(ll.Count);

            List<int> l2 = new List<int>();
            l2.Add(0);
            l2.Add(10);

            ll.AddRange(l2);

            /*
                        ll.Clear();
                        for (int i = 0; i < ll.Count; i++)
                        {
                            Console.WriteLine(ll[i]);
                        }


                        if (ll.Contains(1))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No");
                        }*/


            int[] arr = new int[5];//length:4 Capacity:0

            ll.CopyTo(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("-----------------------");

            //// 涉及到了委托，后面的课会讲
            //Console.WriteLine(ll.Find((i) => { return true; }) );

            ll.Sort();
            for (int i = 0; i < ll.Count; i++)
            {
                Console.WriteLine(ll[i]);
            }
            Console.WriteLine("-----------------------");


            int[] arr1 = ll.ToArray();
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("-----------------------");

        }

        static void Show<T>(T t)
        {
            Console.WriteLine(t);

        }



    }
}
