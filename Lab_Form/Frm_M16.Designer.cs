
namespace Lab_Form
{
    partial class Frm_M16
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
            this.btn_byValueType = new System.Windows.Forms.Button();
            this.btn_byReferenceType = new System.Windows.Forms.Button();
            this.btn_byref = new System.Windows.Forms.Button();
            this.btn_byout = new System.Windows.Forms.Button();
            this.btn_byParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_byValueType
            // 
            this.btn_byValueType.Location = new System.Drawing.Point(90, 51);
            this.btn_byValueType.Name = "btn_byValueType";
            this.btn_byValueType.Size = new System.Drawing.Size(126, 60);
            this.btn_byValueType.TabIndex = 0;
            this.btn_byValueType.Text = "by Value Type";
            this.btn_byValueType.UseVisualStyleBackColor = true;
            this.btn_byValueType.Click += new System.EventHandler(this.btn_byValueType_Click);
            // 
            // btn_byReferenceType
            // 
            this.btn_byReferenceType.Location = new System.Drawing.Point(90, 117);
            this.btn_byReferenceType.Name = "btn_byReferenceType";
            this.btn_byReferenceType.Size = new System.Drawing.Size(126, 60);
            this.btn_byReferenceType.TabIndex = 1;
            this.btn_byReferenceType.Text = "by Reference Type";
            this.btn_byReferenceType.UseVisualStyleBackColor = true;
            this.btn_byReferenceType.Click += new System.EventHandler(this.btn_byReferenceType_Click);
            // 
            // btn_byref
            // 
            this.btn_byref.Location = new System.Drawing.Point(90, 183);
            this.btn_byref.Name = "btn_byref";
            this.btn_byref.Size = new System.Drawing.Size(126, 60);
            this.btn_byref.TabIndex = 2;
            this.btn_byref.Text = "by ref";
            this.btn_byref.UseVisualStyleBackColor = true;
            this.btn_byref.Click += new System.EventHandler(this.btn_byref_Click);
            // 
            // btn_byout
            // 
            this.btn_byout.Location = new System.Drawing.Point(90, 249);
            this.btn_byout.Name = "btn_byout";
            this.btn_byout.Size = new System.Drawing.Size(126, 60);
            this.btn_byout.TabIndex = 3;
            this.btn_byout.Text = "by out";
            this.btn_byout.UseVisualStyleBackColor = true;
            this.btn_byout.Click += new System.EventHandler(this.btn_byout_Click);
            // 
            // btn_byParams
            // 
            this.btn_byParams.Location = new System.Drawing.Point(90, 315);
            this.btn_byParams.Name = "btn_byParams";
            this.btn_byParams.Size = new System.Drawing.Size(126, 60);
            this.btn_byParams.TabIndex = 4;
            this.btn_byParams.Text = "by Params";
            this.btn_byParams.UseVisualStyleBackColor = true;
            this.btn_byParams.Click += new System.EventHandler(this.btn_byParams_Click);
            // 
            // Frm_M16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_byParams);
            this.Controls.Add(this.btn_byout);
            this.Controls.Add(this.btn_byref);
            this.Controls.Add(this.btn_byReferenceType);
            this.Controls.Add(this.btn_byValueType);
            this.Name = "Frm_M16";
            this.Text = "Frm_M16";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_byValueType;
        private System.Windows.Forms.Button btn_byReferenceType;
        private System.Windows.Forms.Button btn_byref;
        private System.Windows.Forms.Button btn_byout;
        private System.Windows.Forms.Button btn_byParams;
    }
}