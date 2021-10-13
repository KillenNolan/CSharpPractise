using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLesson_3_2
{

    /// <summary>
    /// 当class的修饰符是public时，外界才能访问；
    /// 一般新建class时，默认为private
    /// </summary>
    public class Test
    {
        public void ShowTest()
        {
            Console.WriteLine("I'm method ShowTest of Test class.");
        }
    }
}
