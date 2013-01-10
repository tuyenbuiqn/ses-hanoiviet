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
    public partial class ucMnuTravelGuide : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptTravelNewsDataSource();
            rptDestinationDataSource();
            rptPromotionDataSource();
            hplVN2.NavigateUrl  = "/Travel-Guide/5/About-Vietnam.aspx";
            imgVN.ImageUrl = "/Media/" + new ContentBL().Select(new ContentDO { ContentID = 5 }).ContentImage;
            lblVNDes.Text = WordCut2(new ContentBL().Select(new ContentDO { ContentID = 5 }).Description);
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 80, new char[] { ' ', '.', ',', ';' }) + "...";
        }
        public string WordCut2(string text)
        {
            return Ultility.WordCut(text, 200, new char[] { ' ', '.', ',', ';' }) + "...";
        }
        protected void rptTravelNewsDataSource()
        {
            rptTravelNews.DataSource = new NewsBL().SelectTopNews(3);
            rptTravelNews.DataBind();
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        protected void rptDestinationDataSource()
        {
            rptDestination.DataSource = new DestinationBL().SelectAll();
            rptDestination.DataBind();
        }
        protected void rptPromotionDataSource()
        {
            rptPromotion.DataSource = new TourBL().SelectSaleOff(1);
            rptPromotion.DataBind();
        }

     
    }
}