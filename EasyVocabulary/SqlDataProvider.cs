using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.Odbc;
/*
 * Author: Nguyen Phuc
 * Date: 2/2/2014
 */
namespace EasyVocabulary
{
    class SqlDataProvider
    {
        //Contructor
        public SqlDataProvider()
        { 
        }
        OleDbConnection con = new OleDbConnection();
        OleDbDataAdapter ada;
        OleDbCommand cmd;
        #region Variable
        public string ConnectionString { get; set; }
        public string CommandText { get; set; }
        public CommandType CommandType { get; set; }
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public string[] ParameterColection { get; set; }
        public object[] ValueColection { get; set; }
        public string Sqltr { get; set; }
        #endregion
        #region Method
        //Open connection with database
        public void Open()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.ConnectionString = ConnectionString;
                    con.Open();
                }   
            }
            catch (OleDbException ex)
            {
                ErrorCode = ex.ErrorCode;
                ErrorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        //Read Data to Datatable
        public DataTable Getdatatable()
        {
            Open();
            ada = new OleDbDataAdapter(Sqltr, con);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            return dt;
        }
        //Add value to parameter
        public void Addparametercolection(OleDbCommand SqlCmd)
        {
            try
            {
                for (int i = 0; i < ParameterColection.Length; i++)
                {
                    SqlCmd.Parameters.AddWithValue(ParameterColection[i], ValueColection[i]);
                }
            }
            catch (OleDbException ex)
            {
                ErrorCode = ex.ErrorCode;
                ErrorMessage = ex.Message;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        //Execute command for update, delete,insert
        public int Execute()
        {
            Open();
            int row = 0;
            try
            {
                cmd = new OleDbCommand();
                cmd.CommandText = CommandText;
                cmd.CommandType = CommandType;
                cmd.Connection = con;
                if (ParameterColection != null)
                {
                    Addparametercolection(cmd);
                }
                row = cmd.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                ErrorMessage = ex.Message;
                ErrorCode = ex.ErrorCode;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return row;
        }
        //Execute command return a Datatable
        public DataTable FillData()
        {
            Open();
            DataTable dt = new DataTable();
            try
            {
                cmd = new OleDbCommand();
                cmd.CommandText = CommandText;
                cmd.CommandType = CommandType;
                cmd.Connection = con;
                if (ParameterColection != null)
                {
                    Addparametercolection(cmd);
                }
                ada = new OleDbDataAdapter(cmd);
                ada.Fill(dt);
            }
            catch (OleDbException ex)
            {
                ErrorMessage = ex.Message;
                ErrorCode = ex.ErrorCode;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            finally
            {
                cmd.Dispose();
            }
            return dt;
        }
        #endregion
    }
}
