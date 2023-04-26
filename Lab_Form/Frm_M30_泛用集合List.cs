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
    public partial class Frm_M30_泛用集合List : Form
    {
        public Frm_M30_泛用集合List()
        {
            InitializeComponent();
        }

        //在建立泛用型別時就已經設定存放的"資料型態",可以避免之後使用者輸入非資料型態的值導致錯誤
        List<Product> lsPro = new List<Product>(); //List的資料型態為Product
        public void Dispaly()
        {
            rTxtBoxProductList.Text = string.Format("{0,10:w}{1,10:n}", "產品名稱", "產品價格") + "\n";
            decimal totalPrice = 0;
            //for (int i = 0; i < lsPro.Count; i++)
            //{
            //    rTxtBoxProductList.Text += string.Format("{0,10:w}{1,10:n}", lsPro[i].Name, lsPro[i].Price) + "\n";
            //    totalPrice += lsPro[i].Price;
            //}
            //if (lsPro.Count > 0) {
            //    decimal avePrice = totalPrice / lsPro.Count;
            //    rTxtBoxProductList.Text +=
            //$"\n----------------\n數量:{lsPro.Count}\n單價加總:{totalPrice:c0}\n平均單價:{avePrice:c2}";
            //}
            //else
            //{
            //    rTxtBoxProductList.Text +=
            //$"\n----------------\n數量:{lsPro.Count}\n單價加總:{totalPrice:c0}\n平均單價:{totalPrice:c2}";
            //}
            foreach (Product pro in lsPro)
            {
                rTxtBoxProductList.Text += string.Format("{0,10:w}{1,10:n}", pro.Name, pro.Price) + "\n";
                totalPrice += pro.Price;
            }
        }
        //public void CheckNum()
        //{
        //    decimal num;
            
        //    bool isNum = decimal.TryParse(txtProductPrice.Text, out num);
        //    if (isNum)
        //    {
        //        num;
        //    }
        //    else
        //    {
        //        MessageBox.Show("請輸入數字");
        //    }
        //}
        private void btnAddProductList_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Name = txtProductName.Text;

            decimal num;
            bool isNum = decimal.TryParse(txtProductPrice.Text, out num);
            if (isNum)
            {
                pro.Price = num;
                lsPro.Add(pro); //這個pro就包含上面的pro.Name及pro.Price
                Dispaly();
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Product pro = new Product();
            pro.Name = txtProductName.Text;
            decimal num;
            bool isNum = decimal.TryParse(txtProductPrice.Text, out num);
            if (isNum)
            {
                pro.Price = num;
                lsPro.Insert(0, pro);
                Dispaly();
            }
            else
            {
                MessageBox.Show("請輸入數字");
            }

        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            lsPro.RemoveAt(0);
            Dispaly();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lsPro.Clear();
            Dispaly();
        }

        private void btnAddDifferentType_Click(object sender, EventArgs e)
        {
            
        }
    }
}
