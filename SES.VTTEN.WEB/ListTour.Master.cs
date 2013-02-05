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
    public partial class ListTour : System.Web.UI.MasterPage
    {
        SlideBL slideBL = new SlideBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //rptListImage.DataSource = slideBL.SelectByCategoryID(1);
            //rptListImage.DataBind();

            rptListVNTour.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(1);//List theo du lịch trong nước
            rptListVNTour.DataBind();

            rptListENTour.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(20);//List theo du lịch nước ngoài
            rptListENTour.DataBind();

            rptListVnTourleft.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(1);//List theo du lịch trong nước
            rptListVnTourleft.DataBind();

            rptListEnTourleft.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(20);//List theo du lịch nước ngoài
            rptListEnTourleft.DataBind();

            DataTable dt = new DataTable("dt");
            dt = new DestinationBL().SelectAll();//List khachs sạn trên menu top

            if ((dt != null) && (dt.Rows.Count > 0))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataTable dtHotel = new DataTable("dt");
                    dtHotel = new HotelBL().SelectbyDestination(int.Parse(dt.Rows[i]["DestinationID"].ToString()));
                    if ((dtHotel == null) || (dtHotel.Rows.Count == 0))
                    {
                        dt.Rows[i].Delete();
                    }
                }
            }
            if ((dt != null) && (dt.Rows.Count > 0))
            {
                rptListHotelItemTop.DataSource = dt;//List khachs sạn trên menu top
                rptListHotelItemTop.DataBind();
            }

            rptListHotelItem.DataSource = dt;//List khachs sạn trên menu left
            rptListHotelItem.DataBind();

            //Ẩn hiện menu con của Du lịch việt nam. Phần này khá lằng nhằng :(
            if ((Request.QueryString["P"] != null) && ((Request.QueryString["ID"] != null)))
            {
                string TourPage = Request.QueryString["P"].ToString();
                string TourPageID = Request.QueryString["ID"].ToString();
                //string sVisible = "0";
                //if (Session["Visible"] != null)
                //{
                //    sVisible = Session["Visible"].ToString();
                //    Session.Remove("Visible");
                //}

                //if (sVisible == "1")
                //{
                //    Full1.Visible = true;
                //    Full2.Visible = true;
                //}
                //else
                //{

                    if (TourPage == "Tour")//Để khi vào chi tiết tour cũng vẫn hiện thì menu bên trái
                    {
                        Full1.Visible = true;
                        Full2.Visible = true;
                        divShowDichVu.Visible = false;
                        divTinTuc.Visible = false;
                        divGallery.Visible = false;
                    }
                    //else if ((TourPage == "Tour-Category") && (TourPageID != "1") && (TourPageID != "20"))//Để khi click vào các item con bên trong menu trái thì menu bên trái vẫn hiện tất
                    else if (TourPage == "Tour-Category")
                    {
                        Full1.Visible = true;
                        Full2.Visible = true;
                        divShowDichVu.Visible = false;
                        divTinTuc.Visible = false;
                        divGallery.Visible = false;
                    }
                    else if ((TourPage == "Travel-News")||(TourPage == "News"))
                    {
                        divShowDichVu.Visible = false;
                        divTinTuc.Visible = true;
                        divGallery.Visible = false;
                        Full1.Visible = false;
                        Full2.Visible = false;
                    }
                    else if ((TourPage == "Hotel-Category") || (TourPage == "Hotel"))
                    {
                        divShowDichVu.Visible = true;
                        divTinTuc.Visible = false;
                        divGallery.Visible = false;
                        Full1.Visible = false;
                        Full2.Visible = false;
                    }
                    else if ((TourPage == "Albums") || (TourPage == "Videos") || (TourPage == "AlbumDetail") || (TourPage == "VideoDetail"))
                    {
                        divShowDichVu.Visible = false;
                        divTinTuc.Visible = false;
                        divGallery.Visible = true;
                        Full1.Visible = false;
                        Full2.Visible = false;
                    }
                    else
                    {
                        Full1.Visible = false;
                        Full2.Visible = false;
                        divShowDichVu.Visible = false;
                        divTinTuc.Visible = false;
                        divGallery.Visible = false;
                    }
                //}
            }
            //end Ẩn hiện menu con của Du lịch việt nam
        }

        protected void lnk_Click(object sender, EventArgs e)
        {
            
            Session["Visible"] = "1";
            Response.Redirect("/Tour-Category/1/Vietnam-Day-Trip--Excursions.aspx");
        }

        protected void lnk2_Click(object sender, EventArgs e)
        {
            Session["Visible"] = "1";
            Response.Redirect("/Tour-Category/20/du-lich-nuoc-ngoai.aspx");
        }

        protected void rptListVnTourleft_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
            DataRowView dtItem = (DataRowView)e.Item.DataItem;
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListVnTourleftItem = (Repeater)e.Item.FindControl("rptListVnTourleftItem");
            if (dtItem["TourTypeID"] != null)
            {
                int ItemId = Int32.Parse(dtItem["TourTypeID"].ToString());
                lnkCategory.CommandName = "ChiTiet";
                lnkCategory.CommandArgument = ItemId.ToString();
                if (dtItem["Title"] != null)
                {
                    lnkCategory.Text = "» " + dtItem["Title"].ToString();
                    lnkCategory.ToolTip = dtItem["Title"].ToString();
                }
                rptListVnTourleftItem.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(ItemId);//List theo du lịch trong nước, theo Id
                rptListVnTourleftItem.DataBind();
                //rptListVnTourleftItem.Visible = false;
            }
        }

        protected void rptListVnTourleft_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int ItemId = Int32.Parse(e.CommandArgument.ToString());
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListVnTourleftItem = (Repeater)e.Item.FindControl("rptListVnTourleftItem");
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

        protected void rptListEnTourleft_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int ItemId = Int32.Parse(e.CommandArgument.ToString());
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListEnTourleftItem = (Repeater)e.Item.FindControl("rptListEnTourleftItem");
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

        protected void rptListEnTourleft_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemIndex < 0)
            {
                return;
            }
            DataRowView dtItem = (DataRowView)e.Item.DataItem;
            LinkButton lnkCategory = (LinkButton)e.Item.FindControl("lnkCategory");
            Repeater rptListEnTourleftItem = (Repeater)e.Item.FindControl("rptListEnTourleftItem");
            if (dtItem["TourTypeID"] != null)
            {
                int ItemId = Int32.Parse(dtItem["TourTypeID"].ToString());
                lnkCategory.CommandName = "ChiTiet";
                lnkCategory.CommandArgument = ItemId.ToString();
                if (dtItem["Title"] != null)
                {
                    lnkCategory.Text = "» " + dtItem["Title"].ToString();
                    lnkCategory.ToolTip = dtItem["Title"].ToString();
                }
                rptListEnTourleftItem.DataSource = new TourTypeBL().SelectByTopIDOnlyChild(ItemId);//List theo du lịch ngoài nước, theo Id
                rptListEnTourleftItem.DataBind();
                //rptListVnTourleftItem.Visible = false;
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

        protected void lnkTop_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Tour-Category/1/Vietnam-Day-Trip--Excursions.aspx");
        }

        protected void lnk2Top_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Tour-Category/20/du-lich-nuoc-ngoai.aspx");
        }
    }
}