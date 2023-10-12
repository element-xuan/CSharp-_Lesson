using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18.对象的封装
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student stu = new Student();

                stu.StudentID = Convert.ToInt32(this.textBox1.Text);
                stu.StudentName = this.textBox2.Text;
                stu.StudentGender = this.comboBox1.Text;
                stu.StudentAge = Convert.ToInt32(this.textBox3.Text);

                MessageBox.Show($"学生信息为:学号{stu.StudentID}，姓名{stu.StudentName}，性别{stu.StudentGender}，年龄{stu.StudentAge}", caption: "信息确认", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new Exception("Error", ex);
            }

        }
    }
}
