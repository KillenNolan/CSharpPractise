using System;

namespace Lesson_jaggedArr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 交错数组：设计不规则的结构
            int[][] CrossArray = new int[3][];
            int[][] CrossArray1 = new int[2][] {
                new int[] { 1, 2 },
                new int[] {1,2,5,8,9 }
            };

            for (int i = 0; i < CrossArray1.GetLength(0); i++)
            {
                for (int j = 0; j < CrossArray1[i].Length; j++)
                {
                    Console.WriteLine(CrossArray1[i][j] + "\t");
                }
                Console.WriteLine();
            }


            /*  foreach
             * 优点：不会造成数组越界
             * 缺点：不能对迭代的元素进行修改*/

            int[] arr2 = { 1, 2, 3, 4, 5, 6 };
            foreach (var item in arr2)
            {
                Console.Write(item + "\t");
                arr2[3] = 1;
                // 不能修改迭代变量
                //item = 0;
            }
            Console.WriteLine();



            foreach (int[] rows in CrossArray1)
            {
                foreach (int cell in rows)
                {
                    Console.Write(cell + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
