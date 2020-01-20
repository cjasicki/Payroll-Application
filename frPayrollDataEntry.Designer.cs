namespace Project2_cs
{
    partial class frPayrollDataEntry
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblWeek = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.txtHoursWrk = new System.Windows.Forms.TextBox();
            this.dgvPayInfo = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.ptnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.lblEr = new System.Windows.Forms.Label();
            this.pdPrint = new System.Drawing.Printing.PrintDocument();
            this.pdlgData = new System.Windows.Forms.PrintDialog();
            this.sfdXML = new System.Windows.Forms.SaveFileDialog();
            this.lblYMD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(171, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payroll Data Entry";
            // 
            // cboEmp
            // 
            this.cboEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Location = new System.Drawing.Point(350, 109);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(259, 33);
            this.cboEmp.TabIndex = 1;
            this.cboEmp.SelectionChangeCommitted += new System.EventHandler(this.cboEmp_SelectionChangeCommitted);
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.Location = new System.Drawing.Point(221, 112);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(114, 25);
            this.lblEmp.TabIndex = 2;
            this.lblEmp.Text = "Employee:";
            // 
            // lblWeek
            // 
            this.lblWeek.AutoSize = true;
            this.lblWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeek.Location = new System.Drawing.Point(81, 191);
            this.lblWeek.Name = "lblWeek";
            this.lblWeek.Size = new System.Drawing.Size(75, 25);
            this.lblWeek.TabIndex = 3;
            this.lblWeek.Text = "Week:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoursWorked.Location = new System.Drawing.Point(345, 191);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(157, 25);
            this.lblHoursWorked.TabIndex = 4;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(682, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 42);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWeek
            // 
            this.txtWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeek.Location = new System.Drawing.Point(180, 191);
            this.txtWeek.MaxLength = 8;
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(128, 30);
            this.txtWeek.TabIndex = 6;
            this.txtWeek.Validated += new System.EventHandler(this.txtWeek_Validated);
            // 
            // txtHoursWrk
            // 
            this.txtHoursWrk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWrk.Location = new System.Drawing.Point(516, 186);
            this.txtHoursWrk.Name = "txtHoursWrk";
            this.txtHoursWrk.Size = new System.Drawing.Size(128, 30);
            this.txtHoursWrk.TabIndex = 7;
            // 
            // dgvPayInfo
            // 
            this.dgvPayInfo.AllowUserToAddRows = false;
            this.dgvPayInfo.AllowUserToDeleteRows = false;
            this.dgvPayInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayInfo.Location = new System.Drawing.Point(12, 243);
            this.dgvPayInfo.Name = "dgvPayInfo";
            this.dgvPayInfo.ReadOnly = true;
            this.dgvPayInfo.RowHeadersWidth = 51;
            this.dgvPayInfo.RowTemplate.Height = 24;
            this.dgvPayInfo.Size = new System.Drawing.Size(964, 212);
            this.dgvPayInfo.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(595, 489);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 42);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ptnPrint
            // 
            this.ptnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnPrint.Location = new System.Drawing.Point(432, 489);
            this.ptnPrint.Name = "ptnPrint";
            this.ptnPrint.Size = new System.Drawing.Size(120, 42);
            this.ptnPrint.TabIndex = 16;
            this.ptnPrint.Text = "Print";
            this.ptnPrint.UseVisualStyleBackColor = true;
            this.ptnPrint.Click += new System.EventHandler(this.ptnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(264, 489);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 42);
            this.btnExport.TabIndex = 17;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.Location = new System.Drawing.Point(106, 489);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(120, 42);
            this.btnCommit.TabIndex = 18;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // lblEr
            // 
            this.lblEr.AutoSize = true;
            this.lblEr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEr.ForeColor = System.Drawing.Color.Red;
            this.lblEr.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblEr.Location = new System.Drawing.Point(12, 458);
            this.lblEr.Name = "lblEr";
            this.lblEr.Size = new System.Drawing.Size(75, 25);
            this.lblEr.TabIndex = 19;
            this.lblEr.Text = "Errors?";
            this.lblEr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pdPrint
            // 
            this.pdPrint.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdPrint_PrintPage);
            // 
            // pdlgData
            // 
            this.pdlgData.UseEXDialog = true;
            // 
            // sfdXML
            // 
            this.sfdXML.FileName = " 0";
            // 
            // lblYMD
            // 
            this.lblYMD.AutoSize = true;
            this.lblYMD.Location = new System.Drawing.Point(203, 166);
            this.lblYMD.Name = "lblYMD";
            this.lblYMD.Size = new System.Drawing.Size(86, 17);
            this.lblYMD.TabIndex = 20;
            this.lblYMD.Text = "YYYYMMDD";
            // 
            // frPayrollDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 548);
            this.Controls.Add(this.lblYMD);
            this.Controls.Add(this.lblEr);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.ptnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvPayInfo);
            this.Controls.Add(this.txtHoursWrk);
            this.Controls.Add(this.txtWeek);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblWeek);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.cboEmp);
            this.Controls.Add(this.lblTitle);
            this.Name = "frPayrollDataEntry";
            this.Text = "frPayrollDataEntry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frPayrollDataEntry_FormClosing);
            this.Load += new System.EventHandler(this.frPayrollDataEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblWeek;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.TextBox txtHoursWrk;
        internal System.Windows.Forms.DataGridView dgvPayInfo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button ptnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Label lblEr;
        private System.Drawing.Printing.PrintDocument pdPrint;
        private System.Windows.Forms.PrintDialog pdlgData;
        private System.Windows.Forms.SaveFileDialog sfdXML;
        private System.Windows.Forms.Label lblYMD;
    }
}