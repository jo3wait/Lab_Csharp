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

namespace Lab_Form
{
    public partial class Frm_M34_ReadWrite : Form
    {
        public Frm_M34_ReadWrite()
        {
            InitializeComponent();
        }

        // Read
        private void btnRead_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("../TestRead.txt", Encoding.UTF8);
            //檔案出發點在../Lab_Form/bin/Debug (裡面的exe)
            txtReadWrite.Text = sr.ReadToEnd();
            sr.Close();
        }

        // Write
        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("TestWrite.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(txtReadWrite.Text);
            sw.Close();
            fs.Close();
        }


        // Try Catch
        private void button1_Click(object sender, EventArgs e)
        {
            int[] nums = { 1, 2, 3, 4, 5 };

            try
            {
                string result = "";
                for(int i =0;i<nums.Length;i++)
                {
                    result += nums[i] + "\n";
                    MessageBox.Show(result);

                    if(i>1)
                    {
                        //throw new AccessViolationException();
                        //throw new AccessViolationException("自訂Message");
                        throw new AggregateException();
                    }
                }
            }
            catch(IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(AccessViolationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
