using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.构造函数
{
    internal class Student
    {
        /// <summary>
        /// 无参 构造函数
        /// </summary>
        public Student()
        {
            MessageBox.Show("Student类的构造方法","无参构造函数");
        }

        /// <summary>
        /// 有参  构造函数
        /// </summary>
        public Student(string name, int age)
        {
            StudentName = name;
            StudentAge = age;


            MessageBox.Show($"StudentName：{StudentName} ，StudentAge：{StudentAge}", "有参构造函数");
        }

        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
}
