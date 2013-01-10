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
    public partial class ucListService : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadService();
        }

        private void LoadService()
        {
            gvService.DataSource = new ServiceBL().SelectAll();
            gvService.DataBind();
        }
        protected void gvService_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ServiceID = Convert.ToInt32(gvService.DataKeys[gvService.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Service&ServiceID=" + ServiceID.ToString());
        }

        protected void gvService_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvService.PageIndex = e.NewPageIndex;
            LoadService();
        }

        protected void gvService_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new ServiceBL().Delete(new ServiceDO { ServiceID = Convert.ToInt32(gvService.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }
    }
}