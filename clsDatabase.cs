 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Project2_cs
{
    class clsDatabase
    {
        //***********************************************************
        //**  Procedure:  AcquireConnection()
        //**    Opens a connection using the default database
        //***********************************************************
        private static SqlConnection AcquireConnection()
        {
            return AcquireConnection("Payroll");
        }

        //***********************************************************
        //**  Procedure:  AcquireConnection()
        //**  Description:
        //**    Opens a connection using the specified connection
        //**  NOTE: Overloaded class to allow SQL connection creation
        //**        by external calls.
        //***********************************************************
        public static SqlConnection AcquireConnection(String strConnName)
        {
            SqlConnection cnSQL = null;
            Boolean blnErrorOccurred = false;

            //** Verify parameter
            if (strConnName.Trim().Length < 1)
            {
                blnErrorOccurred = true;
            }
            else if (ConfigurationManager.ConnectionStrings[strConnName] == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cnSQL = new SqlConnection();
                cnSQL.ConnectionString = ConfigurationManager.ConnectionStrings[strConnName].ToString();

                try
                {
                    cnSQL.Open();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return cnSQL;
            }
        }

        //***********************************************************
        //**  Procedure:  GetEmployees()
        //**    Retrieves all employees from the database
        //***********************************************************
        public static DataSet GetEmployeeNames()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;

            cnSQL = AcquireConnection();
            if (cnSQL == null)
            {
                blnErrorOccurred = true;
            }
            else
            {
                //** Build command to execute stored procedure
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetEmployeeNames";

                cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                dsSQL = new DataSet();

                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsSQL);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    blnErrorOccurred = true;
                    dsSQL.Dispose();
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }

            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }
        //  Retrieves payrate for sqecified employee
        public static Decimal GetEmployeePayrate(Int32 intEmpID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            Boolean blnErrorOccurred = false;
            Decimal decPay = 0m;
            Int32 intRetCode;

            // Verify parameter exists
            if (intEmpID < 1)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cnSQL = AcquireConnection();
                if (cnSQL == null)
                {
                    blnErrorOccurred = true;
                }
                else
                {
                    // Build command to execute stored procedure
                    cmdSQL = new SqlCommand();
                    cmdSQL.Connection = cnSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "GetPayrateByID";

                    cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                    cmdSQL.Parameters["@EmpID"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@EmpID"].Value = intEmpID;

                    cmdSQL.Parameters.Add(new SqlParameter("@PayRate", SqlDbType.SmallMoney));
                    cmdSQL.Parameters["@PayRate"].Direction = ParameterDirection.Output;

                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;

                    try
                    {
                        intRetCode = cmdSQL.ExecuteNonQuery();
                    }
                    catch
                    {
                        blnErrorOccurred = true;
                    }
                    finally
                    {
                        cnSQL.Close();
                        cnSQL.Dispose();
                    }

                    if (!blnErrorOccurred)
                    {
                        if (cmdSQL.Parameters["@PayRate"].Value == DBNull.Value)
                        {
                            blnErrorOccurred = true;
                        }
                        else
                        {
                            decPay = Convert.ToDecimal(cmdSQL.Parameters["@PayRate"].Value);
                        }
                    }
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                }
            }
            if (blnErrorOccurred)
            {
                return -1.0m;
            }
            else
            {
                return decPay;
            }
        }
        // Retieves payroll records for sqecifief employee
        public static DataSet GetEmplyeePayroll(Int32 intEmpID)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsSQL = null;
            Boolean blnErrorOccurred = false;

            // Verify parameter exists
            if (intEmpID < 1)
            {
                blnErrorOccurred = true;
            }
            else
            {
                cnSQL = AcquireConnection();
                if (cnSQL == null)
                {
                    blnErrorOccurred = true;
                }
                else
                {
                    //Build command to execute stored procedure
                    cmdSQL = new SqlCommand();
                    cmdSQL.Connection = cnSQL;
                    cmdSQL.CommandType = CommandType.StoredProcedure;
                    cmdSQL.CommandText = "GetPayrollByEmployee";

                    cmdSQL.Parameters.Add(new SqlParameter("@EmpID", SqlDbType.Int));
                    cmdSQL.Parameters["@Empid"].Direction = ParameterDirection.Input;
                    cmdSQL.Parameters["@Empid"].Value = intEmpID;

                    cmdSQL.Parameters.Add(new SqlParameter("@ErrCode", SqlDbType.Int));
                    cmdSQL.Parameters["@ErrCode"].Direction = ParameterDirection.ReturnValue;
                    dsSQL = new DataSet();

                    try
                    {
                        daSQL = new SqlDataAdapter(cmdSQL);
                        daSQL.Fill(dsSQL);
                        dsSQL.Dispose();
                    }
                    catch (Exception ex)
                    {
                        blnErrorOccurred = true;
                        dsSQL.Dispose();
                    }
                    finally
                    {
                        cmdSQL.Parameters.Clear();
                        cmdSQL.Dispose();
                        cnSQL.Close();
                        cnSQL.Dispose();
                    }
                }
            }
            if (blnErrorOccurred)
            {
                return null;
            }
            else
            {
                return dsSQL;
            }
        }

        //** Procedure: GetEmployeeInfo()
        public static DataSet GetEmployeeInfo()
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            SqlDataAdapter daSQL;
            DataSet dsData = null;

            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "GetAllEmployees";

                dsData = new DataSet();
                try
                {
                    daSQL = new SqlDataAdapter(cmdSQL);
                    daSQL.Fill(dsData);
                    daSQL.Dispose();
                }
                catch (Exception ex)
                {
                    dsData.Dispose();
                    dsData = null;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();
                }
            }
            return dsData;
        }

        //** Procedure: InsertPayroll()
        public static Boolean InsertPayroll(string strID, string strWeek, string strHours)
        {
            SqlConnection cnSQL;
            SqlCommand cmdSQL;
            cnSQL = AcquireConnection();
            if (cnSQL != null)
            {
                cmdSQL = new SqlCommand();
                cmdSQL.Connection = cnSQL;
                cmdSQL.CommandType = CommandType.StoredProcedure;
                cmdSQL.CommandText = "InsertPayroll";
                cmdSQL.Parameters.AddWithValue("@EmpID", strID);
                cmdSQL.Parameters.AddWithValue("@WeekEnding", strWeek);
                cmdSQL.Parameters.AddWithValue("@HoursWorked", strHours);
               // cmdSQL.Parameters.Clear();
                try
                { 
                    cmdSQL.ExecuteNonQuery();   
                }
                catch
                {
                    return false;
                }
                finally
                {
                    cmdSQL.Parameters.Clear();
                    cmdSQL.Dispose();
                    cnSQL.Close();
                    cnSQL.Dispose();

                }
            } 
            return true;
        }
    }
}
