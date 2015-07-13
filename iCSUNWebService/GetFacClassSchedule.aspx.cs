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
    public partial class GetFacClassSchedule : System.Web.UI.Page
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
                Response.Write("|FacClassSchedule");
            }
        }

        private void Fetch()
        {
            FacClassScheduleList pl = new FacClassScheduleList();
            pl.GetFacClassScheduleList();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Response.Clear();
            Response.Write(js.Serialize(pl));
            Response.End();
        }
    }
}
