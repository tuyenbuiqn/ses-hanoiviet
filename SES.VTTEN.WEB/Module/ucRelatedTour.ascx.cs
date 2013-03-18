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
    public partial class ucRelatedTour : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int TourID = int.Parse(Request.QueryString["ID"].ToString());

                rptRelatedTourDataSource(TourID);
            }

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
        
        protected void rptRelatedTourDataSource(int TourID)
        {
            int TourTypeID = int.Parse(new TourBL().Select(new TourDO{TourID = TourID}).TourTypeID.ToString());

            DataTable dtOther = new TourBL().SelectTourByParentAndRecordNumber(TourTypeID,5);
            rptRelatedTours.DataSource = new DataView(dtOther, "TourID <>" + TourID, "", DataViewRowState.CurrentRows);
            rptRelatedTours.DataBind();
        }

        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }

        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 50, new char[] { ' ', '.', ',', ';' }) + "...";
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
                sReturn += "Giá: Liên hệ";
            }
            return sReturn;
        }
    }
}