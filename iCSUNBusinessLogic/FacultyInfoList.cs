using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace iCSUNBusinessLogic
{
    public class FacultyInfoList : List<FacultyInfo>
    {
        #region Constructors
        public FacultyInfoList()
        {

        }

        public FacultyInfoList GetFacultyInfoList()
        {
            return DataPortal_Fetch();
        } 
        #endregion

        #region Data Access Methods
        private FacultyInfoList DataPortal_Fetch()
        {
            String strSQL = "SELECT * FROM FacultyInfo";
            SqlConnection cnn = null;
            SqlDataReader sdr = null;
            SqlCommand cmd = null;
            string localConnStr = "Data Source=DEEKSHA-PC\\SQLEXPRESS;Initial Catalog=iCSUNDatabase;Integrated Security=True";
            string goDyconnStr = System.Configuration.ConfigurationSettings.AppSettings["goDaddyDBConnString"].ToString();
            string externaldb = System.Configuration.ConfigurationSettings.AppSettings["externaldb"].ToString();
            string connStr = (externaldb == "true") ? goDyconnStr : localConnStr;

            try
            { // Open the connection.
                cnn = new SqlConnection(connStr);
                cnn.Open();

                // Open the Command and execute the DataReader.
                cmd = new SqlCommand(strSQL, cnn);
                sdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                // Start on second row.
                int intRow = 2;

                // Retrieve the data and insert into new rows.
                Object beforeRow = Type.Missing;
                while (sdr.Read())
                {
                    FacultyInfo c = new FacultyInfo();
                    c.FacId = sdr[0].ToString();
                    c.Name = sdr[1].ToString();
                    c.Dept = sdr[2].ToString();
                    c.Schedule = sdr[3].ToString();
                    c.Web = sdr[4].ToString();
                    c.Email = sdr[5].ToString();
                    c.Ext = sdr[6].ToString();
                    c.OfficeLoc = sdr[7].ToString();
                    c.LocCod = sdr[8].ToString();

                    this.Add(c);
                    intRow += 1;
                }
                return this;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sdr != null)
                {
                    sdr.Close();
                }
            }
        } 
        #endregion
    }
}
