
namespace Lab_FormHw
{
    partial class Frm_Guess
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
            this.labShow = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(179, 172);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(415, 27);
            this.labShow.TabIndex = 0;
            this.labShow.Text = "Please Select A Number Between 0 - 100.";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGuess.Location = new System.Drawing.Point(184, 250);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(129, 58);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Start Guessing";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShow.Location = new System.Drawing.Point(465, 250);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(129, 58);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Show Answer";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Frm_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labShow);
            this.Name = "Frm_Guess";
            this.Text = "Frm_Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button btnShow;
        public System.Windows.Forms.Label labShow;
    }
}