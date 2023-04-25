using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M26_Arry : Form
    {
        public Frm_M26_Arry()
        {
            InitializeComponent();
        }
        
        private void btnArry_Click(object sender, EventArgs e)
        {
            string result = "";
            int sum = 0;
            //int[] arr = new int[5];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            //arr[3] = 4;
            //arr[4] = 5;
            //int[] arr = new int[5]{ 1, 2, 3, 4, 5 }; 建立陣列時同時賦予值

            int []arr = { 1, 2, 3, 4, 5 };  //建立陣列時同時賦予值且省略new int[]
            for (int i = 0; i < arr.Length; i++)
            {
                //result = $"{arr[i]}\n";
                //arr[0]+arr[1]+arr[2]+arr[3]+arr[4] =15
                //sum += arr[i];
                result += $"{arr[i]}\n";
            }
            MessageBox.Show(result);
        }

        private void btnArrySecond_Click(object sender, EventArgs e)
        {
            string result = "";
            
            int[,] arr2 = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
             };
           
            for(int i = 0; i < arr2.GetLength(0); i++) //取第一個維度的長度
            {
                for(int j = 0; j < arr2.GetLength(1); j++)//取第二個維度的長度 
                {
                    result += $"arr[{i},{j}] : {arr2[i, j]}\n";
                }
                
            }
            MessageBox.Show(result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            
            //Member[] mem = new Member[2];
            //mem[0] = new Member();
            //mem[0].Name = "Amy";
            //mem[0].Age = 23;
            //mem[1] = new Member();
            //mem[1].Name = "Ben";
            //mem[1].Age = 25;
            //for (int i = 0; i < mem.Length; i++)
            //{
            //    result += $"會員姓名 : {mem[i].Name} 會員年齡 : {mem[i].Age}\n";
            //}
            //MessageBox.Show(result);
            int [] arr = CreatArr(20);
            //for (int i = 0;i < arr.Length; i++)
            //{
            //    result += $"arr[{i}] :{arr[i]}\n";
            //}
            foreach(int item in arr)
            {
                result += item + "\n";
            }
            MessageBox.Show(result);
        }
        int[] CreatArr(int Len)
        {
            int[] MyArr = new int[Len];
            for(int i = 0;i < MyArr.Length; i++)
            {
                MyArr[i] =i + 1;
            }
            return MyArr;
        }
    }
    
}
