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
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            StudentScore score;
            score.StudentName = txtName.Text;
            
            score.StudentChi = double.Parse(txtChi.Text);
            score.StudentEng = double.Parse(txtEng.Text);
            score.StudentMath = double.Parse(txtMath.Text);

            //double num1 = 0;
            //bool isNum1 = double.TryParse(txtNum1.Text, out num1);

            //if (isNum1 && isNum2)
            //{
            //    lstStudentScore.Add(score);
            //}
            //else
            //{
            //    MessageBox.Show("請輸入正確數字");
            //}


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //ShowScore();
            for (int i = 0; i < lstStudentScore.Count; i++)
            {
                labScore.Text = $"姓名: {((StudentScore)lstStudentScore[i]).StudentName}\n" +
                    $"國文: {((StudentScore)lstStudentScore[i]).StudentChi}\n" +
                    $"英文: {((StudentScore)lstStudentScore[i]).StudentEng}\n" +
                    $"數學: {((StudentScore)lstStudentScore[i]).StudentMath}\n";
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {                                    
            for (int i = 0; i < lstStudentScore.Count; i++)
            {
                double chi = ((StudentScore)lstStudentScore[i]).StudentChi;
                double eng = ((StudentScore)lstStudentScore[i]).StudentEng;
                double math = ((StudentScore)lstStudentScore[i]).StudentMath;
                if (chi > eng && chi > math)
                    labMaxMin.Text = $"最高科目成績為: 國文 {chi}分\n";
                else if (eng > chi && eng > math)
                    labMaxMin.Text = $"最高科目成績為: 英文 {eng}分\n";
                else if (math > chi && math > eng)
                    labMaxMin.Text = $"最高科目成績為: 數學 {math}分\n";
                
                if(chi < eng && chi < math)
                    labMaxMin.Text += $"最低科目成績為: 國文 {chi}分\n";
                else if(eng<chi&&eng<math)
                    labMaxMin.Text += $"最低科目成績為: 英文 {eng}分\n";
                else if (math < chi && math < eng)
                    labMaxMin.Text += $"最低科目成績為: 數學 {math}分\n";

                if (chi == eng && chi > math)
                    labMaxMin.Text = $"最高科目成績為: 國英 {chi}分\n" +
                        $"最低科目成績為: 數學 {math}分";
                else if (chi == math && chi > eng)
                    labMaxMin.Text = $"最高科目成績為: 國數 {chi}分\n" +
                        $"最低科目成績為: 英文 {eng}分";
                else if (eng == math && eng > chi)
                    labMaxMin.Text = $"最高科目成績為: 英數 {eng}分\n" +
                        $"最低科目成績為: 國文 {chi}分";

                if (chi == eng && chi < math)
                    labMaxMin.Text = $"最高科目成績為: 數學 {math}分\n" +
                        $"最低科目成績為: 國英 {chi}分";
                else if (chi == math && chi < eng)
                    labMaxMin.Text = $"最高科目成績為: 英文 {eng}分\n" +
                        $"最低科目成績為: 國數 {chi}分";
                else if (eng == math && eng < chi)
                    labMaxMin.Text = $"最高科目成績為: 國文 {chi}分\n" +
                        $"最低科目成績為: 英數 {eng}分";

                if (chi == eng && chi == math)
                    labMaxMin.Text = $"國英數同分: {chi}分";
            }
        }

    }
}
