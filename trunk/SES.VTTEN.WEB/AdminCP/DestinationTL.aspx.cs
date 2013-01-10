using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.AdminCP
{
    public partial class DestinationTL : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tlDestination.DataSource = new DestinationBL().SelectAll();
            tlDestination.DataBind();
            tlDestination.ExpandToLevel(3);
        }
    }
}
