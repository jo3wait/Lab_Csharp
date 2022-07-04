using System;
using System.Collections;
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

        public System.Windows.Forms.Label txtInfo;

        //public string Lab
        //{
        //    get
        //    {
        //        return this.labShow.Text;
        //    }
        //    set
        //    {
        //        this.labShow.Text = value;
        //    }
        //}

        //Random rdm = new Random();
        public static int ans = 0;

        public static ArrayList lstTop = new ArrayList();
        public static ArrayList lstBot = new ArrayList();

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Guess g = new Guess();
            g.Owner = this;

            Random rdm = new Random();
            ans = rdm.Next(0, 100);
                        
            g.Show();

            
            lstTop.Add(100);
            lstBot.Add(0);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The answer is {ans}.");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
    }
}
