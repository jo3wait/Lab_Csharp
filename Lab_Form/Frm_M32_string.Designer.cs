
namespace Lab_Form
{
    partial class Frm_M32_string
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
            this.components = new System.ComponentModel.Container();
            this.btnString = new System.Windows.Forms.Button();
            this.btnStringBuilder = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labPassword = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.btnCertify = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStringUSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(78, 76);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(121, 51);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "string";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnStringBuilder
            // 
            this.btnStringBuilder.Location = new System.Drawing.Point(78, 158);
            this.btnStringBuilder.Name = "btnStringBuilder";
            this.btnStringBuilder.Size = new System.Drawing.Size(121, 51);
            this.btnStringBuilder.TabIndex = 1;
            this.btnStringBuilder.Text = "StringBuilder";
            this.btnStringBuilder.UseVisualStyleBackColor = true;
            this.btnStringBuilder.Click += new System.EventHandler(this.btnStringBuilder_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(78, 237);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(121, 51);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "密碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "身分證字號";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(389, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(142, 22);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(389, 158);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(142, 22);
            this.txtID.TabIndex = 6;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // labPassword
            // 
            this.labPassword.AutoSize = true;
            this.labPassword.Location = new System.Drawing.Point(553, 115);
            this.labPassword.Name = "labPassword";
            this.labPassword.Size = new System.Drawing.Size(53, 12);
            this.labPassword.TabIndex = 7;
            this.labPassword.Text = "密碼強度";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(553, 168);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(53, 12);
            this.labID.TabIndex = 8;
            this.labID.Text = "格式驗證";
            // 
            // btnCertify
            // 
            this.btnCertify.Location = new System.Drawing.Point(412, 220);
            this.btnCertify.Name = "btnCertify";
            this.btnCertify.Size = new System.Drawing.Size(118, 35);
            this.btnCertify.TabIndex = 9;
            this.btnCertify.Text = "驗證";
            this.btnCertify.UseVisualStyleBackColor = true;
            this.btnCertify.Click += new System.EventHandler(this.btnCertify_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStringUSe
            // 
            this.btnStringUSe.Location = new System.Drawing.Point(78, 318);
            this.btnStringUSe.Name = "btnStringUSe";
            this.btnStringUSe.Size = new System.Drawing.Size(121, 51);
            this.btnStringUSe.TabIndex = 10;
            this.btnStringUSe.Text = "string屬性";
            this.btnStringUSe.UseVisualStyleBackColor = true;
            this.btnStringUSe.Click += new System.EventHandler(this.btnStringUSe_Click);
            // 
            // Frm_M32_string
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStringUSe);
            this.Controls.Add(this.btnCertify);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.labPassword);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnStringBuilder);
            this.Controls.Add(this.btnString);
            this.Name = "Frm_M32_string";
            this.Text = "Frm_M32_string";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnStringBuilder;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labPassword;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Button btnCertify;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStringUSe;
    }
}