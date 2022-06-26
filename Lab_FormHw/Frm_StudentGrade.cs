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

        // Random rdm = new Random();
        // .Next(0, 100)
        // for loop i<20

        ArrayList lstStudentScore = new ArrayList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentScore score;
            score.StudentName = txtName.Text;
            //todo TryParse未設
            score.StudentChi = double.Parse(txtChi.Text);
            score.StudentEng = double.Parse(txtEng.Text);
            score.StudentMath = double.Parse(txtMath.Text);

            lstStudentScore.Add(score);

            //ShowScore();
            for (int i = 0; i < lstStudentScore.Count; i++)
            {
                labShow.Text = $"姓名: {((StudentScore)lstStudentScore[i]).StudentName}\n" +
                    $"國文: {((StudentScore)lstStudentScore[i]).StudentChi}\n" +
                    $"英文: {((StudentScore)lstStudentScore[i]).StudentEng}\n" +
                    $"數學: {((StudentScore)lstStudentScore[i]).StudentMath}\n";
            }
        }
    }
}
