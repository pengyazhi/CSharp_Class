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
    public partial class Frm_M15_CTS : Form
    {
        public Frm_M15_CTS()
        {
            InitializeComponent();
        }

        private void btnValueType_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = a;
            MessageBox.Show("a : "+a+" ,b : "+b);
            a = 200;
            MessageBox.Show("a : " + a + " ,b : " + b);
        }

        private void btnReferenceType_Click(object sender, EventArgs e)
        {
            Label lb = labReferenceType;
            lb.Text = "更新後的標籤";
            lb.Location = new Point(200, 200);
            lb.BackColor = Color.Teal;
            lb.ForeColor = Color.Pink;
        }
    }
}
