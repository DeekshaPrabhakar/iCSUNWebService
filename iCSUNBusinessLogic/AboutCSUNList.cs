using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace iCSUNBusinessLogic
{
    public class AboutCSUNList : List<AboutCSUN>
    {
        #region Constructors
        public AboutCSUNList()
        {

        }

        public AboutCSUNList GetAboutCSUNList()
        {
            return DataPortal_Fetch();
        } 
        #endregion

        #region Data Access Methods
        private AboutCSUNList DataPortal_Fetch()
        {
            String strSQL = "SELECT * FROM aboutCSUN";
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
                    AboutCSUN c = new AboutCSUN();
                    c.AboutId = sdr[0].ToString();
                    c.IntroText = sdr[1].ToString();
                    c.Address = sdr[2].ToString();

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
