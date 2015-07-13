using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace iCSUNBusinessLogic
{
    public class FacClassScheduleList : List<FacClassSchedule>
    {
        #region Constructors
        public FacClassScheduleList()
        {

        }

        public FacClassScheduleList GetFacClassScheduleList()
        {
            return DataPortal_Fetch();
        } 
        #endregion

        #region Data Access Methods
        private FacClassScheduleList DataPortal_Fetch()
        {
            String strSQL = "SELECT * FROM FacClassSchedule";
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
                    FacClassSchedule c = new FacClassSchedule();
                    c.FcsId = sdr[0].ToString();
                    c.FacId = sdr[1].ToString();
                    c.CatlgNbr = sdr[2].ToString();
                    c.Days = sdr[3].ToString();
                    c.Time = sdr[4].ToString();
                    c.Room = sdr[5].ToString();
                    c.ClassNumber = sdr[6].ToString();

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
