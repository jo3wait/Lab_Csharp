
namespace Lab_Form
{
    partial class Frm_M34_ReadWrite
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
            this.btnRead = new System.Windows.Forms.Button();
            this.txtReadWrite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(96, 58);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(103, 56);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtReadWrite
            // 
            this.txtReadWrite.Location = new System.Drawing.Point(280, 34);
            this.txtReadWrite.Multiline = true;
            this.txtReadWrite.Name = "txtReadWrite";
            this.txtReadWrite.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadWrite.Size = new System.Drawing.Size(459, 390);
            this.txtReadWrite.TabIndex = 1;
            // 
            // Frm_M34_ReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReadWrite);
            this.Controls.Add(this.btnRead);
            this.Name = "Frm_M34_ReadWrite";
            this.Text = "Frm_M34_ReadWrite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtReadWrite;
    }
}