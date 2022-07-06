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

        double l = 0;
        int y = 0;
        double i = 0;
        double f = 0;

        public void Test()
        {
            if (double.TryParse(txtLoan.Text, out l)
                && int.TryParse(txtYear.Text, out y)
                && double.TryParse(txtInterest.Text, out i)
                && double.TryParse(txtFirst.Text, out f))
            {
                l = double.Parse(txtLoan.Text);
                y = int.Parse(txtYear.Text);
                i = double.Parse(txtInterest.Text);
                f = double.Parse(txtFirst.Text);
            }
            else
                MessageBox.Show("請輸入正確數字");
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            try
            {
                Test();

                int perMonth = Convert.ToInt32(PMT(l, y, i, f));
                //int pm = (int)Math.Round(perMonth);
                MessageBox.Show("月付額: " + perMonth + "元");
            }
            catch (OverflowException)
            { }

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            try
            {
                Test();

                int total = y * 12 * Convert.ToInt32(PMT(l, y, i, f));
                MessageBox.Show("總付款: " + total + "元");
            }
            catch (OverflowException)
            { }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                Test();

                int p = Convert.ToInt32(PMT(l, y, i, f));
                int t = p * y * 12;

                Frm_Loan_Report LoanReport = new Frm_Loan_Report();

                LoanReport.txtLoanR.Text = this.txtLoan.Text;
                LoanReport.txtYearR.Text = this.txtYear.Text;
                LoanReport.txtInterestR.Text = this.txtInterest.Text;
                LoanReport.txtPmtR.Text = p.ToString();
                LoanReport.txtTotalR.Text = t.ToString();

                LoanReport.Show();
            }
            catch (OverflowException)
            { }
        }
    }
}
