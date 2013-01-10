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
    public partial class ucMnuTravel : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            rptPromotionDataSource();
            hplVN1.NavigateUrl = hplVN2.NavigateUrl = hplVN3.NavigateUrl = "/Travel-Guide/5/About-Vietnam.aspx";
            imgVN.ImageUrl = "/Media/" + new ContentBL().Select(new ContentDO { ContentID = 5 }).ContentImage;
            lblVNDes.Text = WordCut(new ContentBL().Select(new ContentDO { ContentID = 5 }).Description);

            DataTable dtMenuChild = new TourTypeBL().SelectByTopIDOnlyChild(1);
            rptTripEx.DataSource = dtMenuChild;
            rptTripEx.DataBind();

            DataTable dtMenuChildPack = new TourTypeBL().SelectByTopIDOnlyChild(14);
            rptPack.DataSource = dtMenuChildPack;
            rptPack.DataBind();

        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 200, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        protected void rptPromotionDataSource()
        {
            rptPromotion.DataSource = new TourBL().SelectSaleOff(1);
            rptPromotion.DataBind();
        }
    }
}