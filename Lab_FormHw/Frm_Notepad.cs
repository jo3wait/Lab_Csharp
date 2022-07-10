using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_FormHw
{
    public partial class Frm_Notepad : Form
    {
        public Frm_Notepad()
        {
            InitializeComponent();

            //https://www.youtube.com/watch?v=DqUgnkqsZ9Q
            //https://www.youtube.com/watch?v=N_JYp03FRkY
        }

        OpenFileDialog of = new OpenFileDialog(); 
        SaveFileDialog sf = new SaveFileDialog();

        //File
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text = File.ReadAllText(of.FileName);                    
                    this.Text = of.FileName;

                    //StreamReader sr = new StreamReader(of.FileName);
                    //richTextBox1.Text = sr.ReadToEnd();
                    //sr.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("開啟檔案時發生錯誤");
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sf.DefaultExt = ".txt";
            sf.Filter = "Text File|*.txt";  //|PDF file|*.pdf|Word File|*.doc

            if (sf.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sf.FileName, richTextBox1.Text);
                this.Text = sf.FileName;

                //FileStream fs = new FileStream("TestWrite.txt", FileMode.Create);
                //StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                //sw.Write(richTextBox1.Text);
                //sw.Close();
                //fs.Close();
            }


        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            sf.DefaultExt = ".txt";
            sf.Filter = "Text File|*.txt|PDF file|*.pdf|Word File|*.doc"; 

            if (sf.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sf.FileName, richTextBox1.Text);
                this.Text = sf.FileName;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("關於: 逃げちゃ駄目だ");
        }

        //Edit
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void replayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }


        //Format        
        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            richTextBox1.ForeColor = cd.Color;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowDialog();
            richTextBox1.Font = fd.Font;
        }

        private void toUpperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text.ToUpper();
            richTextBox1.Text = a;
        }

        private void toLowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = richTextBox1.Text.ToLower();
            richTextBox1.Text = a;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.ForeColor = Color.Black;
        }

    }
}
