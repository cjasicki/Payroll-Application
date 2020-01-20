namespace Project2_cs
{
    partial class frPayRollHist
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
            this.gbPayroll = new System.Windows.Forms.GroupBox();
            this.dgvPayInfo = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbEmployee = new System.Windows.Forms.GroupBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIDNum = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbPayroll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).BeginInit();
            this.gbEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPayroll
            // 
            this.gbPayroll.Controls.Add(this.dgvPayInfo);
            this.gbPayroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPayroll.Location = new System.Drawing.Point(63, 283);
            this.gbPayroll.Name = "gbPayroll";
            this.gbPayroll.Size = new System.Drawing.Size(859, 270);
            this.gbPayroll.TabIndex = 22;
            this.gbPayroll.TabStop = false;
            this.gbPayroll.Text = "Payroll";
            // 
            // dgvPayInfo
            // 
            this.dgvPayInfo.AllowUserToAddRows = false;
            this.dgvPayInfo.AllowUserToDeleteRows = false;
            this.dgvPayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayInfo.Location = new System.Drawing.Point(21, 30);
            this.dgvPayInfo.Name = "dgvPayInfo";
            this.dgvPayInfo.ReadOnly = true;
            this.dgvPayInfo.RowHeadersWidth = 51;
            this.dgvPayInfo.RowTemplate.Height = 24;
            this.dgvPayInfo.Size = new System.Drawing.Size(820, 220);
            this.dgvPayInfo.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(259, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 46);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "Browse Employee";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbEmployee
            // 
            this.gbEmployee.Controls.Add(this.lblMenu);
            this.gbEmployee.Controls.Add(this.label2);
            this.gbEmployee.Controls.Add(this.label1);
            this.gbEmployee.Controls.Add(this.txtPay);
            this.gbEmployee.Controls.Add(this.lblPay);
            this.gbEmployee.Controls.Add(this.txtSSN);
            this.gbEmployee.Controls.Add(this.lblSSN);
            this.gbEmployee.Controls.Add(this.txtMName);
            this.gbEmployee.Controls.Add(this.txtFName);
            this.gbEmployee.Controls.Add(this.txtLName);
            this.gbEmployee.Controls.Add(this.txtID);
            this.gbEmployee.Controls.Add(this.lblName);
            this.gbEmployee.Controls.Add(this.lblIDNum);
            this.gbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployee.Location = new System.Drawing.Point(63, 58);
            this.gbEmployee.Name = "gbEmployee";
            this.gbEmployee.Size = new System.Drawing.Size(859, 223);
            this.gbEmployee.TabIndex = 21;
            this.gbEmployee.TabStop = false;
            this.gbEmployee.Text = "Employee";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Location = new System.Drawing.Point(541, 16);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(64, 25);
            this.lblMenu.TabIndex = 24;
            this.lblMenu.Text = "label1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(501, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "MI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPay
            // 
            this.txtPay.BackColor = System.Drawing.SystemColors.Window;
            this.txtPay.Location = new System.Drawing.Point(419, 182);
            this.txtPay.Name = "txtPay";
            this.txtPay.ReadOnly = true;
            this.txtPay.Size = new System.Drawing.Size(113, 30);
            this.txtPay.TabIndex = 10;
            // 
            // lblPay
            // 
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(416, 153);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(83, 26);
            this.lblPay.TabIndex = 9;
            this.lblPay.Text = "Pay:";
            this.lblPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSSN
            // 
            this.txtSSN.BackColor = System.Drawing.SystemColors.Window;
            this.txtSSN.Location = new System.Drawing.Point(147, 182);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.ReadOnly = true;
            this.txtSSN.Size = new System.Drawing.Size(248, 30);
            this.txtSSN.TabIndex = 8;
            // 
            // lblSSN
            // 
            this.lblSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSSN.Location = new System.Drawing.Point(144, 153);
            this.lblSSN.Name = "lblSSN";
            this.lblSSN.Size = new System.Drawing.Size(124, 26);
            this.lblSSN.TabIndex = 7;
            this.lblSSN.Text = "SSAN:";
            this.lblSSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(419, 116);
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(61, 30);
            this.txtMName.TabIndex = 6;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.SystemColors.Window;
            this.txtFName.Location = new System.Drawing.Point(148, 116);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(248, 30);
            this.txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.SystemColors.Window;
            this.txtLName.Location = new System.Drawing.Point(504, 116);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(248, 30);
            this.txtLName.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.Location = new System.Drawing.Point(148, 54);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(156, 30);
            this.txtID.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(143, 89);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 26);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Frist Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblIDNum
            // 
            this.lblIDNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNum.Location = new System.Drawing.Point(143, 25);
            this.lblIDNum.Name = "lblIDNum";
            this.lblIDNum.Size = new System.Drawing.Size(124, 26);
            this.lblIDNum.TabIndex = 0;
            this.lblIDNum.Text = "ID Number:";
            this.lblIDNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(817, 566);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 44);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(588, 566);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(107, 44);
            this.btnLast.TabIndex = 18;
            this.btnLast.Text = "&Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(447, 566);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 44);
            this.btnNext.TabIndex = 17;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(301, 566);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(107, 44);
            this.btnPrev.TabIndex = 16;
            this.btnPrev.Text = "&Previous";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(156, 566);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(107, 44);
            this.btnFirst.TabIndex = 15;
            this.btnFirst.Text = "&First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(41, 620);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 25);
            this.lblError.TabIndex = 23;
            // 
            // frPayRollHist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 653);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gbPayroll);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbEmployee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frPayRollHist";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frPayRollHist_FormClosing);
            this.Load += new System.EventHandler(this.FrPayRollHist_Load);
            this.gbPayroll.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).EndInit();
            this.gbEmployee.ResumeLayout(false);
            this.gbEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPayroll;
        internal System.Windows.Forms.DataGridView dgvPayInfo;
        internal System.Windows.Forms.Label lblTitle;
        internal System.Windows.Forms.GroupBox gbEmployee;
        internal System.Windows.Forms.TextBox txtPay;
        internal System.Windows.Forms.TextBox txtSSN;
        internal System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtMName;
        internal System.Windows.Forms.TextBox txtFName;
        internal System.Windows.Forms.TextBox txtLName;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Label lblName;
        internal System.Windows.Forms.Label lblIDNum;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnLast;
        internal System.Windows.Forms.Button btnNext;
        internal System.Windows.Forms.Button btnPrev;
        internal System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblMenu;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label lblPay;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}