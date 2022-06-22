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
    public partial class Frm_M26_array : Form
    {
        public Frm_M26_array()
        {
            InitializeComponent();
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 2;
            //arr[2] = 3;
            ////arr[3] = 4; //Error: out of range

            //int[] arr = new int[3] { 1, 2, 3 };
            //int[] arr = { 1, 2, 3 };

            //MessageBox.Show(arr[2].ToString());

            int[] arr = new int[3];
            string result = "";
            for (int i = 0; i <3; i++)
            {
                arr[i] = 1+i;
                result += arr[i]+", ";            
            }
            MessageBox.Show(result);
        }
    }
}
