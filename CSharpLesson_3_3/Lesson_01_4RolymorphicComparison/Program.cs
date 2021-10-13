using System;
/// <summary>
/// 多态对比:怪兽群殴奥特曼
/// 普通方法，是数据类型 Person person 决定调用什么类中的方法
/// 虚方法，是内核 new Student("Student", 25, "IT") 决定调用什么方法。
/// 重写虚方法：声明什么类对象，调用的是什么类中的方法。
/// 覆盖方法：什么类对象，调用什么类中的方法。
/// </summary>
namespace Lesson_01_4RolymorphicComparison
{

    class Monster
    {
        public string name;
        public int hp;
        public int atk;

        public Monster(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
        }

        public virtual void Attack(Altman altman)
        {
            altman.hp -= atk;
            Console.WriteLine("怪兽{0}攻击奥特曼，奥特曼血量{1}", name, altman.hp);
        }

        /// <summary>
        /// 怪兽受伤方法
        /// </summary>
        public virtual void Damage(int dam)
        {
            hp -= dam;
            Console.WriteLine("怪兽{0}受伤了,血量:{1}", name, hp);
        }

    }


    class Boss : Monster
    {
        private int def;
        private float rate;
        /// <summary>
        /// 效率会高一点，不用每次都声明一个新的空间（每次都声明的话，有可能造成内存垃圾），
        /// 但会一直在内存空间中。
        /// </summary>
        private Random random;
        public Boss(string name, int hp, int atk, int def, float rate) : base(name, hp, atk)
        {
            this.def = def;
            this.rate = rate;
            random = new Random();
        }

        public override void Attack(Altman altman)
        {
            // random.Next(0, 101)包前不包后 所以范围是1-100
            int num = random.Next(0, 101);
            if (num < rate * 100)
            {// 暴击Crit
                altman.hp -= (int)(atk * 1.3f);
                Console.WriteLine("Boss暴击奥特曼，{0}血量：{1}", altman.name, altman.hp);
            }
            else
            {
                base.Attack(altman);
            }
        }

        public override void Damage(int dam)
        {
            if (dam > def)
            {
                hp -= (dam - def);
                Console.WriteLine("怪兽{0}受伤了，当前血量{1}", name, hp);
            }
            else
            {
                Console.WriteLine(name + "怪兽扛住了伤害");
            }
            //base.Damage();
        }

    }

    class Altman
    {
        public string name;
        public int hp;
        public int atk;

        public Altman(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
        }

        public void Attack(Monster monster)
        {
            monster.Damage(atk);
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Monster[] monsters = new Monster[3];


            for (int x = 0; x < monsters.Length; x++)
            {
                int num = random.Next(0, 2);
                if (num == 0)
                {
                    monsters[x] = new Monster("哥布林" + x, 100, 3);
                    Console.WriteLine("哥布林" + x);
                }
                else
                {
                    monsters[x] = new Boss("哥斯拉" + x, 100, 5, 1, 1.3f);
                    Console.WriteLine("哥斯拉" + x);
                }
            }

            Altman altman = new Altman("奥特曼", 300, 10);

            while (true)
            {
                Console.WriteLine("开始奥特曼回合");
                Console.ReadLine();

                Monster target = null;
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i].hp > 0)
                    {
                        target = monsters[i];
                        break;
                    }
                }



                if (target == null)
                {
                    Console.WriteLine("{0} Win", altman.name);
                    break;
                }

                // 开始大战
                altman.Attack(target);

                // 判断
                bool altmanWin = true;
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i].hp > 0)
                    {
                        altmanWin = false;
                    }
                }


                if (altmanWin)
                {
                    Console.WriteLine("{0} Win", altman.name);
                    break;
                }


                Console.WriteLine("怪兽回合");
                Console.ReadLine();
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i].hp > 0)
                    {
                        monsters[i].Attack(altman);
                    }
                }

                if (altman.hp < 0)
                {
                    Console.WriteLine("怪兽赢了");
                    break;
                }
            }
        }
    }
}
