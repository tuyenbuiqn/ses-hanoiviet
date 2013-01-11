using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucHotelList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRPT();
        }
        
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        
        private void LoadRPT()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int DestinationID = int.Parse(Request.QueryString["ID"].ToString());
                rptHotelCatDataSource(DestinationID);
            }
        }
        
        public string StarRate(string s)
        {
            int n = int.Parse(s);
            return Ultility.StarRateHome(n);
        }
        
        protected void rptHotelCatDataSource(int DestinationID)
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new HotelBL().SelectbyDestination(DestinationID).DefaultView;

            CollectionPager1.BindToControl = rptHotelCat;
            rptHotelCat.DataSource = CollectionPager1.DataSourcePaged;
            rptHotelCat.DataBind();
        }
        
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 500, new char[] { ' ', '.', ',', ';' }) + "...";
        }
    }
}