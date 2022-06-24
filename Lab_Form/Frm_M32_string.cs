using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M32_string : Form
    {
        public Frm_M32_string()
        {
            InitializeComponent();
        }

        // String
        private void btnString_Click(object sender, EventArgs e)
        {
            string A = "String";
            string B = A;
            B = "BBB";

            MessageBox.Show("A: " + A + ", B: " + B);
        }

        // StringBuilder
        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("StringBuilder 1");

            StringBuilder sb2 = new StringBuilder();
            sb2 = sb1;
            sb2.Append("\nStringBuilder 2");
            MessageBox.Show(sb2.ToString());
        }

        // Path 處理路徑字串
        private void btnPath_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Users\Student\Csharp\LabCsharp\Lab_Csharp\Image\IU.jpg";
                         // "\"為跳脫字元，若要當作字串，可改以\\，或於整個字串前加入@
            string result = "";

            result += Path.GetDirectoryName(dir) + "\n" +
                Path.GetFileName(dir) + "\n" +
                Path.GetFileNameWithoutExtension(dir)+ "\n" +
                Path.GetExtension(dir);
                // Path僅處理該路徑字串，不論該路徑是否真的存在

            MessageBox.Show(result);
        }


        bool IsStrongPassword (string Password)
        {
            return Regex.IsMatch(Password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-z]).{8,16}$");
        }

        bool IsIDCorrect (string ID)
        {
            return Regex.IsMatch(ID, @"^[A-Z]{1}[1-2]{1}[0-9]{8}$");
        }

        private void btnCertify_Click(object sender, EventArgs e)
        {
            labPassword.Text = IsStrongPassword(txtPassword.Text) ? "密碼強度高" : "密碼強度低";
            labID.Text = IsIDCorrect(txtID.Text) ? "身分證格式正確" : "身分證格式錯誤";
        }

        //邊打字時就驗證 TextChange
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            //todo
            //labPassword.Text = IsStrongPassword(txtPassword.Text) ? "密碼強度高" : "密碼強度低";
            if (IsStrongPassword(txtPassword.Text))
            {
                labPassword.Text = "密碼強度高";
                timer1.Enabled = false;
                labPassword.BackColor = Color.Transparent;
                labPassword.ForeColor = Color.Black;
            }

            else
            {
                labPassword.Text = "密碼強度低";
                timer1.Enabled = true;
            }
        }
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            //labID.Text = IsIDCorrect(txtID.Text) ? "身分證格式正確" : "身分證格式錯誤";
        }

        //提示閃爍 Timer
        bool flag = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                labPassword.BackColor = Color.Red;
                labPassword.ForeColor = Color.Yellow;
            }
            else 
            {
                labPassword.BackColor = Color.Yellow;
                labPassword.ForeColor = Color.Red;
            }
            flag = !flag;
        }

        // String常用屬性
        private void btnStringUSe_Click(object sender, EventArgs e)
        {
            string str = "三番故里窗外雨滴打破細碎的玻璃";
            char c = str[2];

            MessageBox.Show(c.ToString() + ", Length: " + str.Length);

            string result = "";
            //for (int i=0; i<str.Length;i++)
            //{
            //    result += str[i] + "\n";
            //}
            foreach (char item in str)
            {
                result += item + "\n";
            }

            MessageBox.Show(result);
        }

        
    }
}
