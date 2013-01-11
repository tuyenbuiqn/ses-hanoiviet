using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucFooter : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                ltrFooter.Text = new ConfigBL().Select(new ConfigDO { ConfigID = 3}).ConfigValue;
        }
    }
}