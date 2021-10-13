﻿using System;

/// <summary>
/// 虚方法和抽象方法对比
/// 1.如果父类中的方法有默认的实现，并且父类需要被实例化，
///     时可以考虑将父类定义成一个普通类，用虚方法来实现多态。
/// 2.如果父类中的方法没有默认实现，父类也不需要被实例化，则可以将该类定义为抽象类。
/// 查找敌人：默认按距离进行查找、按攻击力进行查找、按血量进行查找
/// 攻击敌人：默认没有攻击方法、塔1发射炮弹1、塔2不用发射炮弹、塔3发射炮弹3   
/// </summary>
namespace Lesson_02_4VirtualAndAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
