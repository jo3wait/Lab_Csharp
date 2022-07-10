
namespace Lab_FormHw
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnNotePad = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnStu2 = new System.Windows.Forms.Button();
            this.btnStu1 = new System.Windows.Forms.Button();
            this.btnStuStruc = new System.Windows.Forms.Button();
            this.btnPose = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(33)))), ((int)(((byte)(116)))));
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 561);
            this.splitContainer1.SplitterDistance = 150;
            this.splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "by HUNG, WEI-TING ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "C# HOMEWORK";
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(33)))), ((int)(((byte)(116)))));
            this.splitContainer2.Panel1.Controls.Add(this.btnPaint);
            this.splitContainer2.Panel1.Controls.Add(this.btnGuess);
            this.splitContainer2.Panel1.Controls.Add(this.btnNotePad);
            this.splitContainer2.Panel1.Controls.Add(this.btnCal);
            this.splitContainer2.Panel1.Controls.Add(this.btnStu2);
            this.splitContainer2.Panel1.Controls.Add(this.btnStu1);
            this.splitContainer2.Panel1.Controls.Add(this.btnStuStruc);
            this.splitContainer2.Panel1.Controls.Add(this.btnPose);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(33)))), ((int)(((byte)(116)))));
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer2.Size = new System.Drawing.Size(884, 407);
            this.splitContainer2.SplitterDistance = 198;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnPaint.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPaint.ForeColor = System.Drawing.Color.Black;
            this.btnPaint.Location = new System.Drawing.Point(14, 281);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(150, 28);
            this.btnPaint.TabIndex = 9;
            this.btnPaint.Text = "Paint";
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.ForeColor = System.Drawing.Color.Black;
            this.btnGuess.Location = new System.Drawing.Point(14, 247);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(150, 28);
            this.btnGuess.TabIndex = 8;
            this.btnGuess.Text = "Guess Number";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnNotePad
            // 
            this.btnNotePad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnNotePad.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNotePad.ForeColor = System.Drawing.Color.Black;
            this.btnNotePad.Location = new System.Drawing.Point(14, 315);
            this.btnNotePad.Name = "btnNotePad";
            this.btnNotePad.Size = new System.Drawing.Size(150, 28);
            this.btnNotePad.TabIndex = 7;
            this.btnNotePad.Text = "Notepad";
            this.btnNotePad.UseVisualStyleBackColor = false;
            this.btnNotePad.Click += new System.EventHandler(this.btnNotePad_Click);
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCal.ForeColor = System.Drawing.Color.Black;
            this.btnCal.Location = new System.Drawing.Point(14, 213);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(150, 28);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "Calculator";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnStu2
            // 
            this.btnStu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnStu2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStu2.ForeColor = System.Drawing.Color.Black;
            this.btnStu2.Location = new System.Drawing.Point(14, 179);
            this.btnStu2.Name = "btnStu2";
            this.btnStu2.Size = new System.Drawing.Size(150, 28);
            this.btnStu2.TabIndex = 5;
            this.btnStu2.Text = "Student Grade 2";
            this.btnStu2.UseVisualStyleBackColor = false;
            this.btnStu2.Click += new System.EventHandler(this.btnStu2_Click);
            // 
            // btnStu1
            // 
            this.btnStu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnStu1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStu1.ForeColor = System.Drawing.Color.Black;
            this.btnStu1.Location = new System.Drawing.Point(14, 145);
            this.btnStu1.Name = "btnStu1";
            this.btnStu1.Size = new System.Drawing.Size(150, 28);
            this.btnStu1.TabIndex = 4;
            this.btnStu1.Text = "Student Grade 1";
            this.btnStu1.UseVisualStyleBackColor = false;
            this.btnStu1.Click += new System.EventHandler(this.btnStu1_Click);
            // 
            // btnStuStruc
            // 
            this.btnStuStruc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnStuStruc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStuStruc.ForeColor = System.Drawing.Color.Black;
            this.btnStuStruc.Location = new System.Drawing.Point(14, 111);
            this.btnStuStruc.Name = "btnStuStruc";
            this.btnStuStruc.Size = new System.Drawing.Size(150, 28);
            this.btnStuStruc.TabIndex = 3;
            this.btnStuStruc.Text = "Student Struct";
            this.btnStuStruc.UseVisualStyleBackColor = false;
            this.btnStuStruc.Click += new System.EventHandler(this.btnStuStruc_Click);
            // 
            // btnPose
            // 
            this.btnPose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnPose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPose.ForeColor = System.Drawing.Color.Black;
            this.btnPose.Location = new System.Drawing.Point(14, 77);
            this.btnPose.Name = "btnPose";
            this.btnPose.Size = new System.Drawing.Size(150, 28);
            this.btnPose.TabIndex = 2;
            this.btnPose.Text = "Pose";
            this.btnPose.UseVisualStyleBackColor = false;
            this.btnPose.Click += new System.EventHandler(this.btnPose_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoan.ForeColor = System.Drawing.Color.Black;
            this.btnLoan.Location = new System.Drawing.Point(14, 43);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(150, 28);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(218)))), ((int)(((byte)(106)))));
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.ForeColor = System.Drawing.Color.Black;
            this.btnHello.Location = new System.Drawing.Point(14, 11);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(150, 28);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hi";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Hung, Wei Ting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.Button btnStu2;
        private System.Windows.Forms.Button btnStu1;
        private System.Windows.Forms.Button btnStuStruc;
        private System.Windows.Forms.Button btnPose;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnNotePad;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

