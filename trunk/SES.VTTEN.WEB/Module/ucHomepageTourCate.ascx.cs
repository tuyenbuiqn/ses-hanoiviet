﻿using System;
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
            rptCategoryInboundTour.DataSource = new TourTypeBL().GetTourCateHomepage(true);
            rptCategoryInboundTour.DataBind();
            rptCategoryOutboundTour.DataSource = new TourTypeBL().GetTourCateHomepage(false);
            rptCategoryOutboundTour.DataBind();
        }
        protected void rptCategoryInboundTour_IntemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;

                DataTable dtInboundTour = new TourBL().SelectTourByParentAndRecordNumberHomepage(int.Parse(drv["TourTypeID"].ToString()), 5);
                Repeater rptInboundTour = (Repeater)item.FindControl("rptInboundTour");
                rptInboundTour.DataSource = dtInboundTour;
                rptInboundTour.DataBind();
            }
        }
       
        protected void rptCategoryOutboundTour_IntemDataBound(object sender, RepeaterItemEventArgs e)
        {
            RepeaterItem item = e.Item;
            if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
            {
                DataRowView drv = (DataRowView)item.DataItem;

                DataTable dtOutboundTour = new TourBL().SelectTourByParentAndRecordNumberHomepage(int.Parse(drv["TourTypeID"].ToString()), 5);
                Repeater rptOutboundTour = (Repeater)item.FindControl("rptOutboundTour");
                rptOutboundTour.DataSource = dtOutboundTour;
                rptOutboundTour.DataBind();
            }
        }
        public string FriendlyUrl(string s)
        {
            return Ultility.Change_AV(s);
        }
        public string WordCut(string text)
        {
            return Ultility.WordCut(text, 100, new char[] { ' ', '.', ',', ';' }) + "...";
        }
    }
}