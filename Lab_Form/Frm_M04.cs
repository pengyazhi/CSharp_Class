using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M04 : Form
    {
        public Frm_M04()
        {
            InitializeComponent();
        }

        private void btnOpneHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm =   new Frm_M02_HelloForm();
            frm.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            MyFirstMethod();
        }
        void MyFirstMethod()
        {
            MessageBox.Show("This is my first method.");
        }

        private void btnReturnMethod_Click(object sender, EventArgs e)
        {
            string result = BirthYear(20);
            MessageBox.Show(result);
        }
        string BirthYear(int Age)
        {
            int bYear = DateTime.Now.Year - Age;
            return $"出生年為{bYear}年";
        }

        private void btnMyClass_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            //mc.Method01();
            //mc.Method02();
            mc.Method03();
            mc.Method04();
        }

        private void btnPackaged_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method05();
        }

        private void btnPartialClass_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();
            mc.Method06();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            //建立類別實體後再賦予值
            Member mem1 = new Member();
            mem1.Name = "John";
            mem1.Age = 25;
            MessageBox.Show($"姓名 : {mem1.Name},年齡 : {mem1.Age}");
            //建立類別實體同時賦予值
            Member mem2 = new Member()
            {
                Name = "Wick",
                Age = 40
            };
            MessageBox.Show($"姓名 : {mem2.Name},年齡 : {mem2.Age}");
        }
    }
}
