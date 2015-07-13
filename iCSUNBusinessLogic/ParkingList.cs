using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace iCSUNBusinessLogic
{
    [Serializable()]

    public class ParkingList :List<Parking>
    {
        #region Constructors
        public ParkingList()
        {

        }

        public ParkingList GetParkingList(string uType)
        {
            return DataPortal_Fetch(uType);
        } 
        #endregion

        #region Data Access Methods
        private ParkingList DataPortal_Fetch(string utype)
        {
            String strSQL = "SELECT * FROM StudentParking";
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
                    Parking p = new Parking();
                    p.ParkingLocName = sdr[1].ToString();
                    p.ParkingCood1 = sdr[2].ToString();
                    p.ParkingCood2 = sdr[3].ToString();
                    p.ParkingCood3 = sdr[4].ToString();
                    p.ParkingCood4 = sdr[5].ToString();

                    this.Add(p);
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
