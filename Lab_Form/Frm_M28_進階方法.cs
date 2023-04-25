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
    public partial class Frm_M28_進階方法 : Form
    {
        public Frm_M28_進階方法()
        {
            InitializeComponent();
        }

        private void btnOverLoadSwap_Click(object sender, EventArgs e)
        {
            int A = 100, B = 200;
            MessageBox.Show($"A:{A},B:{B}");
            Swap(ref A, ref B);
            MessageBox.Show($"A:{A},B:{B}");

            string  C = "ABC", D = "DEF";
            MessageBox.Show($"C:{C},D:{D}");
            Swap(ref C,ref D);
            MessageBox.Show($"C:{C},D:{D}");

        }
        void Swap(ref int a , ref int b)
        {
            int T = a;
            a = b;
            b = T;
        }
        void Swap(ref string a, ref string b)
        {
            string T = a;
            a = b;
            b = T;
        }

        private void btnGeneric_Click(object sender, EventArgs e)
        {
            int a = 10, b = 20;
            MessageBox.Show($"a:{a},b:{b}");
            GenericSwap<int>(ref a, ref b);
            MessageBox.Show($"a:{a},b:{b}");

        }
        void GenericSwap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
        }
        void GenericSwap<T,Y>(T strA,  T strB, Y yy,out Y yyy)
        {
            T strT = strA;
            strA = strB;
            strB = strT;

            Y n = yy;
            yyy = n;
        }
    }
}
