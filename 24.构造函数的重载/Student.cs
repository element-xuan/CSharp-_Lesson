using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.构造函数的重载
{
    internal class Student
    {
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public Student()
        {
        }

        /// <summary>
        /// 有参构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Student(string name, int age)
        {
            this.StudentName = name;
            this.StudentAge = age;
        }

        public int StudentName { get; set; }
        public int StudentAge { get; set; }
    }
}
