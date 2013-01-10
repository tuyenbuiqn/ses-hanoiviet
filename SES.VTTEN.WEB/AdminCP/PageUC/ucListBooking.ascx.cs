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
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucListBooking : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {       
                LoadBooking();
                LoadTL();   
        }

        private void LoadTL()
        {
            treeCategory.DataSource = new DestinationBL().SelectAll();
            treeCategory.DataBind();
            treeCategory.ExpandToLevel(3);
        }

        private void LoadBooking()
        {
            if (Request.QueryString["DestinationID"] != null)
            {

                int DesID = int.Parse(Request.QueryString["DestinationID"].ToString());
                gvBooking.DataSource = new BookingBL().SelectByDes(DesID);

            }
            else gvBooking.DataSource = new BookingBL().SelectAll3();
            gvBooking.DataBind();

        }

        protected void gvBooking_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBooking.PageIndex = e.NewPageIndex;
            LoadBooking();
        }

        protected void gvBooking_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new BookingBL().Delete(new BookingDO { BookingID = Convert.ToInt32(gvBooking.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvBooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            int BookingID = Convert.ToInt32(gvBooking.DataKeys[gvBooking.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Booking&BookingID=" + BookingID.ToString());
        }

        public string FindLink1(string id)
        {
            int ids = int.Parse(id);
            //DataTable dtx = new cmsCategoryBL().SelectOne(ids);
            string url = "";
            //if (dtx.Rows[0]["Type"].ToString().Equals("Cat"))
            //{
            DestinationDO objDes = new DestinationDO();
            objDes.DestinationID = int.Parse(id);
            objDes = new DestinationBL().Select(objDes);
            if (Request.QueryString["DestinationID"] != null)
            {
                if (id == Request.QueryString["DestinationID"].ToString())
                {
                    return "<a href='Default.aspx?Page=ListBooking&DestinationID=" + objDes.DestinationID + "'><b>" + objDes.Title + "</b></a>";
                }
            }
            return "<a href='Default.aspx?Page=ListBooking&DestinationID=" + objDes.DestinationID + "'>" + objDes.Title + "</a>";
        }
        protected void cboListAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cboListAll.Checked)
            {
                gvBooking.DataSource = new BookingBL().SelectBookingByType(0);
                gvBooking.DataBind();
            }
        }
    }
}