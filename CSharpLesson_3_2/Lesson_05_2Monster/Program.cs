using System;

namespace Lesson_05_2Monster
{

    class Monster
    {
        public string name;
        public int hp;
        public int atk;



        public Monster() { }
        public Monster(string name, int hp, int atk)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
        }

        /// <summary>
        /// 普通攻击
        /// </summary>
        public void Attack()
        {
            Console.WriteLine("base atk:name:{0},hp:{1},atk:{2}", name, hp, atk);
        }
    }


    class Boss : Monster
    {
        /// <summary>
        /// 暴击率
        /// </summary>
        public float rate;
        public Boss(string name, int hp, int atk, float rate) : base(name, hp, atk)
        {
            this.rate = rate;
        }

        /// <summary>
        /// 重写父类的方法
        /// </summary>
        public new void Attack()
        {
            Console.WriteLine("Boss技能攻击:name:{0},hp:{1},atk:{2}", name, hp, atk);
        }

    }

    class Goblin : Monster
    {
        public Goblin(string name, int hp, int atk) : base(name, hp, atk)
        {

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();


            Monster[] monsters = new Monster[10];
            // 随机生成是个怪
            for (int i = 0; i < monsters.Length; i++)
            {
                int num = random.Next(0, 2);
                if (num == 0)
                {
                    monsters[i] = new Boss("boss", 100, 5, 0.6f);
                }
                else
                {
                    monsters[i] = new Goblin("goblin", 100, 3);
                }
            }



            // 生成攻击方法
            // 如果有一百个对象，怎么办？每一个都实例化吗？一个一个判断吗？这就需要多态来解决啦
            for (int i = 0; i < monsters.Length; i++)
            {
                if (monsters[i] is Boss)
                {
                    (monsters[i] as Boss).Attack();

                }
                else if (monsters[i] is Goblin)
                {
                    monsters[i].Attack();
                }

            }



        }
    }
}
