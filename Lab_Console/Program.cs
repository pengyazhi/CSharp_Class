using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入使用者名稱：");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello Csharp!" + Name);
            MyClass mc = new MyClass();
            mc.Method04();
            Console.ReadKey();
        }
    }
}
