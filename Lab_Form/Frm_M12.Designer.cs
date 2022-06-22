
namespace Lab_Form
{
    partial class Frm_M12
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
            this.labCount = new System.Windows.Forms.Label();
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnMinOne = new System.Windows.Forms.Button();
            this.btnPPCount = new System.Windows.Forms.Button();
            this.btnCountPP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnInstance = new System.Windows.Forms.Button();
            this.labInstance = new System.Windows.Forms.Label();
            this.labStatic = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(54, 78);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(46, 12);
            this.labCount.TabIndex = 0;
            this.labCount.Text = "Count: 0";
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Location = new System.Drawing.Point(56, 138);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(75, 23);
            this.btnPlusOne.TabIndex = 1;
            this.btnPlusOne.Text = "+=";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnMinOne
            // 
            this.btnMinOne.Location = new System.Drawing.Point(56, 197);
            this.btnMinOne.Name = "btnMinOne";
            this.btnMinOne.Size = new System.Drawing.Size(75, 23);
            this.btnMinOne.TabIndex = 2;
            this.btnMinOne.Text = "-=";
            this.btnMinOne.UseVisualStyleBackColor = true;
            this.btnMinOne.Click += new System.EventHandler(this.btnMinOne_Click);
            // 
            // btnPPCount
            // 
            this.btnPPCount.Location = new System.Drawing.Point(56, 248);
            this.btnPPCount.Name = "btnPPCount";
            this.btnPPCount.Size = new System.Drawing.Size(75, 23);
            this.btnPPCount.TabIndex = 3;
            this.btnPPCount.Text = "++count";
            this.btnPPCount.UseVisualStyleBackColor = true;
            this.btnPPCount.Click += new System.EventHandler(this.btnPPCount_Click);
            // 
            // btnCountPP
            // 
            this.btnCountPP.Location = new System.Drawing.Point(56, 300);
            this.btnCountPP.Name = "btnCountPP";
            this.btnCountPP.Size = new System.Drawing.Size(75, 23);
            this.btnCountPP.TabIndex = 4;
            this.btnCountPP.Text = "count++";
            this.btnCountPP.UseVisualStyleBackColor = true;
            this.btnCountPP.Click += new System.EventHandler(this.btnCountPP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(209, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 146);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Variable";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Local Variable";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Variable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStatic);
            this.groupBox2.Controls.Add(this.btnInstance);
            this.groupBox2.Location = new System.Drawing.Point(209, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 119);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Static Variable";
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(54, 84);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(96, 23);
            this.btnStatic.TabIndex = 1;
            this.btnStatic.Text = "Static Count";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnInstance
            // 
            this.btnInstance.Location = new System.Drawing.Point(54, 38);
            this.btnInstance.Name = "btnInstance";
            this.btnInstance.Size = new System.Drawing.Size(96, 23);
            this.btnInstance.TabIndex = 0;
            this.btnInstance.Text = "Intance Count";
            this.btnInstance.UseVisualStyleBackColor = true;
            this.btnInstance.Click += new System.EventHandler(this.btnInstance_Click);
            // 
            // labInstance
            // 
            this.labInstance.AutoSize = true;
            this.labInstance.Location = new System.Drawing.Point(379, 291);
            this.labInstance.Name = "labInstance";
            this.labInstance.Size = new System.Drawing.Size(87, 12);
            this.labInstance.TabIndex = 7;
            this.labInstance.Text = "Instance Count: 0";
            // 
            // labStatic
            // 
            this.labStatic.AutoSize = true;
            this.labStatic.Location = new System.Drawing.Point(379, 337);
            this.labStatic.Name = "labStatic";
            this.labStatic.Size = new System.Drawing.Size(74, 12);
            this.labStatic.TabIndex = 8;
            this.labStatic.Text = "Static Count: 0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Open HelloForm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labStatic);
            this.Controls.Add(this.labInstance);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCountPP);
            this.Controls.Add(this.btnPPCount);
            this.Controls.Add(this.btnMinOne);
            this.Controls.Add(this.btnPlusOne);
            this.Controls.Add(this.labCount);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnMinOne;
        private System.Windows.Forms.Button btnPPCount;
        private System.Windows.Forms.Button btnCountPP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnInstance;
        private System.Windows.Forms.Label labInstance;
        private System.Windows.Forms.Label labStatic;
        private System.Windows.Forms.Button button3;
    }
}