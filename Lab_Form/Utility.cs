using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_Form
{
    public partial class MyClass
    {
        void Method01()
        {
            MessageBox.Show("Method01");
        }
        private void Method02()
        {
            MessageBox.Show("Method02");
        }
        internal void Method03()
        {
            MessageBox.Show("Method03");
        }
        public void Method04()
        {
            MessageBox.Show("Method04");
        }
        internal void Method05()
        {
            Method01();
            Method02();
        }
    }
    public class Member
    {
        public string Name;
        public int Age;
    }
    public class StaticLab
    {
        public int InsatnceNum;
        public static int StaticNum;
    }
    public enum UserRole
    {
        Admin,
        User,
        Student
    }
    public struct Empolyee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Empolyee(string name, int age)
        {
            Name = name;
            Age = age;
        }
        //public string Name;
        //public int Age;
        
    }
    public struct Product
    {
        public string Name;
        public decimal Price;
    }


}
