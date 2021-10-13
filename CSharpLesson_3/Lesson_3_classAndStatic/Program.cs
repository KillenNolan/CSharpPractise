using System;

/// <summary>
/// 单例设计:只能有一个对象
/// 只有一个包
/// </summary>
namespace Lesson_3_classAndStatic
{

    /// <summary>
    /// 1、想要Bag只有一个对象
    /// 2、构造函数私有化
    /// 3、因为构造函数私有，只能内部创建对象
    /// 4、因为 Instance 是非静态的，需要通过对象访问    ---做不到的
    /// 5、需要不通过对象就能访问 Instance，那就避免上述问题   ---使用static
    /// </summary>
    class Bag
    {
        /// <summary>
        /// 想要Bag只有一个对象 
        /// </summary>
        private static Bag instance;
        public static Bag Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Bag();
                }
                return instance;
            }
        }

        /// <summary>
        /// 构造函数私有化
        /// </summary>
        private Bag() { }


        /// 当前装备的个数
        int count = 0;
        Equip[] equips = new Equip[4];


        /// <summary>
        /// 添加新装备
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool AddEquip(Equip e)
        {
            if (count < equips.Length)
            {
                equips[count] = e;
                count++;
                return true;
            }
            return false;
        }

        public void Show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("name:{0},price:{1}", equips[i].name, equips[i].price);
            }

        }



    }


    class AltMan
    {

        public string name;
        public int hp;
        public int atk;
        public int money;


        public AltMan(string name, int hp, int atk, int money)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.money = money;
        }

        public void AddEquip(Equip e)
        {
            if (money > e.price)
            {
                if (e.type == AddType.AddHp)
                {
                    money -= e.price;
                    hp += e.point;
                }
                if (Bag.Instance.AddEquip(e))
                {
                    money -= e.price;
                    Console.WriteLine("挂载成功，还有{0}", money);
                }
            }
            else
            {
                Console.WriteLine("钱不够");
            }
        }


    }

    enum AddType
    {
        AddAtck = 0,
        AddDef = 1,
        AddHp = 2
    }

    class Equip
    {
        public string name;
        public AddType type;
        public int point;
        public int price;

        public Equip(string name, AddType type, int point, int price)
        {
            this.name = name;
            this.type = type;
            this.point = point;
            this.price = price;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            AltMan altMan = new AltMan("KK", 100, 10, 100);
            while (true)
            {
                Console.WriteLine("是否购买装备 y , n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    Console.WriteLine("1.方天画戟，增加攻击力5，价格20；2.魔女斗篷，增加防御力5，价格20；3.大力丸，增加血量20，价格30");
                    input = Console.ReadLine();
                    Equip e = null;
                    if (input == "1")
                    {
                        e = new Equip("方天画戟", AddType.AddAtck, 5, 20);
                    }
                    else if (input == "2")
                    {
                        e = new Equip("魔女斗篷", AddType.AddDef, 5, 20);
                    }
                    else if (input == "3")
                    {
                        e = new Equip("大力丸", AddType.AddHp, 20, 30);
                    }

                    altMan.AddEquip(e);
                }
                Bag.Instance.Show();
            }
        }
    }
}
