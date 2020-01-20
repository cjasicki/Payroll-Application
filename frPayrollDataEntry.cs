using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project2_cs
{
    public partial class frPayrollDataEntry : Form
    {  

        // Global Variable
        DataTable dtNewData = null;
        DataSet dsEmp = null;
        DataSet dsData = null;
        Decimal decPayrate;
        Boolean blT1 = false;
        Decimal decValue = 0m;

        public frPayrollDataEntry()
        {
            InitializeComponent();
            lblEr.Text = "";
        }

        private void frPayrollDataEntry_Load(object sender, EventArgs e)
        {
            CreateDataTable(); //Creates the main datatable
            LoadEmployeeNames(); //loads employee names into the combo box
            PayRate(Convert.ToInt32(cboEmp.SelectedValue)); // gets and stores the payrate for empolyee selected in the combobox

        }

        // method for loading employee names into the combo box
        private void LoadEmployeeNames() 
        {
            DataSet dsEmployees;
            lblEr.Text = "";

            dsEmployees = clsDatabase.GetEmployeeNames();
            if (dsEmployees == null)
            {
                lblEr.Text = "Error retrieving employee names";
            }
            else if (dsEmployees.Tables.Count < 1)
            {
                lblEr.Text = "Error retrieving employee names";
                dsEmployees.Dispose();
            }
            else
            {
                cboEmp.DataSource = dsEmployees.Tables[0];
                cboEmp.DisplayMember = "FullName";
                cboEmp.ValueMember = "EmpID";

                if (cboEmp.Items.Count > 0)
                {
                    cboEmp.SelectedIndex = 0;
                    //DisplayEmployeePayroll(Convert.ToInt32(cboEmp.SelectedValue));
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Displays a message box to confirm the closing of the form.
        private void frPayrollDataEntry_FormClosing(object sender, FormClosingEventArgs e)
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

        private void CreateDataTable()
        {
            lblEr.Text = "";

            //Removes existing datatable, if one exists
            if (dtNewData != null)
            {
                dtNewData.Dispose();
            }

            dtNewData = new DataTable();
            dtNewData.TableName = "NewDataEntry";
            dtNewData.Columns.Add("EmpID", typeof(string));
            dtNewData.Columns.Add("FullName", typeof(string));
            dtNewData.Columns.Add("Week", typeof(string));
            dtNewData.Columns.Add("Hours Worked", typeof(string));
            dtNewData.Columns.Add("TotalPay", typeof(string));

            dgvPayInfo.DataSource = dtNewData;

            // Size columns and set other formatting for DataGridView
            dgvPayInfo.AllowUserToAddRows = false;
            dgvPayInfo.AllowUserToDeleteRows = false;
            dgvPayInfo.AllowUserToOrderColumns = false;
            dgvPayInfo.Columns[0].Width = 100;
            dgvPayInfo.Columns[1].Width = 200;
            dgvPayInfo.Columns[2].Width = 125;
            dgvPayInfo.Columns[3].Width = 100;
            dgvPayInfo.Columns[4].Width = 100;
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {

            Boolean blnX = false;
            int intX = 0;
            Boolean blnWrite = false;

            foreach (DataRow row in dtNewData.Rows)
            {

                if (dtNewData != null)
                {
                    blnX = clsDatabase.InsertPayroll(row.Field<string>(0), row.Field<string>(2), row.Field<string>(3));  // run method in the clsDatabase class to add info in the datatable "stNewData" in SQL database.
                    if(blnX == true)
                    {
                        intX ++;
                        blnWrite = true;

                        
                        lblEr.Text = "Payroll record# " + intX + " updated";
                       // row.Delete();
                        //dtNewData = null;
                        //dtNewData.Clear(); // clears the table and datagrid on form
                        cboEmp.Text = "Select Name";
                    }
                    else
                    {
                        blnWrite = false;
                        lblEr.Text = "error";
                    }
                }
                else
                {
                    lblEr.Text = "Payroll Error";
                }
            }
            dtNewData = null;
        }


        private void cboEmp_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PayRate(Convert.ToInt32(cboEmp.SelectedValue)); // Stores the empoyee payrate selected in the emp combo box
            this.txtWeek.Focus();
            lblEr.Text = "";
        }
        private void PayRate(Int32 intEmpID)
        {
            decPayrate = clsDatabase.GetEmployeePayrate(intEmpID); // Stores the empoyee payrate selected in the emp combo box
        }

        //Adds data entered in the text boxes into the datatable "dtNewData" and data gride veiw "dgvPayInfo"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtWeek.Text == "")
            {
                lblEr.Text = "Need to enter week information";
            }
            else if (txtHoursWrk.Text == "")
            {
                lblEr.Text = "Need to enter Hours Worked";
            }
            else
            {
                lblEr.Text = "";
                // Verify the keyed data for hours worked is a number and has not worked more then 95 hours for the week.
                if (Decimal.TryParse(txtHoursWrk.Text, out decValue))
                {
                    if (decValue >= 95)
                    {
                        txtHoursWrk.Text = "";
                        txtHoursWrk.Focus();
                        lblEr.Text = "Hours Wroked cann't exceed 95 hours";
                    }
                    else
                    {
                        //add data into datatable "dtNewData" 
                        dtNewData.Rows.Add(cboEmp.SelectedValue, cboEmp.Text, txtWeek.Text, txtHoursWrk.Text, (decPayrate * decValue).ToString("N2"));
                        txtWeek.Text = "";
                        txtHoursWrk.Text = "";
                        dgvPayInfo.DataSource = dtNewData;
                        this.cboEmp.Focus();
                    }
                }
                else
                {
                    lblEr.Text = "Hours Worked must be a number";
                    txtHoursWrk.Text = "";
                    txtHoursWrk.Focus();
                }   
            }
        }

        // method for opening print dialogbox
        private void ptnPrint_Click(object sender, EventArgs e)
        {
            DialogResult dlgAnswer;
            lblEr.Text = "";

            dlgAnswer = pdlgData.ShowDialog();
            if (dlgAnswer == DialogResult.OK)
            {
                pdPrint.PrinterSettings = pdlgData.PrinterSettings;
                pdPrint.Print();
            }
        }

        //method for printing 
            private void pdPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fDoc;
            Single sglXPos;
            Single sglYPos;
            Int32 intRow;
            Decimal decTotalValue;

            fDoc = new Font("Arial", 12);
            e.Graphics.DrawString("PayRoll Adds                " + DateTime.Now.ToString("d"), fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(250.0), Convert.ToSingle(75.0));

            sglYPos = Convert.ToSingle(125);
            e.Graphics.DrawString("EmpID", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(30.0), sglYPos);
            e.Graphics.DrawString("FullName", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(100.0), sglYPos);
            e.Graphics.DrawString("Week", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(250.0), sglYPos);
            e.Graphics.DrawString("Hrs Worked", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(400.0), sglYPos);
            e.Graphics.DrawString("TotalPay", fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(550.0), sglYPos);
            decTotalValue = Convert.ToDecimal(0.0);
            for (intRow = 0; intRow < dtNewData.Rows.Count; intRow++)
            {
                sglXPos = Convert.ToSingle(30);
                sglYPos += Convert.ToSingle(fDoc.Height);
                e.Graphics.DrawString(dtNewData.Rows[intRow]["EmpID"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglXPos = Convert.ToSingle(100);
                e.Graphics.DrawString(dtNewData.Rows[intRow]["FullName"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglXPos = Convert.ToSingle(250);
                e.Graphics.DrawString(dtNewData.Rows[intRow]["Week"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglXPos = Convert.ToSingle(400);
                e.Graphics.DrawString(dtNewData.Rows[intRow]["Hours Worked"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);

                sglXPos = Convert.ToSingle(550);
                e.Graphics.DrawString(dtNewData.Rows[intRow]["TotalPay"].ToString(), fDoc, System.Drawing.Brushes.Black, sglXPos, sglYPos);
                decTotalValue += Convert.ToDecimal(dtNewData.Rows[intRow]["TotalPay"]);

            }
            sglYPos += (Convert.ToSingle(fDoc.Height * 12));
            e.Graphics.DrawString(intRow + "  Records Printed, Total Value:" + decTotalValue.ToString(), fDoc, System.Drawing.Brushes.Black, Convert.ToSingle(50.0), sglYPos);
           
        }

        // method for exporting data to an XML file.
        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult dlgAnswer;
            DataSet dsXML;

            sfdXML.DefaultExt = "xml";
            sfdXML.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            sfdXML.InitialDirectory = "C:\\";
            sfdXML.OverwritePrompt = true;
            sfdXML.Title = "Save XML File";

            dlgAnswer = sfdXML.ShowDialog();
            if (dlgAnswer == DialogResult.OK)
            {
                dtNewData.WriteXml(sfdXML.FileName);

                //** Now read back into another dataset
                dsXML = new DataSet();
                dsXML.ReadXml(sfdXML.FileName);
                dgvPayInfo.DataSource = dsXML.Tables[0];
            }
        }

        // error checking key'ed data in textboxes, checks for numbers, letter, and vaild data.
        private void txtWeek_Validated(object sender, EventArgs e)
        {
            Int32 intX;

            if (Int32.TryParse(txtWeek.Text, out intX))
            {
                lblEr.Text = "";
                if (intX.ToString().Length < 8)  //checks number of chr typed in the date textbox. Text property is set to a max of 8 chr.
                {
                    this.txtWeek.Focus();
                    this.txtWeek.Text = "";
                    lblEr.Text = "Week must have 8 characters (YYYYMMDD)";
                }
                else if (txtWeek.Text.Substring(0, 4) != DateTime.Now.ToString("yyyy"))
                    {
                    lblEr.Text = "Year Entered Must Match Current Year";
                    txtWeek.Text = "";
                    txtWeek.Focus();
                    }
                    else
                {
                    DataSet dscheck;

                    dscheck = clsDatabase.GetEmplyeePayroll(Convert.ToInt32(cboEmp.SelectedValue)); //is checking if week data already exists for empoyee.
                    if (dscheck == null)
                    {
                        lblEr.Text = "Error retrieving data";
                    }
                    else if (dscheck.Tables.Count < 1)
                    {
                        lblEr.Text = "Error retrieving data";
                        dscheck.Dispose();
                    }
                    else
                    {
                        lblEr.Text = "";
                        blT1 = false;
                        foreach (DataRow row in dscheck.Tables[0].Rows) //checkS if date already exists in datatable.
                        {
                            string strTestHW = row.Field<string>(2).Trim();
                            if (txtWeek.Text == strTestHW)
                            {
                                lblEr.Text = "Week already in DB for " + cboEmp.Text;
                                blT1 = true;
                            }
                        }
                        if (blT1 == true)
                        {
                            this.txtWeek.Focus();
                            this.txtWeek.Text = "";
                            lblEr.Text = "Week already in DB for " + cboEmp.Text;
                            blT1 = false;
                        }
                        else
                        {
                            if (dtNewData != null)
                            {
                                foreach (DataRow row in dtNewData.Rows) //checke if date already exists in data grid view on the form per empoleey.
                                {
                                    string strTest2 = row.Field<string>(2).Trim();
                                    string strTestEmpID = row.Field<string>(0).Trim();
                                    if (txtWeek.Text == row.Field<string>(2) && cboEmp.SelectedValue.ToString() == strTestEmpID)
                                    {
                                        lblEr.Text = "Week already in table for " + cboEmp.Text;
                                        txtWeek.Text = "";
                                        txtWeek.Focus();
                                        blT1 = true;
                                    }
                                }
                            }
                        }
                    }
                    dscheck.Dispose();
                }
            }
            else
            {
                lblEr.Text = "Can Only Enter Number or Dates";
                txtWeek.Text = "";
                txtWeek.Focus();
            }
        }
    }
}
