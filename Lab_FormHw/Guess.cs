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
    public partial class Guess : Form
    {
        public Guess()
        {
            InitializeComponent();
        }

        //要宣告子表單的爸爸是誰 Owner 

        Random rdm = new Random();

        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            

            Frm_Guess ori = new Frm_Guess();
            ori = (Frm_Guess)this.Owner;

            int input;
            bool isNum = int.TryParse(txtInput.Text, out input);

            if (isNum && input <= 100 && input >= 0)
            {
                if (input == Frm_Guess.ans)
                {
                    MessageBox.Show($"Congrats! You got {Frm_Guess.ans}.");
                }

                else if (input < Frm_Guess.ans)
                {
                    Frm_Guess.lstBot.Add(input);
                    ori.labShow.Text = $"Too Small!!\n" +
                        $"Between {Frm_Guess.lstBot[Frm_Guess.lstBot.Count-1]} " +
                        $"to {Frm_Guess.lstTop[Frm_Guess.lstTop.Count - 1]}";                                        
                }
                else
                {
                    Frm_Guess.lstTop.Add(input);
                    ori.labShow.Text = $"Too Large!!\n" +
                        $"Between {Frm_Guess.lstBot[Frm_Guess.lstBot.Count - 1]} " +
                        $"to {Frm_Guess.lstTop[Frm_Guess.lstTop.Count - 1]}";
                }
            }
            else
            {
                MessageBox.Show("請輸入0-100數字");
                txtInput.Clear();
                txtInput.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Visible = false;
        }
    }
}
