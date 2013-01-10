using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.DO;
using SES.VTTEN.BL;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucListTourCat : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadTourCat();
        }

        private void LoadTourCat()
        {
            gvTourCat.DataSource = new TourCategoryBL().SelectAll();
            gvTourCat.DataBind();
        }

        protected void gvTourCat_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTourCat.PageIndex = e.NewPageIndex;
            LoadTourCat();
        }

        protected void gvTourCat_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new TourCategoryBL().Delete(new TourCategoryDO { TourCategoryID  = Convert.ToInt32(gvTourCat.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvTourCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TourCategoryID = Convert.ToInt32(gvTourCat.DataKeys[gvTourCat.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=TourCat&TourCategoryID=" + TourCategoryID.ToString());
        }
    }
}