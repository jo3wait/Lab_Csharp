
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnNotePad = new System.Windows.Forms.Button();
            this.btnCal = new System.Windows.Forms.Button();
            this.btnStu2 = new System.Windows.Forms.Button();
            this.btnStu1 = new System.Windows.Forms.Button();
            this.btnStuStruc = new System.Windows.Forms.Button();
            this.btnPose = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
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
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 561);
            this.splitContainer1.SplitterDistance = 151;
            this.splitContainer1.TabIndex = 0;
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
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.splitContainer2.Panel1.Controls.Add(this.btnNotePad);
            this.splitContainer2.Panel1.Controls.Add(this.btnCal);
            this.splitContainer2.Panel1.Controls.Add(this.btnStu2);
            this.splitContainer2.Panel1.Controls.Add(this.btnStu1);
            this.splitContainer2.Panel1.Controls.Add(this.btnStuStruc);
            this.splitContainer2.Panel1.Controls.Add(this.btnPose);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnHello);
            this.splitContainer2.Size = new System.Drawing.Size(884, 406);
            this.splitContainer2.SplitterDistance = 199;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnNotePad
            // 
            this.btnNotePad.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNotePad.Location = new System.Drawing.Point(12, 238);
            this.btnNotePad.Name = "btnNotePad";
            this.btnNotePad.Size = new System.Drawing.Size(152, 26);
            this.btnNotePad.TabIndex = 7;
            this.btnNotePad.Text = "Notepad";
            this.btnNotePad.UseVisualStyleBackColor = true;
            this.btnNotePad.Click += new System.EventHandler(this.btnNotePad_Click);
            // 
            // btnCal
            // 
            this.btnCal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCal.Location = new System.Drawing.Point(12, 206);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(152, 26);
            this.btnCal.TabIndex = 6;
            this.btnCal.Text = "Calculator";
            this.btnCal.UseVisualStyleBackColor = true;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // btnStu2
            // 
            this.btnStu2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStu2.Location = new System.Drawing.Point(12, 174);
            this.btnStu2.Name = "btnStu2";
            this.btnStu2.Size = new System.Drawing.Size(152, 26);
            this.btnStu2.TabIndex = 5;
            this.btnStu2.Text = "Student Grade 2";
            this.btnStu2.UseVisualStyleBackColor = true;
            this.btnStu2.Click += new System.EventHandler(this.btnStu2_Click);
            // 
            // btnStu1
            // 
            this.btnStu1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStu1.Location = new System.Drawing.Point(12, 142);
            this.btnStu1.Name = "btnStu1";
            this.btnStu1.Size = new System.Drawing.Size(152, 26);
            this.btnStu1.TabIndex = 4;
            this.btnStu1.Text = "Student Grade 1";
            this.btnStu1.UseVisualStyleBackColor = true;
            this.btnStu1.Click += new System.EventHandler(this.btnStu1_Click);
            // 
            // btnStuStruc
            // 
            this.btnStuStruc.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStuStruc.Location = new System.Drawing.Point(12, 110);
            this.btnStuStruc.Name = "btnStuStruc";
            this.btnStuStruc.Size = new System.Drawing.Size(152, 26);
            this.btnStuStruc.TabIndex = 3;
            this.btnStuStruc.Text = "Student Struct";
            this.btnStuStruc.UseVisualStyleBackColor = true;
            this.btnStuStruc.Click += new System.EventHandler(this.btnStuStruc_Click);
            // 
            // btnPose
            // 
            this.btnPose.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPose.Location = new System.Drawing.Point(12, 78);
            this.btnPose.Name = "btnPose";
            this.btnPose.Size = new System.Drawing.Size(152, 26);
            this.btnPose.TabIndex = 2;
            this.btnPose.Text = "Pose";
            this.btnPose.UseVisualStyleBackColor = true;
            this.btnPose.Click += new System.EventHandler(this.btnPose_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLoan.Location = new System.Drawing.Point(12, 46);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(152, 26);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(12, 14);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(152, 26);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Say Hi";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

