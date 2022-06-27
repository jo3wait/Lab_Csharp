
namespace Lab_FormHw
{
    partial class Frm_StudentGrade
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
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.btnAvr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labShow = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(105, 182);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(142, 29);
            this.txtMath.TabIndex = 15;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(105, 138);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(142, 29);
            this.txtEng.TabIndex = 14;
            this.txtEng.Text = "0";
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(105, 90);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(142, 29);
            this.txtChi.TabIndex = 13;
            this.txtChi.Text = "0";
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(105, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(142, 29);
            this.txtName.TabIndex = 12;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(42, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "數學: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "英文: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(42, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "國文: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名: ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(46, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 28);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddRandom.Location = new System.Drawing.Point(46, 264);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(201, 28);
            this.btnAddRandom.TabIndex = 17;
            this.btnAddRandom.Text = "隨機儲存資料";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            this.btnAddRandom.Click += new System.EventHandler(this.btnAddRandom_Click);
            // 
            // btnAvr
            // 
            this.btnAvr.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAvr.Location = new System.Drawing.Point(46, 298);
            this.btnAvr.Name = "btnAvr";
            this.btnAvr.Size = new System.Drawing.Size(201, 28);
            this.btnAvr.TabIndex = 18;
            this.btnAvr.Text = "各科統計";
            this.btnAvr.UseVisualStyleBackColor = true;
            this.btnAvr.Click += new System.EventHandler(this.btnAvr_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(46, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "重設所有資料";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(46, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "隨機加入20筆";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(325, 60);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(11, 12);
            this.labShow.TabIndex = 21;
            this.labShow.Text = "|";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(325, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(343, 118);
            this.label6.TabIndex = 22;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(323, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(345, 246);
            this.label7.TabIndex = 23;
            this.label7.Text = "姓名      國文  英文  數學  總分  平均   最高    最低    ";
            // 
            // Frm_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAvr);
            this.Controls.Add(this.btnAddRandom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_StudentGrade";
            this.Text = "Frm_StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.Button btnAvr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}