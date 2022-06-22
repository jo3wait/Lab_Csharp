
namespace Lab_Form
{
    partial class Frm_M18_enum
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCertify = new System.Windows.Forms.Button();
            this.btnConst = new System.Windows.Forms.Button();
            this.btnEnum = new System.Windows.Forms.Button();
            this.btnEnumCase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnProduct.Enabled = false;
            this.btnProduct.Location = new System.Drawing.Point(249, 39);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(139, 62);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCertify
            // 
            this.btnCertify.Location = new System.Drawing.Point(45, 39);
            this.btnCertify.Name = "btnCertify";
            this.btnCertify.Size = new System.Drawing.Size(139, 62);
            this.btnCertify.TabIndex = 1;
            this.btnCertify.Text = "Certify";
            this.btnCertify.UseVisualStyleBackColor = true;
            this.btnCertify.Click += new System.EventHandler(this.btnCertify_Click);
            // 
            // btnConst
            // 
            this.btnConst.Location = new System.Drawing.Point(45, 107);
            this.btnConst.Name = "btnConst";
            this.btnConst.Size = new System.Drawing.Size(139, 62);
            this.btnConst.TabIndex = 2;
            this.btnConst.Text = "Certify - const";
            this.btnConst.UseVisualStyleBackColor = true;
            this.btnConst.Click += new System.EventHandler(this.btnConst_Click);
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(45, 175);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(139, 62);
            this.btnEnum.TabIndex = 3;
            this.btnEnum.Text = "Certify - enum";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // btnEnumCase
            // 
            this.btnEnumCase.Location = new System.Drawing.Point(45, 243);
            this.btnEnumCase.Name = "btnEnumCase";
            this.btnEnumCase.Size = new System.Drawing.Size(139, 62);
            this.btnEnumCase.TabIndex = 4;
            this.btnEnumCase.Text = "Certify - enum - case";
            this.btnEnumCase.UseVisualStyleBackColor = true;
            this.btnEnumCase.Click += new System.EventHandler(this.btnEnumCase_Click);
            // 
            // Frm_M18_enum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnumCase);
            this.Controls.Add(this.btnEnum);
            this.Controls.Add(this.btnConst);
            this.Controls.Add(this.btnCertify);
            this.Controls.Add(this.btnProduct);
            this.Name = "Frm_M18_enum";
            this.Text = "Frm_M18_enum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCertify;
        private System.Windows.Forms.Button btnConst;
        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Button btnEnumCase;
    }
}