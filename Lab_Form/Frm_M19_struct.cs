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
    public partial class Frm_M19_struct : Form
    {
        public Frm_M19_struct()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //結構裡面有屬性或方法
            
            string txtAge = txtEmployeeAge.Text;
            int num;
            bool isNum = int.TryParse(txtAge, out num);
            if(isNum)
            {
                Empolyee emp = new Empolyee(txtEmployeeName.Text, int.Parse(txtEmployeeAge.Text));
                labEmpolyeeList.Text += $"\n員工姓名：{emp.Name} , 員工年齡：{num}";
            }
            else
            {
                MessageBox.Show("轉型失敗");
                txtEmployeeAge.Clear();
                txtEmployeeAge.Focus();


            }
            //emp.Name = txtEmployeeName.Text;
            //emp.Age = int.Parse(txtEmployeeAge.Text);



            //Empolyee emp ;
            //emp.Name = txtEmployeeName.Text;
            //emp.Age = int.Parse(txtEmployeeAge.Text);
            //labEmpolyeeList.Text += $"\n員工姓名：{emp.Name} , 員工年齡：{emp.Age}";

            //void NumOfEmpolyee(string[] args)//將員工人數相加及算出平均年齡
            //{
            //    string totalEmp = EmpParams("員工總數：", emp.Name);
            //}


        }
    }
}
