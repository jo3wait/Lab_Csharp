
namespace Lab_FormHw
{
    partial class Frm_Pose
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProduct4 = new System.Windows.Forms.Button();
            this.btnProduct3 = new System.Windows.Forms.Button();
            this.btnProduct2 = new System.Windows.Forms.Button();
            this.btnProduct1 = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.GroupBox();
            this.labTotal = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.GroupBox();
            this.labCredit = new System.Windows.Forms.Label();
            this.btnCredit = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labList = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.TotalPrice.SuspendLayout();
            this.pay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnProduct4);
            this.groupBox1.Controls.Add(this.btnProduct3);
            this.groupBox1.Controls.Add(this.btnProduct2);
            this.groupBox1.Controls.Add(this.btnProduct1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // btnProduct4
            // 
            this.btnProduct4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct4.Location = new System.Drawing.Point(147, 202);
            this.btnProduct4.Name = "btnProduct4";
            this.btnProduct4.Size = new System.Drawing.Size(81, 104);
            this.btnProduct4.TabIndex = 3;
            this.btnProduct4.Text = "紅酒 Wine NT$320";
            this.btnProduct4.UseVisualStyleBackColor = false;
            this.btnProduct4.Click += new System.EventHandler(this.btnProduct4_Click);
            // 
            // btnProduct3
            // 
            this.btnProduct3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct3.Location = new System.Drawing.Point(47, 202);
            this.btnProduct3.Name = "btnProduct3";
            this.btnProduct3.Size = new System.Drawing.Size(81, 104);
            this.btnProduct3.TabIndex = 2;
            this.btnProduct3.Text = "威士忌 Whisky NT$ 350";
            this.btnProduct3.UseVisualStyleBackColor = false;
            this.btnProduct3.Click += new System.EventHandler(this.btnProduct3_Click);
            // 
            // btnProduct2
            // 
            this.btnProduct2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct2.Location = new System.Drawing.Point(147, 63);
            this.btnProduct2.Name = "btnProduct2";
            this.btnProduct2.Size = new System.Drawing.Size(81, 104);
            this.btnProduct2.TabIndex = 1;
            this.btnProduct2.Text = "龍舌蘭Tequila NT$180";
            this.btnProduct2.UseVisualStyleBackColor = false;
            this.btnProduct2.Click += new System.EventHandler(this.btnProduct2_Click);
            // 
            // btnProduct1
            // 
            this.btnProduct1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct1.Location = new System.Drawing.Point(47, 63);
            this.btnProduct1.Name = "btnProduct1";
            this.btnProduct1.Size = new System.Drawing.Size(81, 104);
            this.btnProduct1.TabIndex = 0;
            this.btnProduct1.Text = "啤酒 Beer NT$120";
            this.btnProduct1.UseVisualStyleBackColor = false;
            this.btnProduct1.Click += new System.EventHandler(this.btnProduct1_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.Controls.Add(this.labTotal);
            this.TotalPrice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TotalPrice.Location = new System.Drawing.Point(296, 63);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(204, 99);
            this.TotalPrice.TabIndex = 1;
            this.TotalPrice.TabStop = false;
            this.TotalPrice.Text = "總金額";
            // 
            // labTotal
            // 
            this.labTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labTotal.Location = new System.Drawing.Point(69, 38);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(129, 37);
            this.labTotal.TabIndex = 0;
            this.labTotal.Text = "NT$ 0";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pay
            // 
            this.pay.Controls.Add(this.labCredit);
            this.pay.Controls.Add(this.btnCredit);
            this.pay.Controls.Add(this.btnCash);
            this.pay.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pay.Location = new System.Drawing.Point(296, 168);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(204, 159);
            this.pay.TabIndex = 2;
            this.pay.TabStop = false;
            this.pay.Text = "付款方式";
            // 
            // labCredit
            // 
            this.labCredit.AutoSize = true;
            this.labCredit.Location = new System.Drawing.Point(64, 98);
            this.labCredit.Name = "labCredit";
            this.labCredit.Size = new System.Drawing.Size(130, 20);
            this.labCredit.TabIndex = 2;
            this.labCredit.Text = "信用卡享9折優惠";
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(106, 45);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(88, 37);
            this.btnCredit.TabIndex = 1;
            this.btnCredit.Text = "信用卡";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(12, 45);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(88, 37);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.labList);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(516, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 339);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "購物清單List";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(166, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清除清單";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labList
            // 
            this.labList.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Location = new System.Drawing.Point(6, 25);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(248, 264);
            this.labList.TabIndex = 0;
            this.labList.Text = "尚未點餐";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frm_Pose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Pose";
            this.Text = "Bar Pose";
            this.groupBox1.ResumeLayout(false);
            this.TotalPrice.ResumeLayout(false);
            this.pay.ResumeLayout(false);
            this.pay.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProduct1;
        private System.Windows.Forms.Button btnProduct4;
        private System.Windows.Forms.Button btnProduct3;
        private System.Windows.Forms.Button btnProduct2;
        private System.Windows.Forms.GroupBox TotalPrice;
        private System.Windows.Forms.GroupBox pay;
        private System.Windows.Forms.Label labCredit;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labList;
    }
}