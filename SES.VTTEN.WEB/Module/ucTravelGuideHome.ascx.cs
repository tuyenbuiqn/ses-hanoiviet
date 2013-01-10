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
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucTravelGuideHome : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptGuide.DataSource = new ContentBL().SelectNumberType(10,1);
            rptGuide.DataBind();
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
    }
}