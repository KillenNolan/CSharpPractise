using System;

/// <summary>
/// 泛型单例类 
/// </summary>
namespace Lesson_06_Singleton
{

    class Person { }
    /// <summary>
    /// 这是一个单例的父类
    /// [where T : new()]：泛型约束
    /// new()约束:表示无参的构造函数 
    /// 想使用这个类，传过来的T必须要有无参构造函数
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public  class Sington<T> where T : new()
    {

   /*     /// <summary>
        /// 泛型约束
        /// 基类约束：约束T必须是 Person 类或者 Person 的子类
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void Show<T>(T t) where T : Person { }*/

        private static T instance;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new T();
                }
                return instance;
            }
        }
    }


    class Package : Sington<Package>
    {
        public Package() { }
        public Package(int x) { }

        public void Show(int i)
        {
            Console.WriteLine("Package show:" + i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Package.Instance.Show(2);
        }
    }
}
