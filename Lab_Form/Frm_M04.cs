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
    public partial class Frm_M04 : Form
    {
        public Frm_M04()
        {
            InitializeComponent();
        }

        //@ Open M02 Hello Form from M04
        private void btnOpenHelloForm_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm helloForm = new Frm_M02_HelloForm(); //實作該類別(開一個記憶體位置)
            helloForm.Show(); //沒寫的話，仍可執行，只存於記憶體不會顯示
        }

        //@定義方法
        void MyFirstMethod()
        {
            MessageBox.Show("MyFirstMethod");
        }

        //@呼叫
        private void button1_Click(object sender, EventArgs e)
        {
            MyFirstMethod();
        }

        private void Method_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            //mc.Method01(); //因為private無法執行
            //mc.Method02();
            mc.Method03();
            mc.Method04();
        }

        //@ Return
        string BirthYear(int Age)
        {
            int birthYear = DateTime.Now.Year - Age;
            string result = "出生年為" + birthYear + "年";
            return result;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string birth = BirthYear(100);
            MessageBox.Show(birth);
        }

        //@ Encapsulation
        private void btn_Encap_Click(object sender, EventArgs e)
        {
            // Encapsulation 封裝，透過public method呼叫private
            MyFirstClass mc = new MyFirstClass();
            mc.Method05();
        }

        //@ Partial Class
        private void btn_PartialClass_Click(object sender, EventArgs e)
        {
            MyFirstClass mc = new MyFirstClass();
            mc.Method06(); //呼叫不同檔案Utility( partial class MyFirstClass)的方法
        }
    }
}
