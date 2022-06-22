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
    public partial class Frm_Loan : Form
    {
        public Frm_Loan()
        {
            InitializeComponent();
        }
        //public System.Windows.Forms.Label txtInfo;


        double PMT(double loan, int year, double interest, double first)
        {
            double r = interest / 12 / 100;
            int n = year * 12;
            double rpn = Math.Pow(r + 1, n);
            double p = (loan - first) * rpn * r / (rpn - 1);

            return Math.Round(p);
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(txtLoan.Text);
            int y = int.Parse(txtYear.Text);
            double i = Convert.ToDouble(txtInterest.Text);
            double f = Convert.ToDouble(txtFirst.Text);

            int perMonth = (int)PMT(l, y, i, f);
            //int pm = (int)Math.Round(perMonth);
            MessageBox.Show("月付額: " + perMonth + "元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(txtLoan.Text);
            int y = int.Parse(txtYear.Text);
            double i = Convert.ToDouble(txtInterest.Text);
            double f = Convert.ToDouble(txtFirst.Text);

            int total = y * 12 * (int)PMT(l, y, i, f);
            MessageBox.Show("總付款: " + total + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            double l = Convert.ToDouble(txtLoan.Text);
            int y = int.Parse(txtYear.Text);
            double i = Convert.ToDouble(txtInterest.Text);
            double f = Convert.ToDouble(txtFirst.Text);
            int p = (int)PMT(l, y, i, f);
            int t = p * y * 12;

            Frm_Loan_Report LoanReport = new Frm_Loan_Report();
            LoanReport.LoanR = this.txtLoan.Text;
            LoanReport.YearR = this.txtYear.Text;
            LoanReport.InterestR = this.txtInterest.Text;
            LoanReport.PmtR = p.ToString();
            LoanReport.TotalR = t.ToString();

            LoanReport.Show();
        }
    }
}
