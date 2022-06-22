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
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }
        
        private void btnHello_Click(object sender, EventArgs e)
        {
            string NameChi = txtNameChi.Text;
            string NameEng = txtNameEng.Text;
            string Ctl = txtCtl.Text;
            string Sex = txtSex.Text;

            MessageBox.Show($"Hello! 我是{NameChi}\n英文名字是{NameEng}\n" +
                $"星座是{Ctl}\n性別是{Sex}\n很高興認識你!");
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            string NameChi = txtNameChi.Text;
            string NameEng = txtNameEng.Text;
            string Ctl = txtCtl.Text;
            string Sex = txtSex.Text;

            MessageBox.Show($"Hi! 我是{NameChi}\n英文名字是{NameEng}\n" +
                $"星座是{Ctl}\n性別是{Sex}\n很高興認識你!");
        }
    }
}
