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
    public partial class Frm_Paint : Form
    {
        public Frm_Paint()
        {
            InitializeComponent();
            //https://www.codeproject.com/Tips/811495/Simple-Paint-Application-in-Csharp
            //https://www.youtube.com/watch?v=m7Ohm52TIhw
            //https://www.youtube.com/watch?v=cHncA_aCVmM

            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gra = Graphics.FromImage(bm);
            gra.Clear(Color.White);
            pictureBox1.Image = bm;
            //gra = pictureBox1.CreateGraphics();

        }

        Bitmap bm;
        Graphics gra;
        bool paint = false;
        Point px, py;
        //float size = 1;
        //Pen pen = new Pen(Color.Black, 1);  //index=1
        //Pen erase = new Pen(Color.White, 10);  //index=2
        int index = 1;

        //ColorDialog cd = new ColorDialog();
        //Color new_color;

        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
        }
             
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            
             

            if (paint)
            {
                if (index == 1)
                {
                    Pen pen = new Pen(btnColorPic.BackColor, trackBarSize.Value); 
                    //float.Parse(txtPenSize.Text)
                    px = e.Location;
                    gra.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    Pen erase = new Pen(pictureBox1.BackColor, 10);
                    px = e.Location;
                    gra.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh(); 
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            index = 1;
            //size = float.Parse(txtPenSize.Text);
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            gra.Clear(Color.White);
            pictureBox1.Image = bm;
            index = 0;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog(); 
            cd.ShowDialog();
            //new_color = cd.Color;
            btnColorPic.BackColor = cd.Color;
        }
              
        private void txtPenSize_TextChanged(object sender, EventArgs e)
        {
            trackBarSize.Value = int.Parse(txtPenSize.Text);
            //labSize.Text = txtPenSize.Text;
        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            //labSize.Text = trackBarSize.Value.ToString();
            txtPenSize.Text = trackBarSize.Value.ToString();
        }

        

        



    }
}
