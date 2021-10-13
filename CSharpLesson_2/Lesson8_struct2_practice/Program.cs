using System;

namespace Lesson8_struct2_practice
{
    class Program
    {

        struct Altman
        {
            public string name;
            public int posX, posY;
            public string icon;
            public int hp, atk;

            public Altman(string name, int x, int y, int hp, int atk, string icon)
            {
                this.name = name;
                this.posX = x;
                this.posY = y;
                this.hp = hp;
                this.atk = atk;
                this.icon = icon;
            }

            /// <summary>
            /// 画出奥特曼
            /// </summary>
            public void DrawIcon()
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write(icon);
            }

            /// <summary>
            /// 清除奥特曼
            /// </summary>
            public void CleanIcon()
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write(" ");

            }

            /// <summary>
            /// 奥特曼的移动
            /// </summary>
            public void Move(int x, int y)
            {
                CleanIcon();
                posX += x;
                if (posX >= 88)
                {
                    posX = 88;
                }
                else if (posX <= 1)
                {
                    posX = 1;
                }

                posY += y;

                if (posY >= 12)
                    posY = 12;
                else if (posY <= 1)
                    posY = 1;

                DrawIcon();
            }

            /// <summary>
            /// 奥特曼的攻击方法
            /// </summary>
            /// <param name="monster"></param>
            public void Attack(ref Monster monster)
            {
                monster.hp -= atk;
                if (monster.hp <= 0)
                {
                    monster.hp = 0;
                }

            }
        }


        struct Monster
        {
            public string name;
            public int posX, posY;
            public string icon;
            public int hp, atk;

            public Monster(string name, int x, int y, int hp, int atk, string icon)
            {
                this.name = name;
                this.posX = x;
                this.posY = y;
                this.icon = icon;
                this.hp = hp;
                this.atk = atk;
            }

            public void DrawIcon()
            {
                Console.SetCursorPosition(posY, posY);
                Console.Write(icon);
            }

            public void CleanIcon()
            {
                Console.SetCursorPosition(posX, posY);
                Console.Write(" ");

            }

            public void Move()
            {

            }

            /// <summary>
            /// 怪兽的攻击方法
            /// </summary>
            /// <param name="altman"></param>
            public void Attack(ref Altman altman)
            {
                altman.hp -= atk;
                if (altman.hp <= 0)
                {
                    altman.hp = 0;
                }

            }
        }


        static void Main(string[] args)
        {
            // 1.整个游戏的地图--函数
            ShowMap();

            // 2.奥特曼在场景中移动
            Altman altman = new Altman("DijiaAltman", 9, 5, 100, 5, "A");
            altman.DrawIcon();

            // 3. 怪的生成
            Monster monster = new Monster("Monster", 9, 10, 100, 2, "M");

            while (true)
            {
                // 每次奥特曼移动的时候，都要生成一次怪
                monster.DrawIcon();
                char input = Console.ReadKey(true).KeyChar;
                switch (input)
                {
                    case 'a':
                    case 'A':
                        altman.Move(-1, 0);
                        break;
                    case 'd':
                    case 'D':
                        altman.Move(1, 0);
                        break;
                    case 'w':
                    case 'W':
                        altman.Move(0, -1);
                        break;
                    case 's':
                    case 'S':
                        altman.Move(0, 1);
                        break;
                    default:
                        break;
                }

                Console.SetCursorPosition(100, 0);
                Console.Write("Altman X:{0},Y:{1}; Monster X:{2},y:{3} test", altman.posX, altman.posY, monster.posX, monster.posY);


                // 奥特曼移动完毕，对比奥特曼和怪的位置，判定是否相遇。
                if (((altman.posX - monster.posX == 1
                    || altman.posX - monster.posX == -1))
                    && altman.posY == monster.posY
                    || ((altman.posY - monster.posY == 1
                    || altman.posY - monster.posY == -1)
                    && altman.posX == monster.posX))
                {
                    Console.SetCursorPosition(100, 0);
                    Console.Write("Altman X:{0},Y:{1}; Monster X:{2},y:{3} Meet", altman.posX, altman.posY, monster.posX, monster.posY);
                    ////开始战斗
                    //Fight(ref altman, ref monster);
                }
                else
                {
                    Console.SetCursorPosition(100, 0);
                    Console.Write(" ");
                }

            }
        }


        static void Fight(ref Altman altman, ref Monster monster)
        {
            while (true)
            {
                Console.SetCursorPosition(90, 0);
                Console.WriteLine("Any keypress start fight");
                Console.ReadKey(true);
                altman.Attack(ref monster);
                if (monster.hp == 0)
                {
                    monster.posX = 0;
                    monster.posY = 0;
                    monster.CleanIcon();
                    return;
                }
            }

        }

        /// <summary>
        /// 打印地图
        /// </summary>
        static void ShowMap()
        {

            Console.WriteLine("------------------------------------------------------------------------------------------");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|                                                                                        |");
            Console.WriteLine("|----------------------------------------------------------------------------------------|");
            Console.WriteLine("|                         |                                |                             |");
            Console.WriteLine("|                         |                                |                             |");
            Console.WriteLine("|                         |                                |                             |");
            Console.WriteLine("|                         |                                |                             |");
            Console.WriteLine("|                         |                                |                             |");
            Console.WriteLine("|                         |                                |                             |");
            Console.WriteLine("|                         |                                |                             |");
            Console.WriteLine("------------------------------------------------------------------------------------------");



        }

    }
}
