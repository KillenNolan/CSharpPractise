using System;
using System.Collections;

namespace Lesson_02_hashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            // 添加元素：键值对(key,value)
            // key是唯一的unique;only;
            ht.Add("name", "Killen");
            ht.Add("age", "27");
            ht["sex"] = '女';

            // 会报错，因为"name"key已经存在，不能重复
            //ht.Add("name", "Killen2");
            // 不会报错，合法的，相当于为"name"key 重新赋值或者说修改了"name"key的值
            ht["name"] = "Nolan";


            // 根据key取Value值
            Console.WriteLine(ht["name"]);
            Console.WriteLine(ht["sex1"]);

            /*            // 删除指定key的值
                        ht.Remove("name");
                        ht.Remove("ll");*/


            /*            if (ht.ContainsKey("age"))
                        {
                            Console.WriteLine("Contains Key");
                        }
                        else
                        {
                            Console.WriteLine("Not Contains Key");
                        }*/


            /* if (ht.ContainsValue("27"))
             {
                 Console.WriteLine("Contains value");
             }
             else
             {
                 Console.WriteLine("Not Contains value");
             }*/


            Console.WriteLine("-------------------------");
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }


            Console.WriteLine("-------------------------");
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
