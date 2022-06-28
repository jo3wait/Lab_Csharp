
namespace Lab_FormHw
{
    partial class Frm_Loan_Report
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
            this.btnEmail = new System.Windows.Forms.Button();
            this.labPMT = new System.Windows.Forms.Label();
            this.labInterest = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labLoan = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.txtLoanR = new System.Windows.Forms.TextBox();
            this.txtYearR = new System.Windows.Forms.TextBox();
            this.txtInterestR = new System.Windows.Forms.TextBox();
            this.txtPmtR = new System.Windows.Forms.TextBox();
            this.txtTotalR = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmail.Location = new System.Drawing.Point(876, 510);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(189, 76);
            this.btnEmail.TabIndex = 0;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // labPMT
            // 
            this.labPMT.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPMT.Location = new System.Drawing.Point(336, 396);
            this.labPMT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labPMT.Name = "labPMT";
            this.labPMT.Size = new System.Drawing.Size(135, 40);
            this.labPMT.TabIndex = 14;
            this.labPMT.Text = "月付款";
            // 
            // labInterest
            // 
            this.labInterest.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterest.Location = new System.Drawing.Point(336, 322);
            this.labInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labInterest.Name = "labInterest";
            this.labInterest.Size = new System.Drawing.Size(135, 40);
            this.labInterest.TabIndex = 12;
            this.labInterest.Text = "利率%";
            // 
            // labYear
            // 
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.Location = new System.Drawing.Point(336, 248);
            this.labYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(135, 40);
            this.labYear.TabIndex = 10;
            this.labYear.Text = "期限(年)";
            // 
            // labLoan
            // 
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(336, 177);
            this.labLoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(135, 40);
            this.labLoan.TabIndex = 8;
            this.labLoan.Text = "貸款金額";
            // 
            // labTotal
            // 
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(336, 470);
            this.labTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(135, 40);
            this.labTotal.TabIndex = 16;
            this.labTotal.Text = "總付款";
            // 
            // txtLoanR
            // 
            this.txtLoanR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLoanR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoanR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanR.Location = new System.Drawing.Point(501, 174);
            this.txtLoanR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLoanR.Name = "txtLoanR";
            this.txtLoanR.ReadOnly = true;
            this.txtLoanR.Size = new System.Drawing.Size(240, 32);
            this.txtLoanR.TabIndex = 9;
            this.txtLoanR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtYearR
            // 
            this.txtYearR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtYearR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYearR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYearR.Location = new System.Drawing.Point(501, 244);
            this.txtYearR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYearR.Name = "txtYearR";
            this.txtYearR.ReadOnly = true;
            this.txtYearR.Size = new System.Drawing.Size(240, 32);
            this.txtYearR.TabIndex = 11;
            this.txtYearR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtInterestR
            // 
            this.txtInterestR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtInterestR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInterestR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestR.Location = new System.Drawing.Point(501, 320);
            this.txtInterestR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInterestR.Name = "txtInterestR";
            this.txtInterestR.ReadOnly = true;
            this.txtInterestR.Size = new System.Drawing.Size(240, 32);
            this.txtInterestR.TabIndex = 13;
            this.txtInterestR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPmtR
            // 
            this.txtPmtR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPmtR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPmtR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPmtR.Location = new System.Drawing.Point(501, 393);
            this.txtPmtR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPmtR.Name = "txtPmtR";
            this.txtPmtR.ReadOnly = true;
            this.txtPmtR.Size = new System.Drawing.Size(240, 32);
            this.txtPmtR.TabIndex = 15;
            this.txtPmtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalR
            // 
            this.txtTotalR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTotalR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalR.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalR.Location = new System.Drawing.Point(501, 466);
            this.txtTotalR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalR.Name = "txtTotalR";
            this.txtTotalR.ReadOnly = true;
            this.txtTotalR.Size = new System.Drawing.Size(240, 32);
            this.txtTotalR.TabIndex = 17;
            this.txtTotalR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_Loan_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.txtTotalR);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.txtPmtR);
            this.Controls.Add(this.labPMT);
            this.Controls.Add(this.txtInterestR);
            this.Controls.Add(this.labInterest);
            this.Controls.Add(this.txtYearR);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.txtLoanR);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.btnEmail);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Loan_Report";
            this.Text = "Loan Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label labPMT;
        private System.Windows.Forms.Label labInterest;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labTotal;
        public System.Windows.Forms.TextBox txtLoanR;
        public System.Windows.Forms.TextBox txtYearR;
        public System.Windows.Forms.TextBox txtInterestR;
        public System.Windows.Forms.TextBox txtPmtR;
        public System.Windows.Forms.TextBox txtTotalR;
    }
}