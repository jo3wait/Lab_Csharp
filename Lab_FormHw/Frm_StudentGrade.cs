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
        // .Next(0, 100)
        // for loop i<20

        List<StudentGrade> lstStudentGrade = new List<StudentGrade>();

        void ShowScore()
        {
            labShow.Text = "";

            //todo 文字對齊
            foreach (StudentGrade item in lstStudentGrade)
            {
                labShow.Text += $"{item.StudentName}    "+
                    $"{item.StudentChi}   "+
                    $"{item.StudentEng}   "+
                    $"{item.StudentMath}   "+
                    $"{item.StudentTotal}   "+
                    $"{item.StudentAvg}   \n";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double numChi = 0;
            double numEng = 0;
            double numMath = 0;
            
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
                grade.StudentAvg = Math.Round(grade.StudentTotal/3, 1);
                lstStudentGrade.Add(grade);                
            }
            else
            {
                MessageBox.Show("成績請輸入數字");
            }

            ShowScore();
        }

        private void btnAvr_Click(object sender, EventArgs e)
        {
            labShow.Text = "";
        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            int RdmChi = rdm.Next(0, 100);
            int RdmEng = rdm.Next(0, 100);
            int RdmMath = rdm.Next(0, 100);

            StudentGrade grade;
            
            //todo 隨機加入的編號
            string RdmName = "rdm";

            grade.StudentName = RdmName;
            grade.StudentChi = RdmChi;
            grade.StudentEng = RdmEng;
            grade.StudentMath = RdmMath;
            grade.StudentTotal = RdmChi + RdmEng + RdmMath;
            grade.StudentAvg = Math.Round(grade.StudentTotal / 3, 1);
            lstStudentGrade.Add(grade);

            ShowScore();            
        }
    }
}
