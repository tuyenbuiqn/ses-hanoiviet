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
    public partial class ucListContent : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private void LoadContent()
        {
            gvContent.DataSource = new ContentBL().SelectAll();
            gvContent.DataBind();
        }
        protected void gvContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ContentID = Convert.ToInt32(gvContent.DataKeys[gvContent.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Content&ContentID=" + ContentID.ToString());
        }

        protected void gvContent_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvContent.PageIndex = e.NewPageIndex;
            LoadContent();
        }

        protected void gvContent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new ContentBL().Delete(new ContentDO { ContentID = Convert.ToInt32(gvContent.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }
    }
}