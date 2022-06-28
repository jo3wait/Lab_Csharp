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
    public partial class Frm_StudentGrade_List : Form
    {
        public Frm_StudentGrade_List()
        {
            InitializeComponent();
        }

        List<StudentGrade> lstStudentGrade = new List<StudentGrade>();

        void ShowScore()
        {
            labShow.Text = "";


            foreach (StudentGrade item in lstStudentGrade)
            {
                labShow.Text += $"{item.StudentName,-6}" +
                    $"{item.StudentChi,6}" +
                    $"{item.StudentEng,6}" +
                    $"{item.StudentMath,6}" +
                    $"{item.StudentTotal,6}" +
                    $"{item.StudentAvg,6}" +
                    $"{item.StudentMax,8}" +
                    $"{item.StudentMin,8:N0}\n";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double numChi = 0;
            double numEng = 0;
            double numMath = 0;
            string Max = "";
            string Min = "";

            StudentGrade grade;

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
    }
}
