using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_Form
{
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }

        private void btnPassbyValueType_Click(object sender, EventArgs e)
        {
            int A = 30;
            PassbyValueType(A);
            MessageBox.Show(A.ToString());
        }
        void PassbyValueType(int Age) //傳"值"法
        {
            Age = 28;
        }

        private void btnPassByReferenceType_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "王曉明";
            mem1.Age = 16;
            MessageBox.Show($"Name : {mem1.Name} , Age : {mem1.Age}");
            PassByReferenceType(mem1);
            MessageBox.Show($"Name : {mem1.Name} , Age : {mem1.Age}");
        }
        void PassByReferenceType(Member member)//傳"址"法
        {
            member.Age = 18;
        }

        private void btnByRef_Click(object sender, EventArgs e)
        {
            int a = 26;
            PassByRef(ref a);//帶入的參數前面要加上ref
            MessageBox.Show(a.ToString());
        }
        void PassByRef(ref int Age) //強制將參數視為參考型別(傳址法)
        {
            Age = 18;
        }

        private void btnPassByOut_Click(object sender, EventArgs e)
        {
            int b = 17;
            char g = 'E';
            PassByOut(out b,out g);
            MessageBox.Show(b.ToString() + g);
        }
        void PassByOut(out int Age,out char Sex)
        {
            Age = 36;
            Sex = 'F';
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            string totalChi = TotalParams("國文", 90, 80, 70, 60);
            MessageBox.Show(totalChi.ToString());
            string totalMath = TotalParams("數學", 40, 50, 60);
            MessageBox.Show(totalMath.ToString());
            string totalEng = TotalParams("英文");
            MessageBox.Show(totalEng.ToString());
        }
        string TotalParams(string Subject, params int[] score)
        {
            int total = 0;
            for(int i = 0; i < score.Length; i++)
            {
                total += score[i];
            }
            return total.ToString();
        }
    }
}
