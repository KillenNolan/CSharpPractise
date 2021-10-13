using System;
using System.Collections;

/// <summary>
/// ArrayList动态数组：联连续的空间，需要装/拆箱
/// HashTable哈希表：散列
/// Stack堆栈：先进后出
/// Queue队列：先进先出
/// </summary>
namespace Lesson_03_Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            // 声明栈对象
            Stack stack = new Stack();

            // 压栈，进栈
            stack.Push("Killen");
            stack.Push(27);
            stack.Push('F');


            /*  // 取得栈顶元素，但这个元素不出栈（弹栈）
              object o = stack.Peek();
              Console.WriteLine(o);


              // 取得栈顶元素，并且这个元素出栈
              object o2 = stack.Pop();
              Console.WriteLine(o2); */

            /* if (stack.Contains(27))
             {
                 Console.WriteLine(true);
             }
             else
             {
                 Console.WriteLine(false);
             }

             // 栈中元素数量
             Console.WriteLine(stack.Count);
 */


            // 打印时是倒序输出的
            object[] o = stack.ToArray();
            for (int i = 0; i < o.Length; i++)
            {
                Console.WriteLine(o[i]);
            }


        }
    }
}
