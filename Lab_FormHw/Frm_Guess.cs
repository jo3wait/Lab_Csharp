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
    public partial class Frm_Guess : Form
    {
        public Frm_Guess()
        {
            InitializeComponent();
        }

        //Random rdm = new Random();

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Random rdm = new Random();
            int ans = rdm.Next(0, 100);

            Guess g = new Guess();
            g.Show();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Answer is ");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
