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


        //ArrayList lstStudentScore = new ArrayList();
        List<StudentScore> lstStudentScore = new List<StudentScore>();


        private void btnSave_Click(object sender, EventArgs e)
        {
            int numChi = 0;
            int numEng = 0;
            int numMath = 0; 
            
            StudentScore score;

            if (string.IsNullOrEmpty(txtName.Text))
                MessageBox.Show("請輸入姓名");

            score.StudentName = txtName.Text;

            bool isNumChi = int.TryParse(txtChi.Text, out numChi);
            bool isNumEng = int.TryParse(txtEng.Text, out numEng);
            bool isNumMath = int.TryParse(txtMath.Text, out numMath);

            if (isNumChi && isNumEng && isNumMath)
            {
                score.StudentChi = numChi;
                score.StudentEng = numEng;
                score.StudentMath = numMath;
                lstStudentScore.Add(score);
            }
            else
            {
                MessageBox.Show("成績請輸入數字");
            }

        }

        void ShowScore()
        {
            foreach (StudentScore item in lstStudentScore)
            {
                labScore.Text = $"姓名: {item.StudentName}\n" +
                    $"國文: {item.StudentChi}\n" +
                    $"英文: {item.StudentEng}\n" +
                    $"數學: {item.StudentMath}";
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ShowScore();            
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {                                    
            for (int i = 0; i < lstStudentScore.Count; i++)
            {
                int chi = ((StudentScore)lstStudentScore[i]).StudentChi;
                int eng = ((StudentScore)lstStudentScore[i]).StudentEng;
                int math = ((StudentScore)lstStudentScore[i]).StudentMath;
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
