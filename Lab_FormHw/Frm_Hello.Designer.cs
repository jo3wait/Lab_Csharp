
namespace Lab_FormHw
{
    partial class Frm_Hello
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
            this.labNameChi = new System.Windows.Forms.Label();
            this.txtNameChi = new System.Windows.Forms.TextBox();
            this.btnHello = new System.Windows.Forms.Button();
            this.txtNameEng = new System.Windows.Forms.TextBox();
            this.labNameEng = new System.Windows.Forms.Label();
            this.txtCtl = new System.Windows.Forms.TextBox();
            this.labCtl = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.labSex = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labNameChi
            // 
            this.labNameChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameChi.Location = new System.Drawing.Point(137, 112);
            this.labNameChi.Name = "labNameChi";
            this.labNameChi.Size = new System.Drawing.Size(100, 23);
            this.labNameChi.TabIndex = 0;
            this.labNameChi.Text = "姓名: ";
            // 
            // txtNameChi
            // 
            this.txtNameChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNameChi.Location = new System.Drawing.Point(256, 109);
            this.txtNameChi.Name = "txtNameChi";
            this.txtNameChi.Size = new System.Drawing.Size(135, 29);
            this.txtNameChi.TabIndex = 1;
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(141, 346);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(105, 47);
            this.btnHello.TabIndex = 2;
            this.btnHello.Text = "Say Hello!";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtNameEng
            // 
            this.txtNameEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtNameEng.Location = new System.Drawing.Point(256, 164);
            this.txtNameEng.Name = "txtNameEng";
            this.txtNameEng.Size = new System.Drawing.Size(135, 29);
            this.txtNameEng.TabIndex = 4;
            // 
            // labNameEng
            // 
            this.labNameEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameEng.Location = new System.Drawing.Point(137, 167);
            this.labNameEng.Name = "labNameEng";
            this.labNameEng.Size = new System.Drawing.Size(131, 23);
            this.labNameEng.TabIndex = 3;
            this.labNameEng.Text = "English Name: ";
            // 
            // txtCtl
            // 
            this.txtCtl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCtl.Location = new System.Drawing.Point(256, 217);
            this.txtCtl.Name = "txtCtl";
            this.txtCtl.Size = new System.Drawing.Size(135, 29);
            this.txtCtl.TabIndex = 6;
            // 
            // labCtl
            // 
            this.labCtl.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCtl.Location = new System.Drawing.Point(137, 220);
            this.labCtl.Name = "labCtl";
            this.labCtl.Size = new System.Drawing.Size(131, 23);
            this.labCtl.TabIndex = 5;
            this.labCtl.Text = "星座: ";
            // 
            // txtSex
            // 
            this.txtSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSex.Location = new System.Drawing.Point(256, 272);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(135, 29);
            this.txtSex.TabIndex = 8;
            // 
            // labSex
            // 
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.Location = new System.Drawing.Point(137, 275);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(131, 23);
            this.labSex.TabIndex = 7;
            this.labSex.Text = "性別: ";
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(286, 346);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(105, 47);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi!";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Frm_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.txtCtl);
            this.Controls.Add(this.labCtl);
            this.Controls.Add(this.txtNameEng);
            this.Controls.Add(this.labNameEng);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtNameChi);
            this.Controls.Add(this.labNameChi);
            this.Name = "Frm_Hello";
            this.Text = "你好! C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNameChi;
        private System.Windows.Forms.TextBox txtNameChi;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtNameEng;
        private System.Windows.Forms.Label labNameEng;
        private System.Windows.Forms.TextBox txtCtl;
        private System.Windows.Forms.Label labCtl;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.Button btnHi;
    }
}