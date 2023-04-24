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
    public partial class Frm_M20 : Form
    {
        public Frm_M20()
        {
            InitializeComponent();
        }

        bool flag = true;
        private void btnReverse_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                btnReverse.BackColor = Color.Tomato;
            }
            else
            {
                btnReverse.BackColor = Color.Olive;
            }
            flag = !flag;
        }

        private void btnTenaryOperator_Click(object sender, EventArgs e)
        {
            btnTenaryOperator.BackColor = flag ? Color.RoyalBlue : Color.OrangeRed;
            flag = !flag;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            //90~100:A
            //80~89:B
            //70~79:C
            //60~69:D
            //~59:E
            string txtscore = txtScore.Text;
            int num;
            bool isNum = int.TryParse(txtscore, out num);
            if(isNum && int.Parse(txtscore)<=100)
            {
                if (num >= 90 && num <= 100)
                {
                    labGrade.Text = "A級";
                }
                else if (num >= 80 /*&& num <= 89*/)
                {
                    labGrade.Text = "B級";
                }
                else if (num >= 70 /*&& num <= 79*/)
                {
                    labGrade.Text = "C級";
                }
                else if (num >= 60 /*&& num <= 69*/)
                {
                    labGrade.Text = "D級";
                }
                else
                {
                    labGrade.Text = "E級";
                }

            }
            else
            {
                MessageBox.Show("請輸入0~100的正整數");
                txtScore.Clear();
                txtScore.Focus();
            }
        }
    }
}
