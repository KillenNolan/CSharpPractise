using System;
    
namespace Lesson_3_classAndStruct
{

    class Person
    {
        // 非静态变量:访问方式, 通过实例化的对象来访问
        public int age;

        // 静态变量:属于所有对象共享
        public static string country;

        public void Show()
        {
            Console.WriteLine("age:{0},country:{1}", age, country);
        }


        /// <summary>
        /// 静态方法:通过类名调用
        /// </summary>
        public static void StaticTest()
        {
            // 代码存储在硬盘中,将硬盘中的代码加载到内存中.
            // 类加载到内存:静态先被加载,非静态后加载
            // 非静态函数可以使用静态变量,反之不行
            //Console.WriteLine(age);
        }
    }

    class Program
    {
        // 静态变量
        static int age;


        // 静态方法
        static void Main(string[] args)
        {

            // 访问方式, 通过实例化的对象来访问
            Person person = new Person();
            person.age = 10;


            // 访问方式, 类名.静态变量名
            Person.country = "China";
            person.Show();

        }
    }
}
