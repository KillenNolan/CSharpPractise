using System;

namespace Lesson3_oneArr_2SelectSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select Sort 
            int[] arr = { 8, 59, 6, 288, 3, 11, 0, 7, 44, 9 };

            for (int j = 0; j < arr.Length; j++)
            {
                int min = arr[j], index = j;
                for (int i = j; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                        index = i;
                    }
                }
                arr[index] = arr[j];
                arr[j] = min;
                
                //int temp = arr[j];
                //arr[j] = arr[index];
                //arr[index] = temp;
                
            }


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }





        }
    }
}
