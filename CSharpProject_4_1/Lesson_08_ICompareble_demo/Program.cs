using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Lesson_06_Singleton;

/// <summary>
/// 书写一个怪物类，在怪物类的构造中将其添加到一个列表，
/// 后加入将怪物按从大到小的攻击排序。
/// 让用户输入对应逻辑给怪物列表排序，打印出来
/// 1.攻击优先    2.防御优先    3.血量优先  4.反转
/// </summary>
namespace Lesson_08_ICompareble_demo
{
    class MonsterManager : Sington<MonsterManager>
    {
        private List<Monster> list = new List<Monster>();

        public void Add(Monster m)
        {
            list.Add(m);
        }


        /// <summary>
        /// reverse不好写，所以用list自带的
        /// </summary>
        /// <param name="type"></param>
        public void Show(SortType type)
        {
            if (type == SortType.Reverse)
            {
                list.Reverse();
            }
            else
            {
                Monster.type = type;
                list.Sort();
            }
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }


    }

    enum SortType
    {
        atk = 0,
        def = 1,
        hp = 2,
        Reverse = 3,
    }

    class Monster : IComparable<Monster>
    {
        public string name;
        public int atk;
        public int hp;
        public int def;

        public Monster(string name, int atk, int hp, int def)
        {
            this.name = name;
            this.atk = atk;
            this.hp = hp;
            this.def = def;
            MonsterManager.Instance.Add(this);
        }

        public static SortType type;

        public int CompareTo([AllowNull] Monster other)
        {
            switch (type)
            {
                case SortType.atk:
                    if (other.atk > atk)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                case SortType.def:
                    if (other.def > def)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                case SortType.hp:
                    if (other.hp > hp)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                default: return 0;
            }

        }
        public override string ToString()
        {
            return string.Format("atk:{0},def:{1},hp:{2},name:{3}", atk, def, hp, name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Monster m1 = new Monster("M1", 66, 150, 52);
            Monster m2 = new Monster("M2", 77, 500, 99);
            Monster m3 = new Monster("M3", 87, 60, 9);
            //Monster.type = SortType.atk;
            //MonsterManager.Instance.Show();
            MonsterManager.Instance.Show(SortType.hp);
            MonsterManager.Instance.Show(SortType.Reverse);
        }
    }
}
