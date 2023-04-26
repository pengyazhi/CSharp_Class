using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M32 : Form
    {
        public Frm_M32()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //string dir = "C:\\Users\\User\\Desktop\\picture\\catBg.jpg";
            string dir = @"C:\Users\User\Desktop\picture\catBg.jpg";
            string result = Path.GetFileName(dir) +"\n"+ Path.GetExtension(dir)+"\n"+Path.GetDirectoryName(dir);
            MessageBox.Show(result);
        }

        private void btnString_Click(object sender, EventArgs e)//String介於一個參考型別跟實質型別
        {
            string A = "AAA";
            string B = A;
            MessageBox.Show($"A:{A},B:{B}");
            A = "aaa";
            MessageBox.Show($"A:{A},B:{B}");
        }

        private void btnStringBuilder_Click(object sender, EventArgs e) //StringBuilder一般參考型別
        {
            StringBuilder s1 = new StringBuilder();
            s1.Append("AAAA");
            StringBuilder s2 = s1;
            MessageBox.Show($"s1:{s1},s2:{s2}");
            s1.Append("LLLL");
            MessageBox.Show($"s1:{s1},s2:{s2}");
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
        }
        //bool IsStrongPassword(string password)
        //{
        //    bool result = Regex.IsMatch(password,@)
        //}
    }
}
