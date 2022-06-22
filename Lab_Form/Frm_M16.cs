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
    public partial class Frm_M16 : Form
    {
        public Frm_M16()
        {
            InitializeComponent();
        }

        //@ By Value Type
        private void btn_byValueType_Click(object sender, EventArgs e)
        {
            decimal Dec = 10;
            MessageBox.Show(Dec.ToString());

            ByValueType(Dec); //呼叫方法，複製10給d，Dec仍不變
            MessageBox.Show(Dec.ToString());
        }
        //先定義方法
        void ByValueType(decimal d)
        {
            d = 1000;
        }

        //@ By Reference Type
        private void btn_byReferenceType_Click(object sender, EventArgs e)
        {
            Member mem1 = new Member();
            mem1.Name = "Ciara";
            mem1.Age = 20;
            ByReferenceType(mem1);
            MessageBox.Show(mem1.Name + ", " + mem1.Age);
        }
        //先定義方法
        void ByReferenceType(Member member)
        {
            member.Age = 30;
        }

        //@ By ref 強制視為參考型別
        private void btn_byref_Click(object sender, EventArgs e)
        {
            decimal Dec = 10;
            MessageBox.Show(Dec.ToString());

            Byref(ref Dec); //參數前也要加ref
            MessageBox.Show(Dec.ToString());
        }
        //ref參數
        void Byref(ref decimal d) 
        { 
            d = 1000; 
        }

        //@ By out
        private void btn_byout_Click(object sender, EventArgs e)
        {
            int a;
            Byout(out a); //參數前也要加out
            MessageBox.Show(a.ToString());
        }

        void Byout(out int Age)
        {
            Age = 10;
        }
        
        //@ Params
        private void btn_byParams_Click(object sender, EventArgs e)
        {
            string chi = MyParams("國文", 70, 80, 90);
            //MessageBox.Show(chi);
            string math = MyParams("數學", 60, 70, 80, 90);
            //MessageBox.Show(math); 
            string eng = MyParams("英文");
            //MessageBox.Show(eng);
            MessageBox.Show($"{chi}\n{math}\n{eng}");
        }

        string MyParams(string Course, params int[] Score)
        {
            int Total = 0;
            for(int i = 0; i < Score.Length; i++)
            {
                Total += Score[i];
            }
            return Course + "總成績: " + Total;
        }
        


    }
}
