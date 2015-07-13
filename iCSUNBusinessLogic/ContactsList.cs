using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace iCSUNBusinessLogic
{
    public class ContactsList : List<Contacts>
    {
        #region Constructors
        public ContactsList()
        {

        }

        public ContactsList GetContactsList()
        {
            return DataPortal_Fetch();
        } 
        #endregion

        #region Data Access Methods
        private ContactsList DataPortal_Fetch()
        {
            String strSQL = "SELECT * FROM contacts";
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
                    Contacts c = new Contacts();
                    c.ContactId = sdr[0].ToString();
                    c.Name = sdr[1].ToString();
                    c.Phone = sdr[2].ToString();
                    c.Fax = sdr[3].ToString();

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
