using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SES.VTTEN.BL;
using SES.VTTEN.DO;

namespace SES.VTTEN.WEB.AdminCP.PageUC
{
    public partial class ucListLink : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadLink();
        }

        private void LoadLink()
        {
            gvLink.DataSource = new LinkBL().SelectAll();
            gvLink.DataBind();
        }
        protected void gvLink_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LinkID = Convert.ToInt32(gvLink.DataKeys[gvLink.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Link&LinkID=" + LinkID.ToString());
        }

        protected void gvLink_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLink.PageIndex = e.NewPageIndex;
            LoadLink();
        }

        protected void gvLink_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new LinkBL().Delete(new LinkDO { LinkID = Convert.ToInt32(gvLink.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }
    }
}