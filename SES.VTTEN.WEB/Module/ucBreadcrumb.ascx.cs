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
    public partial class ucBreadcrumb : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TourDO objTour = new TourDO();

            string url = Request.Url.AbsolutePath;
            url = url.Substring(1, url.Length - 1);
            string url1 = url.Replace(".", "/");
            string Module = url1.Substring(0, url1.IndexOf("/"));

            if (Module == "Tour-Booking")
            {
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    int TourID = int.Parse(Request.QueryString["ID"]);

                    objTour.TourID = TourID;
                    objTour = new TourBL().Select(objTour);
                    lblTitle.Text = "<a href='/Tour-Booking/" + TourID + "/" + FriendlyUrl(objTour.Alias) + "' title ='" + objTour.Title + "'> Booking: " + objTour.Title + "</a>";
                }
            }
            else if (Module == "Custom-Tour")
            {
                lblTitle.Text = "<a href='/Custom-Tour.aspx' title='customize tour'> Customize tour</a>";
            }
        }
        protected string FriendlyUrl(string strTitle)
        {
            return Ultility.Change_AV(strTitle);
        }
    }
}