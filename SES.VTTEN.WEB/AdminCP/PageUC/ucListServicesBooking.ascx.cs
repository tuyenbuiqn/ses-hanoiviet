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
    public partial class ucListServicesBooking : System.Web.UI.UserControl
    {
        string gvUniqueID = String.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadHotel();
        }

        protected void gvHotel_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRow dr = ((DataRowView)e.Row.DataItem).Row;
                if (dr["ServicesID"].ToString() == "1")
                {
                    ((Label)e.Row.FindControl("lblTitle")).Text = "Máy bay";
                }
                else if (dr["ServicesID"].ToString() == "2")
                {
                    ((Label)e.Row.FindControl("lblTitle")).Text = "Tầu";
                }
                else if (dr["ServicesID"].ToString() == "3")
                {
                    ((Label)e.Row.FindControl("lblTitle")).Text = "Thuê xe dịch vụ";
                }
                else                 {
                    ((Label)e.Row.FindControl("lblTitle")).Text = "";
                }
            }
        }
        
        private void LoadHotel()
        {
            gvHotel.DataSource = new HotelBL().SelectByServices();
            gvHotel.DataBind();
        }
        
        protected void gvHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int HotelID = Convert.ToInt32(gvHotel.DataKeys[gvHotel.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=ServicesBooking&BookingID=" + HotelID.ToString());
        }

        protected void gvHotel_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvHotel.PageIndex = e.NewPageIndex;
            LoadHotel();
        }

        protected void gvHotel_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new BookingBL().Delete(new BookingDO { BookingID = Convert.ToInt32(gvHotel.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }
    }
}