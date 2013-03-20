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
    public partial class ucListLichKhoiHanhNuocNgoai : System.Web.UI.UserControl
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
                day = day + " ngày";
            else day = day + " ngày";
            if (night == "1" || night == "0")
                night = night + " đêm";
            else night = night + " đêm";
            return day + " " + night;
        }

        private void LoadRPT()
        {
            rptTourCatDataSource();

            Page.Title = "Lịch khởi hành - " + Ultility.Webtile();
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 290, new char[] { ' ', '.', ',', ';' }) + "...";
        }

        protected void rptTourCatDataSource()
        {
            CollectionPager1.MaxPages = 10000;
            CollectionPager1.PageSize = 20; // số items hiển thị trên một trang
            CollectionPager1.DataSource = new DataView(new TourBL().GetByLichKhoiHanh(false), "", "TourID DESC", DataViewRowState.CurrentRows);
            CollectionPager1.BindToControl = rptTourCat;
            rptTourCat.DataSource = CollectionPager1.DataSourcePaged;
            rptTourCat.DataBind();
        }
        public string CheckPrice(float PriceVND, float PriceUSD)
        {
            string sReturn = "";
            if ((PriceVND != 0) && (PriceUSD != 0))
            {
                sReturn += string.Format("{0:0,000}", PriceVND) + "đ";
                sReturn += " (" + PriceUSD + "$)";
            }
            if ((PriceVND == 0) && (PriceUSD != 0))
            {
                sReturn += PriceUSD + "$";
            }
            if ((PriceVND != 0) && (PriceUSD == 0))
            {
                sReturn += string.Format("{0:0,000}", PriceVND) + "đ";
            }
            if ((PriceVND == 0) && (PriceUSD == 0))
            {
                sReturn += "Liên hệ";
            }
            return sReturn;
        }
    }
}