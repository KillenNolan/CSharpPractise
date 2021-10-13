using System;

namespace Lesson1_enum
{


    class Program
    {
        /// <summary>
        /// 枚举不能定义在函数里面，要在函数外面。
        /// 枚举第一个默认0，往后自动+1；可指定固定的数字
        /// 枚举默认跟int类型相互兼容，可以通过强制类型转换
        /// </summary>
        enum SexEnum
        {
            Man = 7,
            Woman
        }

        /// <summary>
        /// 枚举转化
        /// 1.枚举<==>int;
        /// 2.enum==>string :myEnum.ToString()
        /// 3.string==>enum:(enum)Enum.Parse(typeof(enum)),"string"
        /// </summary>

        enum QqStatus
        {
            Qme,
            OnLine,
            OffLine,
            Leave,
            Busy
        }

        static void Main(string[] args)
        {
            #region 枚举概念
            /*
            SexEnum sexEnum = SexEnum.Man;
            if (sexEnum == SexEnum.Man)
            {

            }
            string test = "Man";
            if (test == "Man")
            {

            }

            // 枚举可自动带出case选项，It's amazing 
            switch (sexEnum)
            {
                case SexEnum.Man:
                    break;
                case SexEnum.Woman:
                    break;
                default:
                    break;
            }
            */

            /*
            SexEnum sex = SexEnum.Man;
            Console.WriteLine((int)sex);*/

            #endregion

            QqStatus status = QqStatus.Leave;
            // 字符串转换成枚举
            status = (QqStatus)Enum.Parse(typeof(QqStatus), "Busy");
            Console.WriteLine(status);
            /*// QQ的一些状态
            Console.WriteLine("Please chose status:0.talk, 1.Online, 2.Offline, 3.Leave, 4.Busy");
            string input = Console.ReadLine();
            int num;
            if (int.TryParse(input, out num))
            {
                if (num >= 0 && num <= 4)
                {
                    QqStatus status = (QqStatus)num;
                    //Console.WriteLine(status);
                    switch (status)
                    {
                        case QqStatus.Qme:
                            Console.WriteLine("Qme");
                            break;
                        case QqStatus.OnLine:
                            Console.WriteLine("Online");
                            break;
                        case QqStatus.OffLine:
                            Console.WriteLine("Offline");
                            break;
                        case QqStatus.Leave:
                            Console.WriteLine("Leave");
                            break;
                        case QqStatus.Busy:
                            Console.WriteLine("Busy");
                            break;
                        default:
                            break;
                    }
                }
            }*/


        }
    }
}
