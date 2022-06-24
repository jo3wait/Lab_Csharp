using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M34_ReadWrite : Form
    {
        public Frm_M34_ReadWrite()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../TestRead.txt", Encoding.UTF8);
            txtReadWrite.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
