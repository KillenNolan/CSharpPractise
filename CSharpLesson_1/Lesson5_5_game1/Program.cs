using System;

namespace Lesson5_5_game1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* // 产生随机数
             for (int i = 0; i < 100; i++)
             {
                 // 加入种子i混乱度更高
                 Random rd = new Random(i);
                 int num = rd.Next(1, 100);
                 Console.WriteLine("num:" + num);                                           
             }*/

            int Ultraman_hp = 100;
            int Ultraman_minAttack = 8;
            int Ultraman_maxAttack = 12;
            int Ultraman_rate = 80;

            int Monster_hp = 100;
            int Monster_minAttack = 5;
            int Monster_maxAttack = 8;
            int Monster_rate = 60;

            Random random = new Random();

            while (true)
            {
                Console.WriteLine(  "Altman press any key to start attack:");
                Console.ReadKey();
                int atk = random.Next(Ultraman_minAttack, Ultraman_maxAttack);
                int num = random.Next(1, 100);
                if (num<Ultraman_rate)
                    Monster_hp -= atk;
                else
                    Console.WriteLine("Missing attack:Altman");

                Console.WriteLine("Altman's attack:{0},Monster's blood volume:{1}",atk,Monster_hp);
                if (Monster_hp<=0)
                {
                    Console.WriteLine("Altman win ");
                    break;
                }


                Console.WriteLine("Press any key to start the round");
                Console.ReadKey();
                int atc_mon = random.Next(Monster_minAttack, Monster_maxAttack);
                int num2 = random.Next(1, 100);
                if (num2 < Monster_rate)
                    Ultraman_hp -= atc_mon;
                else
                    Console.WriteLine("Missing attack:Monster");
                Console.WriteLine("monster's attack:{0},Altman's blood volume:{1}",atc_mon,Ultraman_hp);
                if (Ultraman_hp<=0)
                {
                    Console.WriteLine("Monster win");
                    break;
                }


            }
        }
    }
}
