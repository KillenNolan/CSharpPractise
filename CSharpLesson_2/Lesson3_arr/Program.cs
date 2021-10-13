using System;

namespace Lesson3_oneArr
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// new初始化：分配内存空间
            int[] array = new int[2];
            array[0] = 1;
            array[1] = 2;

            // 先声明，后分配
            int[] iArr;
            iArr = new int[2];
            iArr[0] = 1;

            // 直接对数组进行赋值
            string[] strArr = { "1", "2", "3" };

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }*/

            /*int[] aArr = new int[10];
            for (int i = 0; i < aArr.Length; i++)
            {
                aArr[i] = i;
                //Console.WriteLine("i:{0},aArr:{1}", i, aArr[i]);
            }

            int[] bArr = new int[aArr.Length];
            for (int i = 0; i < bArr.Length; i++)
            {
                bArr[i] = aArr[i] * 2;
            }

            Console.WriteLine(aArr[5]);
            Console.WriteLine(bArr[5]);*/

            /*  Random random = new Random();
              int[] iArr = new int[10];
              for (int i = 0; i < iArr.Length; i++)
              {
                  iArr[i] = random.Next(0, 100);
                  Console.WriteLine(iArr[i]);
              }


              int sum = 0;
              float average = 0;
              int Max = 0, Min = 100, Temp;
              for (int i = 0; i < iArr.Length; i++)
              {
                  sum += iArr[i];
                  if (iArr[i] > Max)
                  {
                      Max = iArr[i];
                  }

                  if (iArr[i] < Min)
                  {
                      Min = iArr[i];
                  }
              }

              Console.WriteLine("Max:{0},Min:{1},Sum:{2}，Average:{3}", Max, Min, sum, sum/iArr.Length);
          */


            /*// 交换9-1；2  -8...
            int[] iArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < iArray.Length / 2; i++)
            {
                int temp = iArray[i];
                iArray[i] = iArray[iArray.Length - 1 - i];
                iArray[iArray.Length - 1 - i] = temp;

            }
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine(iArray[i]);
            }*/


            /*
             // 切割字符串成数组
             string str = "10|108|99|5";
             string[] strs = str.Split('|');
             for (int i = 0; i < strs.Length; i++)
             {
                 Console.WriteLine(strs[i]);
             }*/

            /*Console.WriteLine("please enter \"10|20|30|40\"");
            string input = Console.ReadLine();
            string[] strs = input.Split('|');
            int[] nums = new int[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
                int.TryParse(strs[i], out nums[i]);
                nums[i]++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }*/

            /*//正数+1，负数-1
            int[] iArray = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                iArray[i] = random.Next(-100, 100);
                Console.Write(iArray[i]+"\t");
                if (iArray[i] > 0)
                    iArray[i]++;
                else
                    iArray[i]--;

                Console.WriteLine(iArray[i]);
            }*/



            Console.WriteLine("Please enter student's score, using , to split");
            string input = Console.ReadLine();

            int[] scoreArray = new int[10];
            string[] Score = input.Split(','); 
            for (int i = 1; i <= scoreArray.Length; i++)
            {
                //Console.WriteLine("Please enter number {0} student's math score", i);
                //Score[i] = Console.ReadLine();
                int.TryParse(Score[i], out scoreArray[i]);
            }

            int sum = 0, Max = 0, Min = 100;
            float average = 0;
            for (int i = 0; i < scoreArray.Length; i++)
            {
                sum += scoreArray[i];
                if (scoreArray[i] > Max)
                    Max = scoreArray[i];

                if (scoreArray[i] < Min)
                    Min = scoreArray[i];
            }
            Console.WriteLine("Max:{0},Min:{1},Sum:{2},Average:{3}", Max, Min, sum, sum / scoreArray.Length);



        }
    }
}
