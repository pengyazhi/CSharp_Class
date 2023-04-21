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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }

        int num = 0;
        private void btnAccumulate_Click(object sender, EventArgs e)
        {
            num += 1;
            labCount.Text = "Count : " + num;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            num -= 1;
            labCount.Text = "Count : " + num;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            num *= 2;
            labCount.Text = "Count : " + num;
        }

        private void btnRemainder_Click(object sender, EventArgs e)
        {
            num %= 2;
            labCount.Text = "Count : " + num;
        }

        //前置遞增/減
        private void btnPlus_Click(object sender, EventArgs e)
        {
            
            int result = ++num;
            //num +=1;
            //result = num;
            MessageBox.Show("++num : " + num + " ,num = result : "+result);
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            
            int result = --num;
            //num -=1;
            //result = num;
            MessageBox.Show("--num : "+num + " ,num = result : "+result );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = num++;
            //result = num; 
            //num++;
            MessageBox.Show(" result = num : " + result + " ,num++ : " + num);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int result = num--;
            //result = num; 
            //num--;
            MessageBox.Show(" result = num : " + result+" ,num-- : " + num );
        }
        
        private void btnLocalVar_Click(object sender, EventArgs e)
        {
            
            int a = 100;
            if (true) 
            {
                int x = 200;
                x += a;
                MessageBox.Show($"if判斷式中的x = "+x);
                MessageBox.Show($"類別中的b = " + b);
            }
            MessageBox.Show($"方法中的a = " + a);
        }
        int b = 500;
        private void btnClassVar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"類別中的b = " + b);
        }
        StaticLab sl = new StaticLab();
        private void btnInsatnce_Click(object sender, EventArgs e)
        {
            sl.InsatnceNum += 1;
            labInstanceCount.Text = "Instance Count : " + sl.InsatnceNum;
        }

        private void btnStatic_Click(object sender, EventArgs e)
        {
            StaticLab.StaticNum += 1;
            labStaticCount.Text = "Static Count : " + StaticLab.StaticNum;
        }

        private void button02_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.Show();
        }
    }
}
