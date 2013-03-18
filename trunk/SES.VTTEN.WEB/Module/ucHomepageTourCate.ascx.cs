using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;
using System.Data;

namespace SES.VTTEN.WEB.Module
{
    public partial class ucHomepageTourCate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptCategoryTourDataSource();
            }
        }
        protected void rptCategoryTourDataSource()
        {
            //rptCategoryInboundTour.DataSource = new TourTypeBL().GetTourCateHomepage(true);
            //rptCategoryInboundTour.DataBind();
            //rptCategoryOutboundTour.DataSource = new TourTypeBL().GetTourCateHomepage(false);
            //rptCategoryOutboundTour.DataBind();
            DataTable dt = new DataTable();
            dt = new TourBL().SelectTourByModuleIdAndRecordNumber(1, 6, true);
            rptInboundTour1.DataSource = new TourBL().SelectTourByModuleIdAndRecordNumber(1, 6, true);
            rptInboundTour1.DataBind();
            rptInboundTour2.DataSource = new TourBL().SelectTourByModuleIdAndRecordNumber(2, 6, true);
            rptInboundTour2.DataBind();
            rptInboundTour3.DataSource = new TourBL().SelectTourByModuleIdAndRecordNumber(3, 6, true);
            rptInboundTour3.DataBind();
            rptOutboundTour1.DataSource = new TourBL().SelectTourByModuleIdAndRecordNumber(1, 6, false);
            rptOutboundTour1.DataBind();
            rptOutboundTour2.DataSource = new TourBL().SelectTourByModuleIdAndRecordNumber(2, 6, false);
            rptOutboundTour2.DataBind();
            rptOutboundTour3.DataSource = new TourBL().SelectTourByModuleIdAndRecordNumber(3, 6, false);
            rptOutboundTour3.DataBind();
        }
        //protected void rptCategoryInboundTour_IntemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    RepeaterItem item = e.Item;
        //    if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        DataRowView drv = (DataRowView)item.DataItem;

        //        DataTable dtInboundTour = new TourBL().SelectTourByParentAndRecordNumberHomepage(int.Parse(drv["TourTypeID"].ToString()), 5);
        //        Repeater rptInboundTour = (Repeater)item.FindControl("rptInboundTour");
        //        rptInboundTour.DataSource = dtInboundTour;
        //        rptInboundTour.DataBind();
        //    }
        //}
       
        //protected void rptCategoryOutboundTour_IntemDataBound(object sender, RepeaterItemEventArgs e)
        //{
        //    RepeaterItem item = e.Item;
        //    if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
        //    {
        //        DataRowView drv = (DataRowView)item.DataItem;

        //        DataTable dtOutboundTour = new TourBL().SelectTourByParentAndRecordNumberHomepage(int.Parse(drv["TourTypeID"].ToString()), 5);
        //        Repeater rptOutboundTour = (Repeater)item.FindControl("rptOutboundTour");
        //        rptOutboundTour.DataSource = dtOutboundTour;
        //        rptOutboundTour.DataBind();
        //    }
        //}
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 100, new char[] { ' ', '.', ',', ';' }) + "...";
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