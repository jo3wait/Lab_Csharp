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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.WindowState = FormWindowState.Normal;
            //this.Bounds = Screen.PrimaryScreen.Bounds;            
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            Frm_Notepad note = new Frm_Notepad();
            note.TopLevel = false;
            note.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(note);            
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            Frm_Hello hello = new Frm_Hello();
            hello.TopLevel = false;            
            hello.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(hello);
            //hello.Dock = DockStyle.Fill;
            //hello.Bounds = splitContainer2.Panel2.Bounds;
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            Frm_Loan loan = new Frm_Loan();
            loan.TopLevel = false;
            loan.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(loan);
        }

        private void btnStuStruc_Click(object sender, EventArgs e)
        {
            Frm_Stu_Strct strct = new Frm_Stu_Strct();
            strct.TopLevel = false;
            strct.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(strct);
        }

        private void btnStu1_Click(object sender, EventArgs e)
        {
            Frm_StudentGrade grade1 = new Frm_StudentGrade();
            grade1.TopLevel = false;
            grade1.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(grade1);
        }

        private void btnStu2_Click(object sender, EventArgs e)
        {
            Frm_StudentGrade_List grade2 = new Frm_StudentGrade_List();
            grade2.TopLevel = false;
            grade2.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(grade2);
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            Frm_Calculator cal = new Frm_Calculator();
            cal.TopLevel = false;
            cal.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(cal);
        }

        private void btnPose_Click(object sender, EventArgs e)
        {
            Frm_Pose pose = new Frm_Pose();
            pose.TopLevel = false;
            pose.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(pose);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Frm_Guess guess = new Frm_Guess();
            guess.TopLevel = false;
            guess.Show();
            splitContainer2.Panel2.Controls.Clear();
            splitContainer2.Panel2.Controls.Add(guess);
        }
    }
        
}
