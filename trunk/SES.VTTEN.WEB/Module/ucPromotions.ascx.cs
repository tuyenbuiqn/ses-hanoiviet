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
    public partial class ucPromotions : System.Web.UI.UserControl
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
                int TourTypeID = int.Parse(Request.QueryString["ID"].ToString());
                //bindatalist(new TourBL().SelectbyTourType(TourTypeID));
                rptTourCatDataSource(TourTypeID);
                TourTypeDO objTT = new TourTypeBL().Select(new TourTypeDO { TourTypeID = TourTypeID });

                Page.Title = objTT.Title + Ultility.Webtile();
                HtmlMeta meta = new HtmlMeta();
                meta.Name = "description";
                meta.Content = objTT.Description;
                Page.Header.Controls.Add(meta);

            }
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void rptTourCatDataSource(int TourTypeID)
        {

            CollectionPager1.MaxPages = 10000;

            CollectionPager1.PageSize = 5; // số items hiển thị trên một trang

            CollectionPager1.DataSource = new TourBL().SelectOutPromotion().DefaultView;

            CollectionPager1.BindToControl = rptTourCat;
            rptTourCat.DataSource = CollectionPager1.DataSourcePaged;
            rptTourCat.DataBind();
        }
    }
}