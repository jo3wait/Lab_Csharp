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
    public partial class Frm_M12 : Form
    {
        public Frm_M12()
        {
            InitializeComponent();
        }

        //@Count
        //count變數要寫在方法外面才會保留
        int count = 0;

        private void btnPlusOne_Click(object sender, EventArgs e)
        {
            //@遞增
            //count = count + 1;
            count += 1;
            labCount.Text = "Count: " + count;
        }

        private void btnMinOne_Click(object sender, EventArgs e)
        {
            //@遞減
            //count = count - 1;
            count -= 1;
            labCount.Text = "Count: " + count;
        }

        private void btnPPCount_Click(object sender, EventArgs e)
        {
            //@前置遞增
            int i = ++count;
            //count +=1;
            //int i = count;
            labCount.Text = "Count: " + count;
            MessageBox.Show(i.ToString());
        }

        private void btnCountPP_Click(object sender, EventArgs e)
        {
            //@後置遞增
            int i = count++;
            //int i = count;
            //count += 1;
            labCount.Text = "Count: " + count;
            MessageBox.Show(i.ToString());
        }

        //@測試變數可見範圍
        private void button1_Click(object sender, EventArgs e)
        {
            //a 
            int a = 0;
            if(true)
            {
                int x = 100;
                a = x;
            }
            //x = 101;
            count = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //a = 0;
            count = 0;
        }

        //@ Use Instance Variable from Utility.cs
        UseStatic us = new UseStatic(); //要寫在方法外
        private void btnInstance_Click(object sender, EventArgs e)
        {
            //UseStatic us = new UseStatic(); //要寫在方法外，否則每次點擊count會重置
            us.InstanceCount++;
            labInstance.Text = "Instance Count: " + us.InstanceCount;
        }

        //@ Use Static Variable
        private void btnStatic_Click(object sender, EventArgs e)
        {
            UseStatic.StaticCount++;
            labStatic.Text = "Static Count: " + UseStatic.StaticCount;
        }

        //@ Open HelloForm
        private void button3_Click(object sender, EventArgs e)
        {
            Frm_M02_HelloForm frm = new Frm_M02_HelloForm();
            frm.Show();
        }
    }
}
