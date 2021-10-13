using System;

namespace Lesson_01_3HardWare
{
    interface IUSB
    {
        void TransferData();
    }


    class Disk : IUSB
    {
        public string name;
        public Disk(string name) { this.name = name; }
        public void TransferData()
        {
            Console.WriteLine("{0} 硬盘 is transfer data.", name);
        }
    }
    class UDisk : IUSB
    {
        public string name;
        public UDisk(string name) { this.name = name; }
        public void TransferData()
        {
            Console.WriteLine("{0} U盘 is transfer data.", name);
        }
    }
    class MP3 : IUSB
    {
        public string name;
        public MP3(string name) { this.name = name; }
        public void TransferData()
        {
            Console.WriteLine("{0} MP3 is transfer data.", name);
        }
    }



    class Computer
    {

        /// <summary>
        /// 电脑需要用单例来实现
        /// </summary>
        private static Computer instance;
        public static Computer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Computer();
                }
                return instance;

            }
        }


        private Computer() { }

        private IUSB[] usbs = new IUSB[4];
        private int count = 0;

        /// <summary>
        /// 添加一个设备
        /// </summary>
        /// <param name="usb"></param>
        public void AddUsb(IUSB usb)
        {
            if (count < usbs.Length)
            {
                usbs[count] = usb;
                count++;
            }
            else
            {
                //没有足够的位置，需要扩容
                Expand();
                AddUsb(usb);
            }
        }

        /// <summary>
        /// 将当前的usb接口扩容一倍
        /// </summary>
        private void Expand()
        {
            IUSB[] newUsbs = new IUSB[usbs.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newUsbs[i] = usbs[i];
            }
            usbs = newUsbs;
        }

        /// <summary>
        /// 删除一个设备
        /// </summary>
        /// <param name="usb"></param>
        public void RemoveUsb(IUSB usb)
        {
            for (int i = 0; i < count; i++)
            {
                if (usbs[i] == usb)
                {
                    ReSort(i);
                    count--;
                }
            }
        }


        /// <summary>
        /// 重新给设备排序
        /// </summary>
        /// <param name="index"></param>
        private void ReSort(int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                usbs[i] = usbs[i + 1];
            }
        }

        /// <summary>
        /// 插入一个设备
        /// </summary>
        public void InsertUsb(IUSB usb, int i)
        {
            //if (count < usbs.Length)
            //{
            //    //不需扩容

            //}
            //else
            //{
            //    //需扩容
            //    Expand();
            //}

            if (count >= usbs.Length)
            {
                Expand();
            }
            InsertToPos(usb, i);
        }

        private void InsertToPos(IUSB usb, int index)
        {
            for (int i  = count-1 ; i >= index; i--)
            {
                usbs[i + 1] = usbs[i];
            }
            usbs[index] = usb;count++;
        }



        public void ComputerTransferData()
        {
            for (int i = 0; i < count; i++)
            {
                usbs[i].TransferData();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IUSB aDisk = new Disk("aDisk");
            IUSB aMp3 = new MP3("aMp3");
            IUSB aUDisk = new UDisk("aUDisk");
            IUSB bDisk = new Disk("bDisk");
            IUSB bMp3 = new MP3("bMp3");


            Computer.Instance.AddUsb(aDisk);
            Computer.Instance.AddUsb(aMp3);
            Computer.Instance.AddUsb(aUDisk); 

            Computer.Instance.ComputerTransferData();

            Console.WriteLine("----------------------------");
            Computer.Instance.InsertUsb(bMp3, 1);
            Computer.Instance.InsertUsb(bDisk, 1);
            Computer.Instance.ComputerTransferData();

            Console.WriteLine("---------------------------- ");
            Computer.Instance.RemoveUsb(aMp3);
            Computer.Instance.ComputerTransferData();

        }
    }
}
