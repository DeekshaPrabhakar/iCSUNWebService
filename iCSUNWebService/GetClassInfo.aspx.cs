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
    public partial class GetClassInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Fetch();
            }
            catch
            {
                //Response.Write("error");
            }
            finally
            {
                Response.Write("|ClassInfo");
            }
        }

        private void Fetch()
        {
            ClassInfoList pl = new ClassInfoList();
            pl.GetClassInfoList();

            JavaScriptSerializer js = new JavaScriptSerializer();
            Response.Clear();
            Response.Write(js.Serialize(pl));
            Response.End();

        }
    }
}
