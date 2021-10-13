using System;

namespace Lesson3_oneArr_3InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 22, 55, 99, 33, 66, 4, 88, 77, 55, 11 };


            // j不能等于0，没意义，和自己比吗？且i=j-1,若j=0,i就为负，会报错
            for (int j = 1; j < arr.Length; j++)
            {
                int select = arr[j];
                for (int i = j-1; i >= 0; i--)
                {
                    //比前面的大就停止，比前面小就换位置 
                    if (select > arr[i])
                        break;

                    arr[i + 1] = arr[i];
                    arr[i] = select;
                }

            }
           



            for (int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine(arr[i]+"\t");
            }
        }
    }
}
