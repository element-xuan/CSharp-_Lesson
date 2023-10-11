using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.for循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //没有循环的时候，我们在屏幕上输出 10次 hollowworld
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            Console.WriteLine("Hi! Element");
            //我们粘贴复制10次即可，但是如果需要我们输出100次 1千次呢，还是一行行复制吗？
            //这时候我们就要使用到了循环，首先我们介绍 for循环

            #region for 循环
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hi! Element");
            }
            //只需要这3行即可 ，可以看的出来代码大大的减少了!
            #endregion


            //使用for循环累加1-36
            //定义一个变量 sum，存放累加的结果
            int sum = 0;
            for (int i = 0; i <= 36; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);//out:666


        }
    }
}
