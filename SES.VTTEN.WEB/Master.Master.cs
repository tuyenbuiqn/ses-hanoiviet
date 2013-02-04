using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;
using System.Data;

namespace SES.VTTEN.WEB
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string scr = "<script type='text/javascript'> jQuery(document).ready(function () {";
            scr += "jQuery('#carouselTour_1').jcarousel({ scroll:1});";
            scr += "jQuery('#carouselTour_2').jcarousel({ scroll:1});";
            scr += "jQuery('#carouselTour_3').jcarousel({ scroll:1});";
            scr += "jQuery('#carouselTourOut_1').jcarousel({ scroll:1});";
            scr += "jQuery('#carouselTourOut_2').jcarousel({ scroll:1});";
            scr += "jQuery('#carouselTourOut_3').jcarousel({ scroll:1});";
            scr += "  });</script>";
            lblscr.Text = scr;

            rptListVNTour.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(1);//List theo du lịch trong nước
            rptListVNTour.DataBind();

            rptListENTour.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(20);//List theo du lịch nước ngoài
            rptListENTour.DataBind();

            rptListHotelItemTop.DataSource = new DestinationBL().SelectAll();//List khachs sạn trên menu top
            rptListHotelItemTop.DataBind();
        }

        protected void lnkTop_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Tour-Category/1/Vietnam-Day-Trip--Excursions.aspx");
        }

        protected void lnk2Top_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Tour-Category/20/du-lich-nuoc-ngoai.aspx");
        }

        protected void rptListENTour_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int ItemId = Int32.Parse(e.CommandArgument.ToString());
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListEnTourItem = (Repeater)e.Item.FindControl("rptListEnTourItem");
            DataTable dtItem = new DataTable("dtItem");
            dtItem = new TourTypeBL().SelectOne(ItemId);//Lấy một bản ghi theo id

            if ((dtItem != null) && (dtItem.Rows.Count > 0))
            {
                Session["Visible"] = "1";
                if ((dtItem.Rows[0]["TourTypeID"] != null) && (dtItem.Rows[0]["Alias"] != null))
                {
                    Response.Redirect("/Tour-Category/" + dtItem.Rows[0]["TourTypeID"].ToString() + "/" + dtItem.Rows[0]["Alias"].ToString() + ".aspx");
                }
            }
        }

        protected void rptListENTour_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
            DataRowView dtItem = (DataRowView)e.Item.DataItem;
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListEnTourItem = (Repeater)e.Item.FindControl("rptListEnTourItem");
            if (dtItem["TourTypeID"] != null)
            {
                int ItemId = Int32.Parse(dtItem["TourTypeID"].ToString());
                lnkCategory.CommandName = "ChiTiet";
                lnkCategory.CommandArgument = ItemId.ToString();
                if (dtItem["Title"] != null)
                {
                    lnkCategory.Text = dtItem["Title"].ToString();
                    lnkCategory.ToolTip = dtItem["Title"].ToString();
                }
                rptListEnTourItem.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(ItemId);//List theo du lịch trong nước, theo Id
                rptListEnTourItem.DataBind();
                //rptListVnTourleftItem.Visible = false;
            }
        }

        protected void rptListVNTour_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int ItemId = Int32.Parse(e.CommandArgument.ToString());
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListVnTourItem = (Repeater)e.Item.FindControl("rptListVnTourItem");
            DataTable dtItem = new DataTable("dtItem");
            dtItem = new TourTypeBL().SelectOne(ItemId);//Lấy một bản ghi theo id

            if ((dtItem != null) && (dtItem.Rows.Count > 0))
            {
                Session["Visible"] = "1";
                if ((dtItem.Rows[0]["TourTypeID"] != null) && (dtItem.Rows[0]["Alias"] != null))
                {
                    Response.Redirect("/Tour-Category/" + dtItem.Rows[0]["TourTypeID"].ToString() + "/" + dtItem.Rows[0]["Alias"].ToString() + ".aspx");
                }
            }
        }

        protected void rptListVNTour_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
            DataRowView dtItem = (DataRowView)e.Item.DataItem;
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListVnTourItem = (Repeater)e.Item.FindControl("rptListVnTourItem");
            if (dtItem["TourTypeID"] != null)
            {
                int ItemId = Int32.Parse(dtItem["TourTypeID"].ToString());
                lnkCategory.CommandName = "ChiTiet";
                lnkCategory.CommandArgument = ItemId.ToString();
                if (dtItem["Title"] != null)
                {
                    lnkCategory.Text = dtItem["Title"].ToString();
                    lnkCategory.ToolTip = dtItem["Title"].ToString();
                }
                rptListVnTourItem.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(ItemId);//List theo du lịch trong nước, theo Id
                rptListVnTourItem.DataBind();
                //rptListVnTourleftItem.Visible = false;
            }
        }
    }
}