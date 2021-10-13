using System;

namespace Lesson5_Function_2Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.WriteLine(GetMax(5, 6));

             float r = 5.6f;
             float[] circle = CaculateArea(r);

             Console.WriteLine("Length:{0},Area:{1}", circle[0], circle[1]);*/
            /* int[] arr = { 1, 2, 3, 4, 6, 5, 7, 8, 9 };
             AboutArray(arr);*/


            /*  int[] arr = { 2, 5, 6, 8, 9, 7 };
              WriteLineArrLine(SortArray(arr));*/


            int year = 2021;
            Console.WriteLine("Year:{0},Runnian:{1}",year, IsRunnian(year));
            



        }


        /// <summary>
        /// 判断是否是闰年
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        static bool IsRunnian(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                return true;
            return false;
        }



        /// <summary>
        /// 将数组进行排序
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        static int[] SortArray(int[] arr)
        //static void SortArray(int[] arr)
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
            return arr;
        }



        /// <summary>
        /// 将一维数组打印在屏幕上
        /// </summary>
        /// <param name="arr"></param>
        static void WriteLineArrLine(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }



        /// <summary>
        /// 将一维数组打印在屏幕上
        /// </summary>
        /// <param name="arr"></param>
        static void WriteLineArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
        }



        /// <summary>
        /// 判断一个数是不是质数：只能被1和自身整除的数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        static bool JudgeZhishu(int num)
        {
            bool bo = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    bo = false;
                    break;
                }
            }

            return bo;
        }



        /// <summary>
        /// 求一个数组的总和，最大值，最小值，平均值
        /// </summary>
        /// <param name="arr"></param>
        static void AboutArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("The length of this Array is 0");
                return;
            }

            int max = arr[0], min = arr[0], sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }

                if (arr[i] < min)
                {
                    min = arr[i];
                }
                sum += arr[i];
            }
            Console.WriteLine("Max:{0},Min:{1},Sum:{2},Average:{3}", max, min, sum, sum / arr.Length);
        }



        /// <summary>
        /// 计算圆的周长和面积
        /// 周长：2πR
        /// 面积: πR²
        /// </summary>
        /// <param name="ridus">半径</param>
        /// <returns></returns>
        static float[] CaculateArea(float ridus)
        {
            float[] arr = new float[2];
            arr[0] = 2 * 3.14f * ridus;
            arr[1] = 3.14f * ridus * ridus;
            return arr;
        }


        /// <summary>
        /// 返回最大值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int GetMax(int a, int b)
        {
            /*int max = a;
            if (b>a)
            {
                max = b;
            }
            return max;*/

            return a > b ? a : b;
        }



    }
}
