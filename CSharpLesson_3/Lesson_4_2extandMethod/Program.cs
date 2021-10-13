using System;

/// <summary>
/// 将一个字符串的首字母自动大写
/// </summary>
namespace Lesson_4_2extandMethod
{

    static class Tools
    {
        public static string UpFirstLetter(string str)
        {
            char[] strs = str.ToCharArray();
            string s = str.ToUpper();
            strs[0] = s.ToCharArray()[0];
            string newStr = "";
            for (int i = 0; i < strs.Length; i++)
            {
                newStr += strs[i];
            }
            return newStr;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string str = "i love python";
            Console.WriteLine(Tools.UpFirstLetter(str));
        }


    }
}
