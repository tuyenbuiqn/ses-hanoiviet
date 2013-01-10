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

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucListHotelBooking : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //gvHotelBookingDataSource();
            LoadHotelBooking();
            LoadTL();
        }

        private void LoadHotelBooking()
        {
            if (Request.QueryString["HotelID"] != null)
            {

                int HotelID = int.Parse(Request.QueryString["HotelID"].ToString());
                gvHotelBooking.DataSource = new BookingBL().SelectByHotel(HotelID);

            }
            else gvHotelBooking.DataSource = new BookingBL().SelectAll3();
                gvHotelBooking.DataBind();
        }

        private void LoadTL()
        {
            treeCategory.DataSource = new HotelBL().SelectHotelHasBooking();
            treeCategory.DataBind();
        }

        protected void gvHotelBooking_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvHotelBooking.PageIndex = e.NewPageIndex;
            LoadHotelBooking();
        }

        protected void gvHotelBooking_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new BookingBL().Delete(new BookingDO { BookingID = Convert.ToInt32(gvHotelBooking.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvHotelBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            int HotelBookingID = Convert.ToInt32(gvHotelBooking.DataKeys[gvHotelBooking.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=HotelBooking&BookingID=" + HotelBookingID.ToString());
        }

        public string FindLink(string id)
        {
            int ids = int.Parse(id);
            //DataTable dtx = new cmsCategoryBL().SelectOne(ids);
            string url = "";
            //if (dtx.Rows[0]["Type"].ToString().Equals("Cat"))
            //{
            HotelDO objHotel = new HotelDO();
            objHotel.HotelID = int.Parse(id);
            objHotel = new HotelBL().Select(objHotel);
            if (Request.QueryString["HotelID"] != null)
            {
                if (id == Request.QueryString["HotelID"].ToString())
                {
                    return "<a href='Default.aspx?Page=ListHotelBooking&HotelID=" + objHotel.HotelID + "'><b>" + objHotel.Title + "</b></a>";
                }
            }
            return "<a href='Default.aspx?Page=ListHotelBooking&HotelID=" + objHotel.HotelID + "'>" + objHotel.Title + "</a>";
        }

        protected void cboListAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cboListAll.Checked)
            {
                gvHotelBooking.DataSource = new BookingBL().SelectBookingByType(1);
                gvHotelBooking.DataBind();
            }
        }
    }
}