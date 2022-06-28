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
    public partial class Frm_StudentGrade : Form
    {
        public Frm_StudentGrade()
        {
            InitializeComponent();
        }

        Random rdm = new Random();
        
        List<StudentGrade> lstStudentGrade = new List<StudentGrade>();
                      

        void ShowScore()
        {
            labShow.Text = "";

            
            foreach (StudentGrade item in lstStudentGrade)
            {
                labShow.Text += $"{item.StudentName, -6}" +
                    $"{item.StudentChi,6}" +
                    $"{item.StudentEng,6}" +
                    $"{item.StudentMath,6}" +
                    $"{item.StudentTotal,6}" +
                    $"{item.StudentAvg,6}" +
                    $"{item.StudentMax,8}" +
                    $"{item.StudentMin,8:N0}\n";
            }
            
            //https://blog.darkthread.net/blog/string-format-alignment/
            
        }

        //double numChi = 0;
        //double numEng = 0;
        //double numMath = 0;
        //string Max = "";
        //string Min = "";

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAvr.Enabled = true;
                                    
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("請輸入姓名");
                txtName.Focus(); 
            }
            if (string.IsNullOrEmpty(txtChi.Text))
            {
                MessageBox.Show("請輸入國文成績");
                txtChi.Focus();
            }
            if (string.IsNullOrEmpty(txtEng.Text))
            {
                MessageBox.Show("請輸入英文成績");
                txtEng.Focus();
            }
            if (string.IsNullOrEmpty(txtMath.Text))
            {
                MessageBox.Show("請輸入數學成績");
                txtMath.Focus();
            }

            double numChi = 0;
            double numEng = 0;
            double numMath = 0;
            string Max = "";
            string Min = "";

            StudentGrade grade;

            grade.StudentName = txtName.Text;

            bool isNumChi = double.TryParse(txtChi.Text, out numChi);
            bool isNumEng = double.TryParse(txtEng.Text, out numEng);
            bool isNumMath = double.TryParse(txtMath.Text, out numMath);

            if (isNumChi && isNumEng && isNumMath)
            {                
                grade.StudentChi = numChi;
                grade.StudentEng = numEng;
                grade.StudentMath = numMath;
                grade.StudentTotal = numChi + numEng + numMath;
                grade.StudentAvg = Math.Round(grade.StudentTotal / 3, 1);

                //Max
                if (numChi > numEng && numChi > numMath)
                    Max = $"國文{numChi}";
                else if (numEng > numChi && numEng > numMath)
                    Max = $"英文{numEng}";
                else if (numMath > numChi && numMath > numEng)
                    Max = $"數學{numMath}";
                else if
                    (numChi == numEng && numChi > numMath)
                    Max = $"國英{numChi}";
                else if (numChi == numMath && numChi > numEng)
                    Max = $"國數{numChi}";
                else if (numEng == numMath && numEng > numChi)
                    Max = $"英數{numEng}";

                //Min
                if (numChi < numEng && numChi < numMath)
                    Min = $"國文{numChi}";
                else if (numEng < numChi && numEng < numMath)
                    Min = $"英文{numEng}";
                else if (numMath < numChi && numMath < numEng)
                    Min = $"數學{numMath}";
                else if (numChi == numEng && numChi < numMath)
                    Min = $"國英{numChi}";
                else if (numChi == numMath && numChi < numEng)
                    Min = $"國數{numChi}";
                else if (numEng == numMath && numEng < numChi)
                    Min = $"英數{numEng}";

                if (numChi == numEng && numChi == numMath)
                {
                    Max = "";
                    Min = $"國英數同分{numChi}";
                }

                grade.StudentMax = Max;
                grade.StudentMin = Min;

                lstStudentGrade.Add(grade);
            }
            else
            {
                MessageBox.Show("成績請輸入數字");
            }
            
            ShowScore();
        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            btnAvr.Enabled = true;

            int numChi = rdm.Next(0, 100);
            int numEng = rdm.Next(0, 100);
            int numMath = rdm.Next(0, 100);
            string Max = "";
            string Min = "";

            StudentGrade grade;            
                      
            grade.StudentName = (lstStudentGrade.Count + 1).ToString();
            grade.StudentChi = numChi;
            grade.StudentEng = numEng;
            grade.StudentMath = numMath;
            grade.StudentTotal = numChi + numEng + numMath;
            grade.StudentAvg = Math.Round(grade.StudentTotal / 3, 1);

            //Max
            if (numChi > numEng && numChi > numMath)
                Max = $"國文{numChi}";
            else if (numEng > numChi && numEng > numMath)
                Max = $"英文{numEng}";
            else if (numMath > numChi && numMath > numEng)
                Max = $"數學{numMath}";
            else if
                (numChi == numEng && numChi > numMath)
                Max = $"國英{numChi}";
            else if (numChi == numMath && numChi > numEng)
                Max = $"國數{numChi}";
            else if (numEng == numMath && numEng > numChi)
                Max = $"英數{numEng}";

            //Min
            if (numChi < numEng && numChi < numMath)
                Min = $"國文{numChi}";
            else if (numEng < numChi && numEng < numMath)
                Min = $"英文{numEng}";
            else if (numMath < numChi && numMath < numEng)
                Min = $"數學{numMath}";
            else if (numChi == numEng && numChi < numMath)
                Min = $"國英{numChi}";
            else if (numChi == numMath && numChi < numEng)
                Min = $"國數{numChi}";
            else if (numEng == numMath && numEng < numChi)
                Min = $"英數{numEng}";

            // all same
            if (numChi == numEng && numChi == numMath)
            {
                Max = "";
                Min = $"國英數同分{numChi}";
            }

            grade.StudentMax = Max;
            grade.StudentMin = Min;

            lstStudentGrade.Add(grade);

            ShowScore();            
        }

        private void btnAvr_Click(object sender, EventArgs e)
        {
            double totalChi = 0;
            double totalEng = 0;
            double totalMath = 0;
            double avgChi = 0;
            double avgEng = 0;
            double avgMath = 0;

            for (int i = 0; i < lstStudentGrade.Count; i++)
            {
                totalChi += lstStudentGrade[i].StudentChi;
                totalEng += lstStudentGrade[i].StudentEng;
                totalMath += lstStudentGrade[i].StudentMath;
                avgChi = Math.Round(totalChi / (i + 1), 1);
                avgEng = Math.Round(totalEng / (i + 1), 1);
                avgMath = Math.Round(totalMath / (i + 1), 1);
            }

            //各科最高及最低
            double Cmax = 0, Emax = 0, Mmax = 0;
            double Cmin = 0, Emin = 0, Mmin = 0;

            lstStudentGrade.Sort((x, y) => y.StudentChi.CompareTo(x.StudentChi));
            Cmax = lstStudentGrade[0].StudentChi;
            Cmin = lstStudentGrade[lstStudentGrade.Count - 1].StudentChi;
            lstStudentGrade.Sort((x, y) => y.StudentEng.CompareTo(x.StudentEng));
            Emax = lstStudentGrade[0].StudentEng;
            Emin = lstStudentGrade[lstStudentGrade.Count - 1].StudentEng;
            lstStudentGrade.Sort((x, y) => y.StudentMath.CompareTo(x.StudentMath));
            Mmax = lstStudentGrade[0].StudentMath;
            Mmin = lstStudentGrade[lstStudentGrade.Count - 1].StudentMath;

            labSum.Text =
                $"{"總分",-6}{totalChi,6}{totalEng,6}{totalMath,6}\n" +
                $"{"平均",-6}{avgChi,6}{avgEng,6}{avgMath,6}\n" +
                $"{"最高分",-5}{Cmax,6}{Emax,6}{Mmax,6}\n" +
                $"{"最低分",-5}{Cmin,6}{Emin,6}{Mmin,6}\n";

            btnAdd.Enabled = false;
            btnAddRandom.Enabled = false;
            btnAddRdm20.Enabled = false;
            btnAvr.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
            labSum.Text = "";
            lstStudentGrade.Clear();

            btnAdd.Enabled = true;
            btnAddRandom.Enabled = true;
            btnAddRdm20.Enabled = true;
            btnAvr.Enabled = false;
        }

        private void btnAddRdm20_Click(object sender, EventArgs e)
        {
            btnAvr.Enabled = true;

            StudentGrade grade;
            
            for (int i = 0; i < 20; i++)
            {
                int numChi = rdm.Next(0, 100);
                int numEng = rdm.Next(0, 100);
                int numMath = rdm.Next(0, 100);
                string Max = "";
                string Min = "";

                grade.StudentName = (lstStudentGrade.Count + 1).ToString();
                grade.StudentChi = numChi;
                grade.StudentEng = numEng;
                grade.StudentMath = numMath;
                grade.StudentTotal = numChi + numEng + numMath;
                grade.StudentAvg = Math.Round(grade.StudentTotal / 3, 1);

                //Max
                if (numChi > numEng && numChi > numMath)
                    Max = $"國文{numChi}";
                else if (numEng > numChi && numEng > numMath)
                    Max = $"英文{numEng}";
                else if (numMath > numChi && numMath > numEng)
                    Max = $"數學{numMath}";
                else if
                    (numChi == numEng && numChi > numMath)
                    Max = $"國英{numChi}";
                else if (numChi == numMath && numChi > numEng)
                    Max = $"國數{numChi}";
                else if (numEng == numMath && numEng > numChi)
                    Max = $"英數{numEng}";

                //Min
                if (numChi < numEng && numChi < numMath)
                    Min = $"國文{numChi}";
                else if (numEng < numChi && numEng < numMath)
                    Min = $"英文{numEng}";
                else if (numMath < numChi && numMath < numEng)
                    Min = $"數學{numMath}";
                else if (numChi == numEng && numChi < numMath)
                    Min = $"國英{numChi}";
                else if (numChi == numMath && numChi < numEng)
                    Min = $"國數{numChi}";
                else if (numEng == numMath && numEng < numChi)
                    Min = $"英數{numEng}";

                // all same
                if (numChi == numEng && numChi == numMath)
                {
                    Max = "";
                    Min = $"國英數同分{numChi}";
                }

                grade.StudentMax = Max;
                grade.StudentMin = Min;

                lstStudentGrade.Add(grade);
            }

            ShowScore();
        }        
    }
}
