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
    public partial class Tour_Destination : System.Web.UI.Page
    {
        string sReturn = "";
        TourTypeDO objTT = new TourTypeDO();
        TourTypeDO objTD = new TourTypeDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                int TourTypeID = int.Parse(Request.QueryString["ID"].ToString());
                if (TourTypeID == 0)
                {
                    lblTitle.Text = "Danh sách tour";
                }
                else
                {
                    lblTitle.Text = "<a href=\"/Default.aspx\" title=\"Trang chủ\">Trang chủ</a>" + TourCate(TourTypeID);
                }
            }
        }

        public string TourCate(int TourTypeID)
        {
            try
            {
                objTT = new TourTypeBL().Select(new TourTypeDO { TourTypeID = TourTypeID });
            }
            catch (Exception)
            {
            }

            if (objTT.ParentID == 0)
            {
                sReturn = " » " + "<a href=\"/Tour-Category/" + objTT.TourTypeID.ToString() + "/" + objTT.Alias + ".aspx\" title=\"" + objTT.Alias + "\">" + objTT.Title + "</a>" + sReturn;
            }
            else
            {
                sReturn = " » " + "<a href=\"/Tour-Category/" + objTT.TourTypeID.ToString() + "/" + objTT.Alias + ".aspx\" title=\"" + objTT.Alias + "\">" + objTT.Title + "</a>" + sReturn;
                TourCate(objTT.ParentID);
            }
            return sReturn;
        }
    }
}
