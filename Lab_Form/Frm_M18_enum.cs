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
    public partial class Frm_M18_enum : Form
    {
        public Frm_M18_enum()
        {
            InitializeComponent();
        }

        private void btnProduct_Click(object sender, EventArgs e)//todo Test 將權限使用設計為登入時就判別是User/Admin
        {
            MessageBox.Show("你好管理員");
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            UserRole role = UserRole.Student;
            switch (role)
            {
                case UserRole.Admin:
                    btnProduct.Enabled = true;
                    break;
                case UserRole.User:
                    btnProduct.Enabled = false; 
                    break;
            }
            //if(role == UserRole.Admin)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //    MessageBox.Show("此權限開放給管理員使用");
            //}
        }
    }
}
