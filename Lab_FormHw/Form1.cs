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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("notepad.exe");
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Frm_Hello hello = new Frm_Hello();
            hello.TopLevel = false;
            //hello.AutoScroll = true;
            hello.Show();
            splitContainer2.Panel2.Controls.Add(hello);
            
        }

        // new
        // TopLevel = false
        
    }
}
