using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03注释的学习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //注释不参与程序的编译，因为没有参与编译，更不会参与运行
            //在日常的程序编写中，我们可以留下大量的注释用来帮助自己或者他人，了解项目或代码的意义，在后续的版本中我也会留下大量注释，请切记 适当的注释是 非常必要的

            //单行注释

            /*
             * 多
             * 行
             * 注
             * 释
            */
        }
        //下面是一个块注释

        /// <summary>
        /// 这是个测试函数，没有其他意义
        /// </summary>
        public void test()
        {

        }
    }
}
