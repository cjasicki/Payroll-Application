namespace Project2_cs
{
    partial class frMenu
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEnterPayrollData = new System.Windows.Forms.Button();
            this.btnBrowseEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(213, 268);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(221, 32);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEnterPayrollData
            // 
            this.btnEnterPayrollData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterPayrollData.Location = new System.Drawing.Point(213, 196);
            this.btnEnterPayrollData.Name = "btnEnterPayrollData";
            this.btnEnterPayrollData.Size = new System.Drawing.Size(221, 32);
            this.btnEnterPayrollData.TabIndex = 18;
            this.btnEnterPayrollData.Text = "Enter Payroll Data";
            this.btnEnterPayrollData.UseVisualStyleBackColor = true;
            this.btnEnterPayrollData.Click += new System.EventHandler(this.btnEnterPayrollData_Click);
            // 
            // btnBrowseEmp
            // 
            this.btnBrowseEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseEmp.Location = new System.Drawing.Point(213, 146);
            this.btnBrowseEmp.Name = "btnBrowseEmp";
            this.btnBrowseEmp.Size = new System.Drawing.Size(221, 32);
            this.btnBrowseEmp.TabIndex = 17;
            this.btnBrowseEmp.Text = "Browse Employee";
            this.btnBrowseEmp.UseVisualStyleBackColor = true;
            this.btnBrowseEmp.Click += new System.EventHandler(this.BtnBrowseEmp_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Payroll System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 551);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnterPayrollData);
            this.Controls.Add(this.btnBrowseEmp);
            this.Controls.Add(this.label1);
            this.Name = "frMenu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEnterPayrollData;
        private System.Windows.Forms.Button btnBrowseEmp;
        internal System.Windows.Forms.Label label1;
    }
}

