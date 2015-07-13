using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace iCSUNBusinessLogic
{
    public class HistoryList : List<History>
    {
        #region Constructors
        public HistoryList()
        {

        }

        public HistoryList GetHistoryList()
        {
            return DataPortal_Fetch();
        } 
        #endregion

        #region Data Access Methods
        private HistoryList DataPortal_Fetch()
        {
            String strSQL = "SELECT * FROM history";
            SqlConnection cnn = null;
            SqlDataReader sdr = null;
            SqlCommand cmd = null;

            try
            { // Open the connection.
                cnn = new SqlConnection(
                    "Data Source=DEEKSHA-PC\\SQLEXPRESS;Initial Catalog=iCSUNDatabase;Integrated Security=True");
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
                    History c = new History();
                    c.HistoryId = sdr[0].ToString();
                    c.Title = sdr[1].ToString();
                    c.Text = sdr[2].ToString();

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
