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
    public partial class Frm_M02_HelloForm : Form
    {
        public Frm_M02_HelloForm()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            MessageBox.Show("Hello, "+Name);

            // Use Static Variable
            // 顯示Frm_M12表單Static Count操作的結果
            MessageBox.Show(UseStatic.StaticCount.ToString());
        }
    }
}
