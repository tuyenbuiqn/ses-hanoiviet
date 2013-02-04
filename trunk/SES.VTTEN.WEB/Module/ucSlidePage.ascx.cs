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
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucSlidePage : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string url = Request.Url.AbsolutePath;
            url = url.Substring(1, url.Length - 1);
            string url1 = url.Replace(".", "/");
            string Module = url1.Substring(0, url1.IndexOf("/"));

            if (Module == "Hotel-Category" || Module == "Hotel" || Module == "Hotel-Booking")
            {
                rptSlideDataSource(2);
            }
            else 
            {
                rptSlideDataSource(1);
            }
            
        }

        protected void rptSlideDataSource(int CateID)
        {
            DataTable dt = new DataTable();
            dt = new SlideBL().SelectByCategoryID(CateID);
            rptSlide.DataSource = new SlideBL().SelectByCategoryID(CateID);
            rptSlide.DataBind();
        }
    }
}