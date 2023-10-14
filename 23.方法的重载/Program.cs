using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.方法的重载
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            SayHi("element");
            SayHi("element", 21);
            //可以看到  调用的都是同一个函数名，但是缺能够根据形参的类型，传入相对应的数据进行处理
        }


        #region 重载的方法,因为使用的控制台作为Demo  所以方法为静态类型，所以需要使用 static 关键词
        /// <summary>
        /// 无参方法
        /// </summary>
        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }

        /// <summary>
        /// 带参数方法
        /// </summary>
        /// <param name="name">姓名</param>
        static void SayHi(string name)
        {
            Console.WriteLine("Hi!" + name);
        }

        /// <summary>
        /// 带参数方法
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hi!" + name + age);
        }
        #endregion

    }
}
