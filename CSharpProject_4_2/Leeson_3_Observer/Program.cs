using System;

namespace Leeson_3_Observer
{
    /// <summary>
    /// 不明白为啥写接口，类不行吗？
    /// </summary>
    interface Subject
    {
        void Notify();
        string sujectState
        {
            get;
            set;
        }
    }


    delegate void Hander();
    class Teacher : Subject
    {
        string action;
        public string sujectState
        {
            get { return action; }
            set { action = value; }
        }

        public Hander notify;

        /// <summary>
        /// 触发委托
        /// </summary>
        public void Notify()
        {
            notify();
        }
    }


    class SleepStudent
    {
        string name;
        Subject sub;
        public SleepStudent(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }


        public void StopSleep()
        {
            Console.WriteLine("{0},{1},别再睡了", name, sub.sujectState);
        }
    }


    class ReadingStudent
    {
        string name;
        Subject sub;
        public ReadingStudent(string name, Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }


        public void StopRead()
        {
            Console.WriteLine("{0},{1},别再看小说了", name, sub.sujectState);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();

            ReadingStudent s1 = new ReadingStudent("Json", t);
            SleepStudent s2 = new SleepStudent("Killen", t);


            // 委托不安全，容易覆盖，怎么封装委托呢？
            // 所以Event事件出场了：封装委托类型的变量。
            // 不论在类的的内部是什么修饰词，在类的外部都是私有的，只能使用+=，-=
            t.notify += new Hander(s1.StopRead);
            t.notify += s2.StopSleep;

            t.sujectState = "老师来了";
            t.notify();
        }
    }
}
