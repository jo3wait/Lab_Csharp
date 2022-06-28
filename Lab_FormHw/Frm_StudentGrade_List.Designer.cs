
namespace Lab_FormHw
{
    partial class Frm_StudentGrade_List
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labShow = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labSum = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSum = new System.Windows.Forms.Button();
            this.txtBot = new System.Windows.Forms.TextBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveLast = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labShow);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(495, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 386);
            this.panel1.TabIndex = 39;
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShow.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(14, 46);
            this.labShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(2, 20);
            this.labShow.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(20, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(550, 360);
            this.label7.TabIndex = 23;
            this.label7.Text = "姓名    國文  英文  數學  總分  平均    最高      最低    ";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(132, 628);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(302, 42);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(132, 489);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(302, 42);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "清除所有資料";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labSum
            // 
            this.labSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labSum.Font = new System.Drawing.Font("標楷體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSum.Location = new System.Drawing.Point(495, 462);
            this.labSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSum.Name = "labSum";
            this.labSum.Size = new System.Drawing.Size(580, 153);
            this.labSum.TabIndex = 38;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(132, 438);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(146, 42);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "移除第一筆";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(132, 387);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(302, 42);
            this.btnInsert.TabIndex = 34;
            this.btnInsert.Text = "插入學生資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(132, 336);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(302, 42);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(220, 264);
            this.txtMath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(211, 39);
            this.txtMath.TabIndex = 32;
            this.txtMath.Text = "0";
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEng.Location = new System.Drawing.Point(220, 198);
            this.txtEng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(211, 39);
            this.txtEng.TabIndex = 31;
            this.txtEng.Text = "0";
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChi.Location = new System.Drawing.Point(220, 126);
            this.txtChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(211, 39);
            this.txtChi.TabIndex = 30;
            this.txtChi.Text = "0";
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(220, 60);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 39);
            this.txtName.TabIndex = 29;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(126, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "數學: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(126, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 30);
            this.label3.TabIndex = 27;
            this.label3.Text = "英文: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(126, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "國文: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(126, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 25;
            this.label1.Text = "姓名: ";
            // 
            // btnSum
            // 
            this.btnSum.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSum.Location = new System.Drawing.Point(774, 628);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(302, 42);
            this.btnSum.TabIndex = 40;
            this.btnSum.Text = "各科統計";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // txtBot
            // 
            this.txtBot.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBot.Location = new System.Drawing.Point(156, 572);
            this.txtBot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBot.Name = "txtBot";
            this.txtBot.Size = new System.Drawing.Size(104, 39);
            this.txtBot.TabIndex = 41;
            this.txtBot.Text = "0";
            this.txtBot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTop
            // 
            this.txtTop.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTop.Location = new System.Drawing.Point(304, 572);
            this.txtTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(104, 39);
            this.txtTop.TabIndex = 42;
            this.txtTop.Text = "100";
            this.txtTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(182, 536);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 30);
            this.label5.TabIndex = 43;
            this.label5.Text = "搜尋國文成績範圍";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(272, 576);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 30);
            this.label6.TabIndex = 44;
            this.label6.Text = "-";
            // 
            // btnRemoveLast
            // 
            this.btnRemoveLast.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveLast.Location = new System.Drawing.Point(288, 438);
            this.btnRemoveLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveLast.Name = "btnRemoveLast";
            this.btnRemoveLast.Size = new System.Drawing.Size(146, 42);
            this.btnRemoveLast.TabIndex = 45;
            this.btnRemoveLast.Text = "移除最後";
            this.btnRemoveLast.UseVisualStyleBackColor = true;
            this.btnRemoveLast.Click += new System.EventHandler(this.btnRemoveLast_Click);
            // 
            // Frm_StudentGrade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 702);
            this.Controls.Add(this.btnRemoveLast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.txtBot);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labSum);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_StudentGrade_List";
            this.Text = "Frm_StudentGrade_List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labSum;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtBot;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemoveLast;
    }
}