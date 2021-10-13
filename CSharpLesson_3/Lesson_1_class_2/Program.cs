using System;

namespace Lesson_1_class_2
{
    class Bus
    {
        private int currentSpeed;
        private int maxSpeed;
        private int currentPersonCount;
        private int maxPersonCount;
        public string name;

        public Bus() { }
        public Bus(string name, int maxSpeed, int maxPersonCount)
        {
            this.name = name;
            this.maxSpeed = maxSpeed;
            this.maxPersonCount = maxPersonCount;
            currentPersonCount = 0;
            currentSpeed = 0;
        }

        /// <summary>
        /// 公交车行驶的方法
        /// </summary>
        public void Run(int speed)
        {
            currentSpeed += speed;
        }

        /// <summary>
        /// 乘客上下车
        /// </summary>
        public void UpAndDown(int count)
        {
            currentPersonCount += count;
        }

        /// <summary>
        /// 检测是否会出车祸
        /// </summary>
        public void Check()
        {
            if (currentPersonCount > maxPersonCount || currentSpeed > maxSpeed)
            {
                Console.WriteLine("要出车祸了");
            }
        }

        /// <summary>
        /// 显示当前车辆信息
        /// </summary>
        public void Show()
        {
            Console.WriteLine("当前速度:{0},当前乘客数:{1}",currentSpeed,currentPersonCount);
        }
    }


    class Person
    {
        public string name;

         public Person() { }
        public Person(string name)
        {
            this.name = name;
        }


        Bus bus;
        /// <summary>
        /// 乘客上车
        /// </summary>
        /// <param name="bus"></param>
        public void UpBus(Bus bus)
        {
            this.bus = bus;
            bus.UpAndDown(1);
            Console.WriteLine("{0}上了{1}这辆车", name, bus.name);
        }

        /// <summary>
        /// 乘客下车
        /// </summary>
        public void DownBus()
        {
            bus.UpAndDown(-1);
        }

    }

    class Driver
    {
        public string name;
        public Bus bus;

        public Driver(string name, Bus bus)
        {
            this.name = name;
            this.bus = bus;
        }

        public void AddSpeed()
        {
            bus.Run(10);
            Console.WriteLine("{0}加速了",name);
        }

        public void ReduceSpeed()
        {
            bus.Run(-10);
            Console.WriteLine("{0}减速了", name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Bus bus = new Bus("241", 50, 3);
            Driver driver = new Driver("Killen", bus);
            for (int i = 0; i < 5; i++)
            {
                driver.AddSpeed();
            }

            Person li = new Person("李四");
            li.UpBus(bus);
            bus.Show();

        }
    }
}
