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
    public partial class Frm_M08 : Form
    {
        public Frm_M08()
        {
            InitializeComponent();
        }

        private void btnRegisterEvent_Click(object sender, EventArgs e)
        {
            //參考 this.btnRegisterEvent.Click += new System.EventHandler(this.btnRegisterEvent_Click);
            this.btnRegisterEvent01.Click += new EventHandler(btnRegister01Click);
            this.btnRegisterEvent02.Click += BtnRegisterEvent02Click;
        }
        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            //this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            this.btnRegisterEvent01.Click -= new EventHandler(btnRegister01Click);
        }

        private void BtnRegisterEvent02Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register02 Click");
        }

        private void btnRegister01Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register01 Click");
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            DialogResult qResult;
             qResult =  MessageBox.Show("要下單嗎?", "你是韭菜",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (qResult == DialogResult.Yes)
            {
                DialogResult aResult;
                aResult = MessageBox.Show("你確定嗎?");
            }
            else if (qResult == DialogResult.No) {
                MessageBox.Show("台北凱基群組的老師推薦的不買嗎?");
            }
            else
            {
                MessageBox.Show("台股年底萬八!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.ShowDialog();
        }
        delegate decimal Payment(decimal money);
        decimal Discount50off(decimal money)
        {
            return money * 0.5m;
        }
        decimal Discount20off(decimal money)
        {
            return money * 0.8m;
        }
        decimal NotDiscountoff(decimal money)
        {
            return money * 1m;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Payment pay;
            if(txtAmount.Text == null || txtAmount.Text == "")
            {
                txtAmount.BackColor = Color.FromArgb(255, 192, 192);
                MessageBox.Show("請輸入金額");
            }
            else
            {
                txtAmount.BackColor = Color.White;
                if (cmbDiscount.Text == "50% off")
                {
                    pay = Discount50off;
                }
                else if (cmbDiscount.Text == "20% off")
                {
                    pay = Discount20off;
                }
                else
                {
                    pay = NotDiscountoff;
                }
                decimal finalCost = pay(Convert.ToDecimal(txtAmount.Text));

                MessageBox.Show($"折扣後的金額為{finalCost}");
            }   
        }
    }
}
