
namespace Lab_FormHw
{
    partial class Frm_Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.labSize = new System.Windows.Forms.Label();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnColorPic = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnColor.Location = new System.Drawing.Point(13, 89);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(50, 46);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Location = new System.Drawing.Point(69, 359);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(11, 12);
            this.labSize.TabIndex = 9;
            this.labSize.Text = "1";
            // 
            // trackBarSize
            // 
            this.trackBarSize.AutoSize = false;
            this.trackBarSize.BackColor = System.Drawing.Color.White;
            this.trackBarSize.Location = new System.Drawing.Point(18, 176);
            this.trackBarSize.Maximum = 100;
            this.trackBarSize.Minimum = 1;
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarSize.Size = new System.Drawing.Size(45, 195);
            this.trackBarSize.TabIndex = 3;
            this.trackBarSize.Value = 1;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pencil Size";
            // 
            // btnPen
            // 
            this.btnPen.BackColor = System.Drawing.Color.White;
            this.btnPen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnPen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPen.Location = new System.Drawing.Point(13, 25);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(50, 46);
            this.btnPen.TabIndex = 5;
            this.btnPen.Text = "Pencil";
            this.btnPen.UseVisualStyleBackColor = false;
            this.btnPen.Click += new System.EventHandler(this.btnPen_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnClear.Location = new System.Drawing.Point(18, 394);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 26);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnErase
            // 
            this.btnErase.BackColor = System.Drawing.Color.White;
            this.btnErase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnErase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnErase.Location = new System.Drawing.Point(67, 25);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(50, 46);
            this.btnErase.TabIndex = 4;
            this.btnErase.Text = "Eraser";
            this.btnErase.UseVisualStyleBackColor = false;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnColorPic
            // 
            this.btnColorPic.BackColor = System.Drawing.Color.Black;
            this.btnColorPic.Location = new System.Drawing.Point(67, 89);
            this.btnColorPic.Name = "btnColorPic";
            this.btnColorPic.Size = new System.Drawing.Size(50, 46);
            this.btnColorPic.TabIndex = 3;
            this.btnColorPic.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labSize);
            this.panel1.Controls.Add(this.trackBarSize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnPen);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnErase);
            this.panel1.Controls.Add(this.btnColorPic);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(671, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 450);
            this.panel1.TabIndex = 2;
            // 
            // Frm_Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_Paint";
            this.Text = "Frm_Paint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnColorPic;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Panel panel1;
    }
}