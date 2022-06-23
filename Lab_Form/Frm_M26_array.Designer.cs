
namespace Lab_Form
{
    partial class Frm_M26_array
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
            this.btnArray = new System.Windows.Forms.Button();
            this.btnMultiArray = new System.Windows.Forms.Button();
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.btnMemberArray = new System.Windows.Forms.Button();
            this.btnArraySort = new System.Windows.Forms.Button();
            this.btnLastIndex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArray.Location = new System.Drawing.Point(54, 62);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(126, 55);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "建立陣列";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnMultiArray
            // 
            this.btnMultiArray.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMultiArray.Location = new System.Drawing.Point(54, 133);
            this.btnMultiArray.Name = "btnMultiArray";
            this.btnMultiArray.Size = new System.Drawing.Size(126, 55);
            this.btnMultiArray.TabIndex = 1;
            this.btnMultiArray.Text = "建立二維陣列";
            this.btnMultiArray.UseVisualStyleBackColor = true;
            this.btnMultiArray.Click += new System.EventHandler(this.btnMultiArray_Click);
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreateArray.Location = new System.Drawing.Point(54, 207);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(126, 55);
            this.btnCreateArray.TabIndex = 2;
            this.btnCreateArray.Text = "陣列方法";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnMemberArray
            // 
            this.btnMemberArray.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMemberArray.Location = new System.Drawing.Point(54, 280);
            this.btnMemberArray.Name = "btnMemberArray";
            this.btnMemberArray.Size = new System.Drawing.Size(126, 55);
            this.btnMemberArray.TabIndex = 3;
            this.btnMemberArray.Text = "Member類別陣列";
            this.btnMemberArray.UseVisualStyleBackColor = true;
            this.btnMemberArray.Click += new System.EventHandler(this.btnMemberArray_Click);
            // 
            // btnArraySort
            // 
            this.btnArraySort.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnArraySort.Location = new System.Drawing.Point(343, 62);
            this.btnArraySort.Name = "btnArraySort";
            this.btnArraySort.Size = new System.Drawing.Size(126, 55);
            this.btnArraySort.TabIndex = 4;
            this.btnArraySort.Text = "陣列排序";
            this.btnArraySort.UseVisualStyleBackColor = true;
            this.btnArraySort.Click += new System.EventHandler(this.btnArraySort_Click);
            // 
            // btnLastIndex
            // 
            this.btnLastIndex.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLastIndex.Location = new System.Drawing.Point(343, 142);
            this.btnLastIndex.Name = "btnLastIndex";
            this.btnLastIndex.Size = new System.Drawing.Size(126, 55);
            this.btnLastIndex.TabIndex = 5;
            this.btnLastIndex.Text = "last index";
            this.btnLastIndex.UseVisualStyleBackColor = true;
            this.btnLastIndex.Click += new System.EventHandler(this.btnLastIndex_Click);
            // 
            // Frm_M26_array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLastIndex);
            this.Controls.Add(this.btnArraySort);
            this.Controls.Add(this.btnMemberArray);
            this.Controls.Add(this.btnCreateArray);
            this.Controls.Add(this.btnMultiArray);
            this.Controls.Add(this.btnArray);
            this.Name = "Frm_M26_array";
            this.Text = "Frm_M26_array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnMultiArray;
        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button btnMemberArray;
        private System.Windows.Forms.Button btnArraySort;
        private System.Windows.Forms.Button btnLastIndex;
    }
}