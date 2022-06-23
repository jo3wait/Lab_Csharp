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
    public partial class Frm_Stu_Strct : Form
    {
        public Frm_Stu_Strct()
        {
            InitializeComponent();
        }


        ArrayList lstStudentScore = new ArrayList();
        //void ShowScore()
        //{
        //    for (int i = 0; i < lstStudentScore.Count; i++)
        //    {
        //        labScore.Text += $"姓名: {((StudentScore)lstStudentScore[i]).StudentName}\n " +
        //            $"國文: {((StudentScore)lstStudentScore[i]).StudentChi}\n" +
        //            $"英文: {((StudentScore)lstStudentScore[i]).StudentEng}\n" +
        //            $"數學: {((StudentScore)lstStudentScore[i]).StudentMath}\n";
        //    }            
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentScore score;
            score.StudentName = txtName.Text;
            //TryParse未設
            score.StudentChi = double.Parse(txtChi.Text);
            score.StudentEng = double.Parse(txtEng.Text);
            score.StudentMath = double.Parse(txtMath.Text);

            lstStudentScore.Add(score);
           
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //ShowScore();
            for (int i = 0; i < lstStudentScore.Count; i++)
            {
                labScore.Text = $"姓名: {((StudentScore)lstStudentScore[i]).StudentName}\n " +
                    $"國文: {((StudentScore)lstStudentScore[i]).StudentChi}\n" +
                    $"英文: {((StudentScore)lstStudentScore[i]).StudentEng}\n" +
                    $"數學: {((StudentScore)lstStudentScore[i]).StudentMath}\n";
            }
        }
    }
}
