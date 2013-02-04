using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucQuangCaoTrai : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtConfig = new DataTable("dtConfig");
            dtConfig = new ConfigBL().SelectByConfigID(10);
            if ((dtConfig != null) && (dtConfig.Rows.Count > 0))
            {
                if (dtConfig.Rows[0][2] != null)
                {
                    lblQuangCao.Text = dtConfig.Rows[0][2].ToString();
                }
            }
        }
    }
}