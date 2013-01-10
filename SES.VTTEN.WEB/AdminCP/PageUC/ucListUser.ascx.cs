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
    public partial class ucListUser : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void LoadUser()
        {
            gvUser.DataSource = new UsersBL().SelectAll();
            gvUser.DataBind();
        }

        protected void gvUser_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUser.PageIndex = e.NewPageIndex;
            LoadUser();
        }

        protected void gvUser_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new UsersBL().Delete(new UsersDO { UserID = Convert.ToInt32(gvUser.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }

        protected void gvUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(gvUser.DataKeys[gvUser.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=User&UserID=" + UserID.ToString());
        }
    }
}