using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_Form;

namespace Lab_Consloe
{
    class Program
    {
        static void Main(string[] args)
        {
            // @todo
            // todo test 可顯示於工作清單
            //@輸出
            Console.WriteLine("Hello C#!"); //WriteLine換行
            Console.Write("請輸入姓名: "); //Write不換行
            //@輸入
            string Name = Console.ReadLine();

            Console.WriteLine("Hello, " + Name);

            //@宣告&呼叫方法
            MyFirstClass mc = new MyFirstClass();
            mc.Method04();

            Console.ReadKey(); //without this執行完會自動關閉，ReadKey保留畫面
        }
    }
}
