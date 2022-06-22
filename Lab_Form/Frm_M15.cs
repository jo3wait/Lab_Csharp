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
    public partial class Frm_M15 : Form
    {
        public Frm_M15()
        {
            InitializeComponent();
        }

        //@ Value Type
        private void btnValueType_Click(object sender, EventArgs e)
        {
            int A = 100;
            MessageBox.Show(A.ToString());

            int B = A;
            MessageBox.Show("A: " + A + ", B: " + B);

            B = 200;
            MessageBox.Show("A: " + A + ", B: " + B);
        }

        //@ Reference Type
        private void btnReferenceType_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;
            tb.Text = "Reference Type";
            tb.BackColor = Color.Beige;
            tb.ForeColor = Color.Olive;

            //tb.Location = new Point(150, 200);
        }

        //@ String
        //字串為參考型別但是記憶體存放方式不太一樣
        //指派後，改變其一變數，會新開一個記憶體位置，不會改變原本的
        private void btnString_Click(object sender, EventArgs e)
        {
            //string strA = "AAA";
            //string strB = "BBB";
            string strA = "AAA", strB = "BBB";
            MessageBox.Show("A: " + strA + ", B: " + strB);

            strB = strA;
            strB = "String BBB";
            MessageBox.Show("A: " + strA + ", B: " + strB);
        }
    }
}
