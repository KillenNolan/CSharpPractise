using System;

namespace Lesson3_oneArr_1BubblSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buble Sort
            int[] arr = { 8, 5, 6, 2, 3, 1, 0, 7, 4, 9 };
            for (int j = 0; j < arr.Length - 1; j++)
            {
                //for (int i = 0; i < arr.Length - 1; i++)
                for (int i = 0; i < arr.Length - 1 - j; i++)//优化，因为第一轮最后一个数字已经是最大的
                {
                    if (arr[i] < arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }











        }
    }
}
