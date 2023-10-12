using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21.访问类的四大成员
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();//先创建对象，然后才能访问类中的成员
            student.StudentId = 1;

            student.StudentName = "Test";

            student.SayHi();
        }
    }
}
