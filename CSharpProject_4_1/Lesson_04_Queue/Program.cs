using System;
using System.Collections;

namespace Lesson_04_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();

            // 进入队列
            q.Enqueue(1);
            q.Enqueue("Killen");
            q.Enqueue(5);


            object o1 = q.Dequeue();
            Console.WriteLine(o1);


            object o2 = q.Dequeue();
            Console.WriteLine(o2);

            // 队列元素的数量
            Console.WriteLine(q.Count);


            if (q.Contains(1))
            {
                Console.WriteLine("have");
            }
            else
            {
                Console.WriteLine("No");
            }




        }
    }
}
