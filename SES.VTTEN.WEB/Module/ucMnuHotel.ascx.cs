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
    public partial class ucMnuHotel : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            rptHotelsDataSource();
            rptTopRateHotelDataSource();
            hplVN1.NavigateUrl = "/Hotel-Category/0/Hotels-in-Vietnam.aspx";
            

        }

        protected void rptHotelsDataSource()
        {
            rptHotels.DataSource = new DestinationBL().SelectHotelCat();
            rptHotels.DataBind();
        }
        public string StarRate(string s)
        {
            int n = int.Parse(s);
            return Ultility.StarRateHome(n);
        }

        protected void rptTopRateHotelDataSource()
        {
            rptTopRate.DataSource = new HotelBL().SelectTopStarRates(3);
            rptTopRate.DataBind();
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 150, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

    }
}
