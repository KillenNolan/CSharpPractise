using System;
using System.Collections;

namespace Lesson_01_ArrayList
{
    /// <summary>
    /// 怎样测试冒泡排序额和ArrayList的Sort()方法谁快？
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {


            /*       // 声明一个ArrayList
                   ArrayList arrayList = new ArrayList();


                   // 添加一个元素
                   arrayList.Add(1);
                   arrayList.Add(15);
                   arrayList.Add(10);
                   arrayList.Add(17);
                   arrayList.Add(13);
                   arrayList.Add(5);*/

            #region 基本API
            /* PrintInfo(arrayList);

             // 按值删除找到的第一个元素
             arrayList.Remove(1);

             // 按照索引(指定下标)删除数据
             arrayList.RemoveAt(1);

             PrintInfo(arrayList);

             // 插入一个元素
             arrayList.Insert(1, 6);
             PrintInfo(arrayList); 

             Console.WriteLine("Capacity:{0},Count:{1}", arrayList.Capacity, arrayList.Count);
 */

            // 针对int类型排序
            //PrintInfo(arrayList);
            //arrayList.Sort();
            //PrintInfo(arrayList);
            #endregion
            // 怎样测试冒泡排序和ArrayList的Sort()方法谁快？
            // 冒泡排序是最慢的
            int[] arr = new int[40000];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 40000);
            }

            //int[] arr =  { 1, 2, 8, 6, 9, 7, 2, 4 } ;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            PrintArr(arr);

            /*  ArrayList al = new ArrayList();
              Random random = new Random(); 
              for (int i = 0; i < 40000; i++)
              {
                  al.Add(random.Next(0, 40000));
              }

              al.Sort();
              PrintAl(al);*/
        }

        static void PrintArr(int[] arrayList)
        {
            Console.WriteLine();
            for (int i = 0; i < arrayList.Length; i++)
            {
                // 通过索引器访问元素
                Console.WriteLine(arrayList[i]);
            }
        }

        static void PrintAl(ArrayList arrayList)
        {
            Console.WriteLine();
            Console.WriteLine(arrayList.Count);
            for (int i = 0; i < arrayList.Count; i++)
            {
                // 通过索引器访问元素
                Console.WriteLine(arrayList[i]);
            }
        }
    }
}
