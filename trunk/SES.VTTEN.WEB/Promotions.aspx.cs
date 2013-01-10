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

namespace SES.VTTEN.WEB
{
    public partial class Promotions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadRPT();
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        public string Duration(string day, string night)
        {

            if (day == "1" || day == "0")
                day = day + " day";
            else day = day + " days";
            if (night == "1" || night == "0")
                night = night + " night";
            else night = night + " nights";
            return day + " " + night;
        }
        private void LoadRPT()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {              
                int TourID = int.Parse(Request.QueryString["ID"].ToString());
                rptTourCatDataSource();
                TourDO objTT = new TourBL().Select(new TourDO { TourID = TourID });

                    lblCatName.Text = "Promotion Tours";
                    Page.Title = lblCatName.Text + Ultility.Webtile();
                    
            }
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void rptTourCatDataSource()
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new TourBL().SelectSaleOff(20).DefaultView; ;

            CollectionPager1.BindToControl = rptTourCat;
            rptTourCat.DataSource = CollectionPager1.DataSourcePaged;
            rptTourCat.DataBind();
        }


    

    }
}
