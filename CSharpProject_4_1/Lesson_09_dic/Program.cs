using System;
using System.Collections.Generic;


/// <summary>
/// 方便修改和查找，高於list
/// 字典一般都是查詢的，很少遍歷
/// </summary>
namespace Lesson_09_dic
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1001, "jack");
            dic.Add(1002, "Killen");
            dic.Add(1003, "Sarah");

            // key存在的话则修改值，不存在则会创建并赋值
            // 修改，添加元素
            dic[1004] = "John";

            //// 查询时比遍历的效率高
            //if (dic.ContainsKey(1003))
            //    Console.WriteLine(dic[1003]);
            ////Console.WriteLine(dic[1004]);



            //foreach (var item in dic.Keys)
            //{
            //    Console.WriteLine(dic[item]);
            //}

            //foreach (var item in dic.Values)
            //{
            //    Console.WriteLine(item);
            //}
            {
                int.TryParse("123", out int num);
                Console.WriteLine(num);
                //string name;
                if (dic.TryGetValue(1003, out string name))
                {
                    Console.WriteLine(name);
                }
                else
                {
                    Console.WriteLine("no");
                }
            }

            // 键值对
            // <John,<English,Score>>
            // Killen   Math        Score
            //KeyValuePair<string, int> keyValue = new KeyValuePair<string, int>();
            Dictionary<string, KeyValuePair<string, int>> scores = 
                new Dictionary<string, KeyValuePair<string, int>>();
            scores.Add("John", new KeyValuePair<string, int>("english", 100));
            scores.Add("Sarah", new KeyValuePair<string, int>("math", 100));


            Console.WriteLine("================================");
            foreach (var item in scores.Keys)
            {                
                Console.WriteLine("name:{0},{1}:{2}",item,scores[item].Key,scores[item].Value );
            }







        }
    }
}
