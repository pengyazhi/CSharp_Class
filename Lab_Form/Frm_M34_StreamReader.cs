using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M34_StreamReader : Form
    {
        public Frm_M34_StreamReader()
        {
            InitializeComponent();
        }

        private void btnStreamReader_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(
            //    "C:\\Users\\User\\source\\repos\\Lab_Csharp\\Lab_Console\\bin\\Debug\\Read.txt", Encoding.UTF8);
            StreamReader sr = new StreamReader(
            "../123/Read.txt", Encoding.UTF8);
            txtReadWrite.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"..\..\Write2.txt",FileMode.Create); //先新增檔案
            StreamWriter sw = new StreamWriter(fs,Encoding.Default);
            sw.Write(txtReadWrite.Text);
            sw.Close(); ////後開的先關
            fs.Close(); //先開的後關
        }

        private void btnBreakMode_Click(object sender, EventArgs e)
        {
            
            string result = "";
            for (int i = 0; i < 10; i++)
            {
                result += $"{i}\n";
               
            }
            messageMethod(result);
        }
        void messageMethod(string result)
        {
            MessageBox.Show(result);
        }
    }
}
