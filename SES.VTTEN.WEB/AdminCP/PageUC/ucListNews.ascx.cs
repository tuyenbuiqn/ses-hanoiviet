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
    public partial class ucListNews : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadNews();
        }

        private void LoadNews()
        {
            gvNews.DataSource = new NewsBL().SelectAll();
            gvNews.DataBind();
        }

        protected void gvNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            int NewsID = Convert.ToInt32(gvNews.DataKeys[gvNews.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=News&NewsID=" + NewsID.ToString());
        }

        protected void gvNews_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvNews.PageIndex = e.NewPageIndex;
            LoadNews();
        }

        protected void gvNews_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new NewsBL().Delete(new NewsDO { NewsID = Convert.ToInt32(gvNews.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }
    }
}