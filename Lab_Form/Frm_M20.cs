using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Frm_M20 : Form
    {
        public Frm_M20()
        {
            InitializeComponent();
        }

        //Reverse !
        bool flag = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                button1.BackColor = Color.Beige;
                //flag = false;
            }
            else
            {
                button1.BackColor = Color.DodgerBlue;
                //flag = true;
            }
            flag = !flag;

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //三元運算式
            button1.BackColor = flag ? Color.Beige : Color.DodgerBlue;
            flag = !flag;
        }

        //轉型
        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            double d = 3.4;
            //i = (int)d;
            i = Convert.ToInt32(d);
            MessageBox.Show(i.ToString());
        }

        // if
        // TryParese
        private void btnGrade_Click(object sender, EventArgs e)
        {
            //90~100 A
            //80~89 B
            //70~79 C
            //60~69 D
            //~59 E

            uint score = 0;
            bool isNum = uint.TryParse(txtScore.Text, out score);
            if (isNum&&score<=100)
            {
                if (score >= 90)
                {
                    labGrade.Text = "A級"; //若只有一行可以不加{}
                }
                else if (score >= 80)
                    labGrade.Text = "B級";
                else if (score >= 70)
                    labGrade.Text = "C級";
                else if (score >= 60)
                    labGrade.Text = "D級";
                else
                    labGrade.Text = "E級";
            }
            else
            {
                MessageBox.Show("請輸入正確數字");
                txtScore.Clear(); //將內容清除
                txtScore.Focus(); //將游標停在該TextBox
            }
        }
        
        // switch
        private void btnSwitch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Is Today Tuesday?", "Question"
                , MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch(result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Correct");
                    break;
                case DialogResult.No:
                    MessageBox.Show("Wrong");
                    break;
                default: //皆不符合以上條件時執行，可以不加就不執行
                    MessageBox.Show("default");
                    break;
            }
        }

        // while
        private void btnWhile_Click(object sender, EventArgs e)
        {
            int i = 0; // i = 10 => 不執行，輸出nothing
            string result = "";

            while(i<=9)
            {
                result += i + "\n";
                i++;               // 如果沒寫i++，會產生無窮迴圈(i一直是0)
            }

            MessageBox.Show(result);
        }
        
        // do
        private void btnDo_Click(object sender, EventArgs e)
        {
            int i = 0; // i = 10 => 輸出10
            string result = "";

            do
            {
                result += i + "\n";
                i++;
            } while (i <= 9);
            
            MessageBox.Show(result);
        }

        // for
        private void btnFor_Click(object sender, EventArgs e)
        {
            string result = "";

            //for(int i = 0; i<=9; i++)
            //{
            //    result += i + "\n";
            //}

            //for(int i = 0; i<=9;  )
            //{
            //    result += i++ + "\n"; //與上列結果相同(但不建議)
            //}

            //for進階，宣告一個以上變數
            for (int i = 0, j = 10, k = 5; i<=j+k; i+=2, k++)
            {
                result += $"i = {i}, j = {j}, k = {k}\n";
            }

            MessageBox.Show(result);

        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach( Control item in this.Controls)
            {
                item.Left -= 10;
                item.Top -= 10;
                item.BackColor = Color.Honeydew;
                item.ForeColor = Color.LightSalmon;
            }
        }
    }
}
