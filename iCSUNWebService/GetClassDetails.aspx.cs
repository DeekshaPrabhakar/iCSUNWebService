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
    public partial class GetClassDetails : System.Web.UI.Page
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
                Response.Write("|ClassDetails");
            }
        }

        private void Fetch()
        {
            ClassDetailsList pl = new ClassDetailsList();
            pl.GetClassDetailsList();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Response.Clear();
            Response.Write(js.Serialize(pl));
            Response.End();

        }
    }
}
