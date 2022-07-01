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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }

        //要宣告子表單的爸爸是誰 Owner 

        Random rdm = new Random(); 
        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int inp = 0;
            int ans = rdm.Next(0, 100);
            bool isNum = int.TryParse(txtInput.Text, out inp);
            if (isNum && inp <= 100 && inp >= 0)
            {

            }
            else
            {
                MessageBox.Show("請輸入0-100數字");
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
