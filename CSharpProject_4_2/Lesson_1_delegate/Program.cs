using System;


/// <summary>
/// 委托：是存有对某个方法或多个方法引用的一种引用类型
///       运行时可改变
///       可用于事件和回调
/// 委托和Lambda表达式一起使用更方便（匿名函数Lambda,没有函数名的函数）。
/// </summary>
namespace Lesson_1_delegate
{

    public delegate bool CompareSort(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            // 升序   降序
            int[] arr = new int[] { 1, 5, 6, 8, 9, 5, 1, 3 };
            /*Program.SortArray1(arr);
            Program.PrintData(arr);
            Program.SortArray2(arr);
            Program.PrintData(arr);*/

            SortArray(arr, CompareASC);
            PrintData(arr);
        }


        static bool CompareASC(int a, int b)
        {
            return a > b ? true : false;
        }

        static bool CompareDESC(int a, int b)
        {
            return a < b ? true : false;
        }

        static void PrintData(int[] arr)
        {
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }
        /// <summary>
        /// 委托，待做
        /// </summary>
        /// <param name="arr"></param>
        static void SortArray(int[] arr, CompareSort compare)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    // 1.arr[j] > arr[j + 1]提取出一个方法f
                    // 2.f是调用的人传进来的
                    // 委托能达到这个目的
                    if (compare(arr[j], arr[j + 1]))
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
        }


        /// <summary>
        /// 升序
        /// </summary>
        /// <param name="arr"></param>
        static void SortArray1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
        }

        /// <summary>
        /// 降序
        /// </summary>
        /// <param name="arr"></param>
        static void SortArray2(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
        }



    }
}
