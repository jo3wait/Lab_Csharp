
namespace Lab_Form
{
    partial class Frm_M28
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
            this.btnSwapInt = new System.Windows.Forms.Button();
            this.btnSwapString = new System.Windows.Forms.Button();
            this.btnGenericSwap = new System.Windows.Forms.Button();
            this.btnSwapMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSwapInt
            // 
            this.btnSwapInt.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwapInt.Location = new System.Drawing.Point(94, 85);
            this.btnSwapInt.Name = "btnSwapInt";
            this.btnSwapInt.Size = new System.Drawing.Size(128, 65);
            this.btnSwapInt.TabIndex = 0;
            this.btnSwapInt.Text = "Swap (a, b)";
            this.btnSwapInt.UseVisualStyleBackColor = true;
            this.btnSwapInt.Click += new System.EventHandler(this.btnSwapInt_Click);
            // 
            // btnSwapString
            // 
            this.btnSwapString.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwapString.Location = new System.Drawing.Point(94, 178);
            this.btnSwapString.Name = "btnSwapString";
            this.btnSwapString.Size = new System.Drawing.Size(128, 65);
            this.btnSwapString.TabIndex = 1;
            this.btnSwapString.Text = "Swap (string a, string b)";
            this.btnSwapString.UseVisualStyleBackColor = true;
            this.btnSwapString.Click += new System.EventHandler(this.btnSwapString_Click);
            // 
            // btnGenericSwap
            // 
            this.btnGenericSwap.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGenericSwap.Location = new System.Drawing.Point(282, 85);
            this.btnGenericSwap.Name = "btnGenericSwap";
            this.btnGenericSwap.Size = new System.Drawing.Size(128, 65);
            this.btnGenericSwap.TabIndex = 2;
            this.btnGenericSwap.Text = "Generic Swap";
            this.btnGenericSwap.UseVisualStyleBackColor = true;
            this.btnGenericSwap.Click += new System.EventHandler(this.btnGenericSwap_Click);
            // 
            // btnSwapMember
            // 
            this.btnSwapMember.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwapMember.Location = new System.Drawing.Point(94, 266);
            this.btnSwapMember.Name = "btnSwapMember";
            this.btnSwapMember.Size = new System.Drawing.Size(128, 65);
            this.btnSwapMember.TabIndex = 3;
            this.btnSwapMember.Text = "Swap (Member a, b)";
            this.btnSwapMember.UseVisualStyleBackColor = true;
            this.btnSwapMember.Click += new System.EventHandler(this.btnSwapMember_Click);
            // 
            // Frm_M28
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwapMember);
            this.Controls.Add(this.btnGenericSwap);
            this.Controls.Add(this.btnSwapString);
            this.Controls.Add(this.btnSwapInt);
            this.Name = "Frm_M28";
            this.Text = "Frm_M28";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSwapInt;
        private System.Windows.Forms.Button btnSwapString;
        private System.Windows.Forms.Button btnGenericSwap;
        private System.Windows.Forms.Button btnSwapMember;
    }
}