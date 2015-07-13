using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using iCSUNBusinessLogic;
using System.Web.Script.Serialization;

namespace iCSUNWebService
{
    public partial class GetFacOfficeHours : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Fetch();
            }
            catch
            {

            }
            finally
            {
                Response.Write("|FacOfficeHours");
            }
        }

        private void Fetch()
        {
            FacOfficeHoursList pl = new FacOfficeHoursList();
            pl.GetFacOfficeHoursList();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Response.Clear();
            Response.Write(js.Serialize(pl));
            Response.End();

        }
    }
}
