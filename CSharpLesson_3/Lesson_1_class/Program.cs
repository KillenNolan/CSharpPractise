using System;

namespace Lesson_1_class
{
    class Person
    {
        public string name;
        public int age;
        /// <summary>
        /// 类的属性可以设置默认值
        /// </summary>
        public string country = "China";

        /// <summary>
        /// 可以声明无参构造函数,结构体不可以
        /// </summary>
        public Person()
        {

        }

        /// <summary>
        /// 构造函数重载
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="country"></param>
        public Person(string name, int age, string country = "China")
        {
            this.name = name;
            this.age = age;
            this.country = country;
        }

    }

    class Ticket
    {
        private float distance;
        private float price;


        public Ticket(float distance)
        {
            this.distance = distance;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="distance"></param>
        /// <returns></returns>
        public float GetPrice(float distance)
        {
            if (distance <= 0)
            {
                return 0;
            }
            else if (distance <= 100)
            {
                price = distance;
            }
            else if (distance <= 200)
            {
                price = 100 + (distance - 100) * 0.95f;
            }
            else if (distance <= 300)
            {
                price = 100 + 100 * 0.95f + (distance - 200) * 0.9f;
            }
            else
            {
                price = 100 + 100 * 0.95f + 100 * 0.9f + (distance - 300) * 0.8f;
            }
            return price;
        }


        /// <summary>
        /// 显示票的信息
        /// </summary>
        public void ShowicketInfo()
        {
            Console.WriteLine("距离:{0},价格:{1}", distance, GetPrice(distance));

        }
    }
     
    
    class Program
    {
        static void Main(string[] args)
        {
            //类的对象是引用数据类型



            Ticket ticket = new Ticket(1000);
            ticket.ShowicketInfo();


        }
    }
}
