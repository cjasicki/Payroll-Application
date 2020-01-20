using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Project2_cs
{
    public partial class frPayRollHist : Form
    {
        // creates emtpy dataSet objects
        DataSet dsEmp = null;
        DataSet dsData = null;

        Int32 intCurrRow;

        public frPayRollHist()
        {
            InitializeComponent();
        }

        private void FrPayRollHist_Load(object sender, EventArgs e)
        {
            //  using the app.config key value to update text in lblMenu textbox
            if (ConfigurationManager.AppSettings["AppTitle"] != null)
            {
               lblMenu.Text = ConfigurationManager.AppSettings["AppTitle"].ToString();
            }

            lblError.Text = "";
            LoadEmployees();
            DisplayEmployeePayroll(Convert.ToInt32(txtID.Text));
        }
        private void LoadEmployees()
        {
            lblError.Text = "";

            // Removes dataset if one exists 
            if (dsEmp != null)
            {
                dsEmp.Dispose();
            }

            // Initialize first row
            intCurrRow = 0;

            // Returning employee deatil detaset
            dsEmp = clsDatabase.GetEmployeeInfo();
            if (dsEmp == null)
            {
                MessageBox.Show("Unable to retrieve employee information", "SELECT");
                DisableNavButtons();
            }
            else if (dsEmp.Tables.Count < 1) //checks to if there was no tables returned.
            {
                MessageBox.Show("Unable to retrieve employee information", "SELECT");
                dsEmp.Dispose();
                dsEmp = null;
                DisableNavButtons();
            }
            else if (dsEmp.Tables[0].Rows.Count < 1) //checks to if there was no records returned.
            {
                MessageBox.Show("No employee information available", "SELECT");
                DisableNavButtons();
            }
            else
            {
                EnableNavButtons();
                ShowEmployee();
            }
        }

        // Display specified employee record
        private void ShowEmployee()
        {
            txtID.Text = dsEmp.Tables[0].Rows[intCurrRow]["EmpID"].ToString();
            txtLName.Text = dsEmp.Tables[0].Rows[intCurrRow]["LName"].ToString();
            txtFName.Text = dsEmp.Tables[0].Rows[intCurrRow]["FName"].ToString();
            txtSSN.Text = dsEmp.Tables[0].Rows[intCurrRow]["SSAN"].ToString();
            
            // format txtpay textbox to currency
            Int32 x = Convert.ToInt32(dsEmp.Tables[0].Rows[intCurrRow]["PayRate"]);
            txtPay.Text = x.ToString("C");

            if (dsEmp.Tables[0].Rows[intCurrRow]["MInit"] == DBNull.Value)
            {
                txtMName.Text = "";
            }
            else
            {
                txtMName.Text = dsEmp.Tables[0].Rows[intCurrRow]["MInit"].ToString();
            }
            DisplayEmployeePayroll(Convert.ToInt32(txtID.Text));
        }
        private void DisableNavButtons()
        {
            btnFirst.Enabled = false;
            btnNext.Enabled = false;
            btnPrev.Enabled = false;
            btnLast.Enabled = false;
        }
        private void EnableNavButtons()
        {
            btnFirst.Enabled = true;
            btnNext.Enabled = true;
            btnPrev.Enabled = true;
            btnLast.Enabled = true;
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow += 1;
            if (intCurrRow >= dsEmp.Tables[0].Rows.Count)
            {
                intCurrRow = 0;
            }
            ShowEmployee();
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow -= 1;
            if (intCurrRow < 0)
            {
                intCurrRow  = dsEmp.Tables[0].Rows.Count - 1;
            }
            ShowEmployee();
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = 0;
            ShowEmployee();
            
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            intCurrRow = dsEmp.Tables[0].Rows.Count - 1;
            ShowEmployee();
        }

        // Display payrate and payroll for specified employee
        private void DisplayEmployeePayroll(Int32 intEmpID)
        {
            DataSet dsData;
            Decimal decPayrate;

            decPayrate = clsDatabase.GetEmployeePayrate(intEmpID);
            if (decPayrate < 0m)
            {
                lblError.Text = "$0.00";
            }
            else
            {
               // txtPayrate.Text = decPayrate.ToString("c");
            }

            dsData = clsDatabase.GetEmplyeePayroll(intEmpID);
            if (dsData == null)
            {
                lblError.Text = "Error retrieving payroll info";
            }
            else if (dsData.Tables.Count < 1)
            {
                lblError.Text = "Error retrieving payroll info";
                dsData.Dispose();
            }
            else
            {
                dgvPayInfo.DataSource = dsData.Tables[0];

                // Formatting columns 4 and 5 to currency
                dgvPayInfo.Columns[4].DefaultCellStyle.Format = "c";
                dgvPayInfo.Columns[5].DefaultCellStyle.Format = "c";
            }
        }

        private void frPayRollHist_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Click OK to return to the Main Menu", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
                


            }
            else
            {
                e.Cancel = false;
                
                //Disposes all datasets if they exist
                if (dsData != null)
                {
                    dsData.Dispose();
                    dgvPayInfo.DataSource = null;
                }
                if (dsEmp != null)
                {
                    dsEmp.Dispose();
                }

                // close frPayrollHist from and reopens frMenu form
                frMenu myForm = (frMenu)Application.OpenForms["frMenu"];
                myForm.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
