using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Lesson_06_GenericClass;
/// <summary>
/// 单例背包
/// 一个装备类，有攻击力或者防御力，有数量
/// 一个单例背包类，可以挂装备，计算攻击力和防御力
/// 装备存进背包，得出攻击力和防御力
/// </summary>
namespace Lesson_07_List_2Demo1
{
    enum EquipType
    {
        AddAtk = 0,
        AddDf = 1
    }

    class Equipment
    {
        public int id;
        public string name;
        public EquipType type;
        public int point;
        public int count;
        public List<int> epAtr;
        public Hashtable ep;

        public Equipment(int id, string name, EquipType type, int point, int count)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.point = point;
            this.count = count;
        }

        public void AddEq()
        {
            ep[name] = ep;

        }

        public override string ToString()
        {
            return string.Format("id:{0},name:{1},count:{2}", id, name, count);
        }

    }

    class PackageManger : Sington<PackageManger>
    {
        List<Equipment> equipList = new List<Equipment>();


        bool isHave = false;
        public void AddEquip(Equipment ep)
        {
            for (int i = 0; i < equipList.Count; i++)
            {
                if (equipList[i].id == ep.id)
                {
                    // 已有当前id的装备，直接修改已有装备的数量
                    equipList[i].count += equipList[i].count;
                    isHave = true;
                    break;
                }
            }


            if (!isHave)
            {
                equipList.Add(ep);
            }
            //if (equipList.Contains(ep ))
            //{            
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //    equipList.Add(ep);
            //}

        }


        /// <summary>
        /// 删除装备
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public bool DelEquip(int id, int count)
        {
            for (int i = 0; i < equipList.Count; i++)
            {
                if (equipList[i].id == id)
                {
                    // 装备是有的，检查数量够不够
                    if (equipList[i].count >= count)
                    {
                        // 说明数量够
                        equipList[i].count -= count;
                        return true;
                    }
                    // 此时返回会效率高一点
                    return false;
                }
            }
            return false;
        }


        /// <summary>
        /// 计算点数的攻击力
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public int GetPoint(EquipType type)
        {
            int point = 0;
            for (int i = 0; i < equipList.Count; i++)
            {
                if (equipList[i].type == type)
                {
                    point += equipList[i].point * equipList[i].count;
                }
            }
            return point;
        }

        public void ShowEquips()
        {
            for (int i = 0; i < equipList.Count; i++)
            {
                Console.WriteLine(equipList[i]);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Equipment ep3 = new Equipment(1, "ep", EquipType.AddAtk, 5, 1);
            PackageManger.Instance.AddEquip(ep3);//no

            Equipment ep = new Equipment(1, "ep1", EquipType.AddAtk, 5, 1);
            PackageManger.Instance.AddEquip(ep);//no 
            //PackageManger.Instance.AddEquip(ep);//思考一下引用类型深度拷贝
            //传的是引用地址，它们的信息虽然一样，但内存地址不一样，所以同样的设备，还是检测不到

            PackageManger.Instance.ShowEquips();//no

            if (PackageManger.Instance.DelEquip(1, 8))
            {
                PackageManger.Instance.ShowEquips();
            }
            else
            {
                PackageManger.Instance.ShowEquips();
            }

            Console.WriteLine(PackageManger.Instance.GetPoint(EquipType.AddAtk));
        }
    }
}
