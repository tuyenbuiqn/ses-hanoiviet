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
    public partial class ucListModule : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadModule();
        }

        private void LoadModule()
        {
            gvModule.DataSource = new ModuleBL().SelectAll();
            gvModule.DataBind();
        }
        protected void gvModule_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ModuleID = Convert.ToInt32(gvModule.DataKeys[gvModule.SelectedIndex].Value);
            Functions.RedirectPage("Default.aspx?Page=Module&ModuleID=" + ModuleID.ToString());
        }

        protected void gvModule_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvModule.PageIndex = e.NewPageIndex;
            LoadModule();
        }

        protected void gvModule_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                new ModuleBL().Delete(new ModuleDO { ModuleID = Convert.ToInt32(gvModule.DataKeys[e.RowIndex].Value) });
                Functions.Alert("Xóa bản tin thành công!", Request.Url.ToString());
            }
            catch
            {
                Functions.Alert("Có lỗi xảy ra!", Request.Url.ToString());
            }
        }
    }
}