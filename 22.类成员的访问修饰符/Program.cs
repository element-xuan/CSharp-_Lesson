﻿using _22.类成员的访问修饰符;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.类成员的访问修饰符
{
    /*
    * 类成员表的访问修饰符
    * public：表示公有的，可以在外部被访问
    * private：表示私有的，只能在类的内部中被访问
    * 如果不写访问修饰符，那程序默认为private，只能在类内部被访问
    */
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class 公开的 { }
    private class 私有的 { }
}
