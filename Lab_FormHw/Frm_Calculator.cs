using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_FormHw
{
    public partial class Frm_Calculator : Form
    {
        public Frm_Calculator()
        {
            InitializeComponent();
        }

        //delegate double Calculate(double Num1, double Num2);
        //double Plus(double Num1, double Num2)
        //{
        //    return Num1 + Num2;
        //}
        //double Minus(double Num1, double Num2)
        //{
        //    return Num1 - Num2;
        //}
        //double Multiply(double Num1, double Num2)
        //{
        //    return Num1 * Num2;
        //}
        //double Divide(double Num1, double Num2)
        //{
        //    return Num1 / Num2;
        //}


        private void btnPlus_Click(object sender, EventArgs e)
        {
            //Calculate cal;
            //cal = Plus;

            //txtAns.Text = cal(num1, num2).ToString();
            
            double num1 = 0;
            double num2 = 0;
            bool isNum1 = double.TryParse(txtNum1.Text, out num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out num2);
            if (isNum1&&isNum2)
            {
                txtAns.Text = (num1 + num2).ToString();

                //Calculate cal;
                //cal = Plus;
                //txtAns.Text = cal(num1, num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確數字");
            }

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            bool isNum1 = double.TryParse(txtNum1.Text, out num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out num2);
            if (isNum1 && isNum2)
            {
                txtAns.Text = (num1 - num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確數字");
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            bool isNum1 = double.TryParse(txtNum1.Text, out num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out num2);
            if (isNum1 && isNum2)
            {
                txtAns.Text = (num1 * num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確數字");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            bool isNum1 = double.TryParse(txtNum1.Text, out num1);
            bool isNum2 = double.TryParse(txtNum2.Text, out num2);
            if (isNum1 && isNum2)
            {
                txtAns.Text = (num1 / num2).ToString();
            }
            else
            {
                MessageBox.Show("請輸入正確數字");
            }
        }
    }
}
