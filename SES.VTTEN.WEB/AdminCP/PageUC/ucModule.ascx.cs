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
    public partial class ucModule : System.Web.UI.UserControl
    {
        ModuleDO objmodule = new ModuleDO();
        protected void Page_Load(object sender, EventArgs e)
        {
            Functions.ddlDatabinder(ddvideo, VideoDO.VIDEOID_FIELD, VideoDO.TITLE_FIELD, new VideoBL().SelectAll());
            if (Request.QueryString["ModuleID"] != null)
            {
                objmodule.ModuleID = int.Parse(Request.QueryString["ModuleID"]);
                txtTitle.Text = new ModuleBL().Select(objmodule).ModuleName;
                ddvideo.SelectedValue = new ModuleBL().Select(objmodule).VideoID.ToString();
            }
        }

        protected void btSave_Click(object sender, EventArgs e)
        {
            objmodule.ModuleName = txtTitle.Text;
            objmodule.VideoID = int.Parse(ddvideo.SelectedValue);
            if (objmodule.ModuleID <= 0)
                new ModuleBL().Insert(objmodule);
            else
                new ModuleBL().Update(objmodule);
            Functions.Alert("Cập nhật thành công");
        }

    }
}