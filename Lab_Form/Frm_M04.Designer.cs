
using System;

namespace Lab_Form
{
    partial class Frm_M04
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.MyFirsyMethod = new System.Windows.Forms.Button();
            this.Method = new System.Windows.Forms.Button();
            this.Btn_birthyr = new System.Windows.Forms.Button();
            this.btn_Encap = new System.Windows.Forms.Button();
            this.btn_PartialClass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(153, 67);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(120, 43);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // MyFirsyMethod
            // 
            this.MyFirsyMethod.Location = new System.Drawing.Point(153, 142);
            this.MyFirsyMethod.Name = "MyFirsyMethod";
            this.MyFirsyMethod.Size = new System.Drawing.Size(120, 45);
            this.MyFirsyMethod.TabIndex = 1;
            this.MyFirsyMethod.Text = "My First Method";
            this.MyFirsyMethod.UseVisualStyleBackColor = true;
            this.MyFirsyMethod.Click += new System.EventHandler(this.button1_Click);
            // 
            // Method
            // 
            this.Method.Location = new System.Drawing.Point(153, 226);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(120, 45);
            this.Method.TabIndex = 2;
            this.Method.Text = "Method";
            this.Method.UseVisualStyleBackColor = true;
            this.Method.Click += new System.EventHandler(this.Method_Click);
            // 
            // Btn_birthyr
            // 
            this.Btn_birthyr.Location = new System.Drawing.Point(153, 310);
            this.Btn_birthyr.Name = "Btn_birthyr";
            this.Btn_birthyr.Size = new System.Drawing.Size(120, 50);
            this.Btn_birthyr.TabIndex = 3;
            this.Btn_birthyr.Text = "Method Return";
            this.Btn_birthyr.UseVisualStyleBackColor = true;
            this.Btn_birthyr.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_Encap
            // 
            this.btn_Encap.Location = new System.Drawing.Point(468, 67);
            this.btn_Encap.Name = "btn_Encap";
            this.btn_Encap.Size = new System.Drawing.Size(136, 43);
            this.btn_Encap.TabIndex = 4;
            this.btn_Encap.Text = "Encap";
            this.btn_Encap.UseVisualStyleBackColor = true;
            this.btn_Encap.Click += new System.EventHandler(this.btn_Encap_Click);
            // 
            // btn_PartialClass
            // 
            this.btn_PartialClass.Location = new System.Drawing.Point(468, 142);
            this.btn_PartialClass.Name = "btn_PartialClass";
            this.btn_PartialClass.Size = new System.Drawing.Size(136, 45);
            this.btn_PartialClass.TabIndex = 5;
            this.btn_PartialClass.Text = "Method Partial Class";
            this.btn_PartialClass.UseVisualStyleBackColor = true;
            this.btn_PartialClass.Click += new System.EventHandler(this.btn_PartialClass_Click);
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PartialClass);
            this.Controls.Add(this.btn_Encap);
            this.Controls.Add(this.Btn_birthyr);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.MyFirsyMethod);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);

        }

        private void btn_BirthYear_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        public System.Windows.Forms.Button MyFirsyMethod;
        public System.Windows.Forms.Button Method;
        public System.Windows.Forms.Button Btn_birthyr;
        private System.Windows.Forms.Button btn_Encap;
        public System.Windows.Forms.Button btn_PartialClass;
    }
}