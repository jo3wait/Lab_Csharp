using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class MyFirstClass
    /*
    Partial Class 跨檔案共同編輯類別MyFirstClass，在class前面寫入partial
    每個要共同編輯同一類別的檔案class都要加partial
    注意要在同一個namespace: Lab_Form底下
    */
    {
        void Method01()  //類別中未指定預設為private
        {
            MessageBox.Show("Method01");  //MessageBox.Show不能直接用，要記得using namespace
        }

        private void Method02()
        {
            MessageBox.Show("Method02");
        }

        internal void Method03()
        {
            MessageBox.Show("Method03 internal");
        }

        public void Method04()
        {
            MessageBox.Show("Method04 public");
        }

        //Encapsulation
        public void Method05()   // Encapsulation 封裝，透過public method呼叫private method
        {
            Method01();
            Method02();
        }

        //delegate 用於Frm_M07
        public double Discount50off(double Price)
        {
            return Price * 0.5;
        }
        public double Discount20off(double Price)
        {
            return Price * 0.8;
        }
    }
    delegate double Payment(double Price);
}
