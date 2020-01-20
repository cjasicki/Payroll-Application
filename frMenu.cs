using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_cs
{
    public partial class frMenu : Form
    {
        public frMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void BtnBrowseEmp_Click(object sender, EventArgs e)
        {
            frPayRollHist PayRollHistForm = new frPayRollHist();
            this.Hide();
            PayRollHistForm.Show();

        }

        private void FrMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you Sure you want to Close", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void btnEnterPayrollData_Click(object sender, EventArgs e)
        {
            frPayrollDataEntry EnterPayrollData = new frPayrollDataEntry();
            this.Hide();
            EnterPayrollData.Show();
        }
    }
}
