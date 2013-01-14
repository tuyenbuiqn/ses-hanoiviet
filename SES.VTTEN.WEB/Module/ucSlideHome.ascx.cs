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
    public partial class ucSlideHome : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                rptSlideDataSource();
        }
        protected void rptSlideDataSource()
        {
            rptMainSlide.DataSource = new SlideBL().SelectByCategoryID(0);
            rptThumbSlide.DataSource = new SlideBL().SelectByCategoryID(0);
            rptMainSlide.DataBind();
            rptThumbSlide.DataBind();
        }
    }
}