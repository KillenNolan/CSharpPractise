using System;


/// <summary>
/// 高档热水器，通电，水温>95时，
/// 1.扬声器发出语音，告诉水的温度；2.液晶屏显示水温，提示水快开了 
/// </summary>
namespace Lesson_4_deleEvent_2
{
    delegate void TemHander(int tem);
    class Heater
    {
        public event TemHander boiled;
        public int temperature;
        public void Boiled()
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i;

                if (i > 95)
                {
                    if (boiled != null)
                    { 
                        boiled(temperature);
                    }

                }
            }
        }
    }

    class Display
    {
        public void Show(int tem)
        {
            Console.WriteLine("当前温度：{0}", tem);
        }

    }

    class Alert
    {
        public void Alarm(int tem)
        {
            Console.WriteLine("快来人啦，热水器：{0}度了", tem);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Heater h = new Heater();

            Display d = new Display();
            Alert a = new Alert();

            h.boiled += d.Show;
            h.boiled += a.Alarm;

            h.Boiled();

        }
    }
}
