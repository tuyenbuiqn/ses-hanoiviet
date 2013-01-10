using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucHotTours : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptHotToursDataSource();
        }

        protected void rptHotToursDataSource()
        {
            rptHotTours.DataSource = new TourBL().SelectSaleOff(10);
            rptHotTours.DataBind();
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
    }
}