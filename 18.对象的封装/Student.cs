using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.对象的封装
{
    internal class Student
    {
        /// <summary>
        /// 学号
        /// </summary>
        public int StudentID { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        public int StudentAge { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string StudentGender { get; set; }

        /// <summary>
        /// Print Log
        /// </summary>
        public void Intro()
        {
            Console.WriteLine($"学生信息为:{StudentID}+{StudentAge}+{StudentName}+{StudentGender}");
        }
    }
}
