using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.对象的属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student stu1 = new Student();
            //stu1.age = -18;//这个年龄我们使用的是字段，可以看出-18对编译来说是没有问题的但是我们日常生活中能见到-18的人吗？所以再次我们引入了属性的概念
            //Console.WriteLine($"这个学生的年龄是{stu1.age}");


            Student stu2 = new Student();
            stu2.SetAge(122);
            Console.WriteLine(stu2.GetAge());
        }
    }
}
