using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19.构造函数
{
    public partial class Form1 : Form//Form1继承自Form类
    {
        public Form1()//构造函数或者构造方法
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();//new Student()   这里就是调用他的构造函数
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student student = new Student("element",18);
        }
    }
}
