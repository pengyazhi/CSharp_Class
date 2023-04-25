using System;
using System.Collections;
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
    public partial class Frm_M29_ArryList : Form
    {
        public Frm_M29_ArryList()
        {
            InitializeComponent();
        }
        ArrayList lsPro = new ArrayList();
        //List<Product> lsPro = new List<Product>();
        Product pro;
        private void btnAddProductList_Click(object sender, EventArgs e)
        {
            pro.Name = txtProductName.Text;
            pro.Price = decimal.Parse(txtProductPrice.Text);
            lsPro.Add(pro);

            rTxtBoxProductList.Text = string.Format("{0,10:w}{1,10:n}", "產品名稱", "產品價格") + "\n";
            for (int i = 0; i < lsPro.Count; i++)
            {
                rTxtBoxProductList.Text += string.Format("{0,10:w}{1,10:n}", ((Product)lsPro[i]).Name, ((Product)lsPro[i]).Price) + "\n";
            }

            Dispaly();
        }
        public void Dispaly()
        {
            rTxtBoxProductList.Text = string.Format("{0,10:w}{1,10:n}", "產品名稱", "產品價格") + "\n";
            for (int i = 0; i < lsPro.Count; i++)
            {
                rTxtBoxProductList.Text += string.Format("{0,10:w}{1,10:n}", ((Product)lsPro[i]).Name, ((Product)lsPro[i]).Price) + "\n";
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            
            pro.Name = txtProductName.Text;
            pro.Price = decimal.Parse(txtProductPrice.Text);
            lsPro.Insert(1, pro);
            rTxtBoxProductList.Text = string.Format("{0,10:w}{1,10:n}", "產品名稱", "產品價格") + "\n";
            for (int i = 0; i < lsPro.Count; i++)
            {
                rTxtBoxProductList.Text += string.Format("{0,10:w}{1,10:n}", ((Product)lsPro[i]).Name, ((Product)lsPro[i]).Price) + "\n";
            }
            Dispaly();

        }
    }
}
