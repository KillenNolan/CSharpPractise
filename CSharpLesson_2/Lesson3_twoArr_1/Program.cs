using System;

namespace Lesson3_twoArr_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*   //数组声明
               // 一维数组
               int[] iarr1 = new int[2];
               int[] iarr2 = { 1, 2, 3, 4, 5 };


               //二维数组:矩形的数据结构
               int[,] iiarr = new int[2, 3];
               int[,] iiarr2 = { { 1, 2, 3 }, { 4, 5, 6 } };
               int[,] iiarr3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };


               //行的长度
               Console.WriteLine(iiarr3.GetLength(0));
               //列的长度
               Console.WriteLine(iiarr3.GetLength(1));


               for (int i = 0; i < iiarr3.GetLength(0); i++)
               {
                   for (int j = 0; j < iiarr3.GetLength(1); j++)
                   {
                       Console.Write(iiarr3[i, j]);
                   }
                   Console.WriteLine();
               }
   */


            /* int num = 1;
             int[,] arr = new int[100, 100];
             for (int i = 0; i < arr.GetLength(0); i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                     arr[i, j] = num;
                     num++;
                     Console.WriteLine(arr[i,j]);
                 }
             }*/
            /*对角线右上置0
            int[,] arr = new int[,] { { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = i + 1; j < arr.GetLength(1); j++)
                {
                    if (j >= i)
                    {
                        arr[i, j] = 0;
                    }                    
                }                
            }*/

            /*
            //求对角线之和 
            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    //i+j==3:几行几列
                    if (i == j || i + j == 3)
                    {
                        sum += arr[i, i];
                    }

                }
            }
            
            Console.WriteLine(sum);*/



            /*// 随机(1,500),求最大元素号及其行列号
            int Max = 0, rowIndex = 0, cellIndex = 0;
            int[,] arr = new int[5, 5];
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1, 500);
                    if (arr[i, j] > Max)
                    {
                        Max = arr[i, j];
                        rowIndex = i;
                        cellIndex = j;
                    }
                }
            }

            Console.WriteLine("Max:{0},roIndex:{1},cellIndex:{2}", Max, rowIndex, cellIndex);*/




            /* // string 转二维数组 unfinished
             string str = "1;2;3;4;5;6;7;8;9";
             int[,] arr = new int[3, 3];


 */


            //// 给一个M*N的二维数组，数组元素的值为0或者1，要求转换数组，将含有1的行和列全部置1
            //int[,] arr = new int[5, 5];
            //Random random = new Random();
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = random.Next(0, 2);
            //    }
            //}

            int[,] arr = {
                { 0, 0,1 ,0 },
                { 1, 0,1 ,0 },
                { 0, 0,1 ,0 },
                { 0, 0,0 ,0 }  };

            int[] x = new int[arr.GetLength(0)];
            int[] y = new int[arr.GetLength(1)];


            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 1)
                    {
                        x[i] = 1;
                        y[j] = 1;
                    }
                }
            }

            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}
            //for (int i = 0; i < y.Length; i++)
            //{
            //    Console.WriteLine(y[i]);
            //}


            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == 1 || y[j] == 1)
                    {
                        arr[i, j] = 1;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }






        }
    }
}
