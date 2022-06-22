
namespace Lab_Form
{
    partial class Frm_M07
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
            this.btn_M07_member = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegister01 = new System.Windows.Forms.Button();
            this.btnRegister02 = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbDiscount = new System.Windows.Forms.ComboBox();
            this.SetProperty = new System.Windows.Forms.Button();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.btnDiaRes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_M07_member
            // 
            this.btn_M07_member.Location = new System.Drawing.Point(12, 51);
            this.btn_M07_member.Name = "btn_M07_member";
            this.btn_M07_member.Size = new System.Drawing.Size(122, 57);
            this.btn_M07_member.TabIndex = 0;
            this.btn_M07_member.Text = "物件初始化";
            this.btn_M07_member.UseVisualStyleBackColor = true;
            this.btn_M07_member.Click += new System.EventHandler(this.btn_M07_member_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(181, 51);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(122, 57);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "註冊事件";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegister01
            // 
            this.btnRegister01.Location = new System.Drawing.Point(181, 144);
            this.btnRegister01.Name = "btnRegister01";
            this.btnRegister01.Size = new System.Drawing.Size(122, 57);
            this.btnRegister01.TabIndex = 2;
            this.btnRegister01.Text = "Register01";
            this.btnRegister01.UseVisualStyleBackColor = true;
            // 
            // btnRegister02
            // 
            this.btnRegister02.Location = new System.Drawing.Point(181, 227);
            this.btnRegister02.Name = "btnRegister02";
            this.btnRegister02.Size = new System.Drawing.Size(122, 57);
            this.btnRegister02.TabIndex = 3;
            this.btnRegister02.Text = "Register02";
            this.btnRegister02.UseVisualStyleBackColor = true;
            // 
            // btnDis
            // 
            this.btnDis.Location = new System.Drawing.Point(181, 323);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(122, 57);
            this.btnDis.TabIndex = 4;
            this.btnDis.Text = "解除註冊";
            this.btnDis.UseVisualStyleBackColor = true;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Location = new System.Drawing.Point(356, 156);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(121, 23);
            this.btnDiscount.TabIndex = 5;
            this.btnDiscount.Text = "計算價格";
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(356, 51);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 6;
            // 
            // cmbDiscount
            // 
            this.cmbDiscount.FormattingEnabled = true;
            this.cmbDiscount.Items.AddRange(new object[] {
            "50%off",
            "20%off"});
            this.cmbDiscount.Location = new System.Drawing.Point(356, 104);
            this.cmbDiscount.Name = "cmbDiscount";
            this.cmbDiscount.Size = new System.Drawing.Size(121, 20);
            this.cmbDiscount.TabIndex = 7;
            // 
            // SetProperty
            // 
            this.SetProperty.Location = new System.Drawing.Point(535, 51);
            this.SetProperty.Name = "SetProperty";
            this.SetProperty.Size = new System.Drawing.Size(122, 57);
            this.SetProperty.TabIndex = 8;
            this.SetProperty.Text = "Set Property";
            this.SetProperty.UseVisualStyleBackColor = true;
            this.SetProperty.Click += new System.EventHandler(this.SetProperty_Click);
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(535, 139);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(122, 57);
            this.btnMsgBox.TabIndex = 9;
            this.btnMsgBox.Text = "Message Box";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.btnMsgBox_Click);
            // 
            // btnDiaRes
            // 
            this.btnDiaRes.Location = new System.Drawing.Point(535, 227);
            this.btnDiaRes.Name = "btnDiaRes";
            this.btnDiaRes.Size = new System.Drawing.Size(122, 57);
            this.btnDiaRes.TabIndex = 10;
            this.btnDiaRes.Text = "Dialog Result";
            this.btnDiaRes.UseVisualStyleBackColor = true;
            this.btnDiaRes.Click += new System.EventHandler(this.btnDiaRes_Click);
            // 
            // Frm_M07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiaRes);
            this.Controls.Add(this.btnMsgBox);
            this.Controls.Add(this.SetProperty);
            this.Controls.Add(this.cmbDiscount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.btnRegister02);
            this.Controls.Add(this.btnRegister01);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btn_M07_member);
            this.Name = "Frm_M07";
            this.Text = "Frm_M07";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_M07_member;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegister01;
        private System.Windows.Forms.Button btnRegister02;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbDiscount;
        private System.Windows.Forms.Button SetProperty;
        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.Button btnDiaRes;
    }
}