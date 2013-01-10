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
    public partial class ucListHotel : System.Web.UI.UserControl
    {
        string gvUniqueID = String.Empty;
     
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadHotel();
            LoadTLData();
        }
        private void LoadTLData()
        {
            treeCategory.DataSource = new DestinationBL().SelectAll();
            treeCategory.DataBind();
            treeCategory.ExpandToLevel(3);
        }
        private void LoadHotel()
        {

            if (Request.QueryString["DestinationID"] != null)
            {
                gvHotel.DataSource = new HotelBL().SelectbyDestination(int.Parse(Request.QueryString["DestinationID"].ToString()));

            }
            else
                gvHotel.DataSource = new HotelBL().SelectAll();
            gvHotel.DataBind();
        }
        protected void gvHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int HotelID = Convert.ToInt32(gvHotel.DataKeys[gvHotel.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Hotel&HotelID=" + HotelID.ToString());
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
                new HotelBL().Delete(new HotelDO { HotelID = Convert.ToInt32(gvHotel.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }
        public string FindLink(string id)
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
                    return "<a href='Default.aspx?Page=ListHotel&DestinationID=" + objDes.DestinationID + "'><b>" + objDes.Title + "</b></a>";
                }
            }
            return "<a href='Default.aspx?Page=ListHotel&DestinationID=" + objDes.DestinationID + "'>" + objDes.Title + "</a>";




        }


    }
}